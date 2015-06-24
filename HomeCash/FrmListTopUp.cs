using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCash
{
	using System.Collections.Specialized;

	public partial class FrmListTopUp : Form
	{

		public class ComboBoxItem
		{
			public string Id {
				get;
				set;
			}

			public string Name {
				get;
				set;
			}

			public override string ToString() {
				return Name;
			}
		}


		public FrmListTopUp() {
			InitializeComponent();
		}

		private async void LoadDataAsync() {
			cbCashList.Items.Clear();
			lvTopUp.Items.Clear();
			cbCashList.Items.AddRange(await LoadCash());
			lvTopUp.Items.AddRange(await LoadPurcaseAsync());
		}

		private Task<ComboBoxItem[]> LoadCash() {
			return Task<ComboBoxItem[]>.Factory.StartNew(() => {
				var list = new List<ComboBoxItem>();
				DbReader reader;
				if ((reader = Db.Read("select id, name from cash order by name")) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						var id = buf["id"];
						var name = buf["name"];
						var item = new ComboBoxItem {
							Id = id,
							Name = name
						};
						list.Add(item);
					}
				}
				return list.ToArray();
			});
		}

		private Task<ListViewItem[]> LoadPurcaseAsync() {
			return Task<ListViewItem[]>.Factory.StartNew(() => {
				var itemCollection = new List<ListViewItem>();
				string sql = "select p.id, p.date, p.sum, \n" +
					" (select c.name from cash c where c.id = p.cashid) as cash \n" +
					" from purchase p \n" +
					" where p.istotop=1 " +
					" order by date \n";
				DbReader reader;
				if ((reader = Db.Read(sql)) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						string date = string.Empty;
						DateTime dateTime;
						if (DateTime.TryParse(buf["date"], out dateTime)) {
							date = dateTime.ToString("dd-MM-yyyy");
						}
						var item = new ListViewItem {
							Tag = buf["id"],
							Text = date
						};
						item.SubItems.Add(buf["cash"]);
						item.SubItems.Add(buf["sum"]);
						itemCollection.Add(item);
					}
				}
				return itemCollection.ToArray();
			});
		}

		private void btnOk_Click(object sender, EventArgs e) {
			Close();
		}

		private void FrmListTopUp_Load(object sender, EventArgs e) {
			LoadDataAsync();
		}

		private void AddToolStripMenuItem_Click(object sender, EventArgs e) {
			gbAddEdit.Visible = true;
			txbObject.Tag = null;
			btnAddEdit.Text = @"Добавить";
			lblAddEditHeader.Text = @"Добавить пополнение";
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvTopUp.SelectedItems.Count > 0) {
				txbObject.Tag = lvTopUp.SelectedItems[0].Tag;
				txbObject.Text = lvTopUp.SelectedItems[0].SubItems[2].Text;
				SelectComboBox(cbCashList, lvTopUp.SelectedItems[0].SubItems[1].Text);
				gbAddEdit.Visible = true;
				btnAddEdit.Text = @"Изменить";
				lblAddEditHeader.Text = @"Изменить пополнение";
			}
		}

		private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvTopUp.SelectedItems.Count > 0) {
				var cash = lvTopUp.SelectedItems[0].SubItems[1].Text;
				var sum = lvTopUp.SelectedItems[0].SubItems[2].Text;
				var date = lvTopUp.SelectedItems[0].Text;
				var id = lvTopUp.SelectedItems[0].Tag;
				var result = MessageBox.Show(@"Внимание!",
					string.Format(@"Вы действительно хотите удалить пополнение с датой {0} на счет {1} и суммой {2} ?",
					date, cash, sum),
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					Db.Exec("delete from cash where id='{0}'", id);
				}
				LoadDataAsync();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			gbAddEdit.Visible = false;
		}

		private void btnAddEdit_Click(object sender, EventArgs e) {
			double sum;

			if (!double.TryParse(txbObject.Text, out sum)) {
				MessageBox.Show(@"В поле 'Сумма для внесения' должна быть сумма!");
				return;
			}
			var cashid = ((ComboBoxItem)cbCashList.SelectedItem).Id;
			if (txbObject.Tag == null) {
				// Add
				Db.Exec("insert into purchase (id, date, sum, cashid, istotop) values ('{0}','{1}','{2}','{3}', '1')",
					Guid.NewGuid().ToString(), DateTime.Now.ToString("yyyy-MM-dd"), sum, cashid);
			} else {
				// Edit
				Db.Exec("update purchase set sum = '{1}', cashid='{2}' where id='{0}'", txbObject.Tag, sum, cashid);
			}
			gbAddEdit.Visible = false;
			LoadDataAsync();
		}

		private void SelectComboBox(ComboBox cb, string selectItem) {
			foreach (ComboBoxItem item in cb.Items) {
				if (item.Name == selectItem) {
					cb.SelectedItem = item;
				}
			}
		}

	}



}
