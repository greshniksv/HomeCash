using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCash
{
	public partial class FrmMove : Form
	{
		public FrmMove()
		{
			InitializeComponent();
		}

		private void FrmMove_Load(object sender, EventArgs e)
		{
			LoadDataAsync();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Close();
		}

		private async void LoadDataAsync()
		{
			cbCashListFrom.Items.Clear();
			cbCashListTo.Items.Clear();
			lvMove.Items.Clear();
			cbCashListFrom.Items.AddRange(await LoadCash());
			cbCashListTo.Items.AddRange(await LoadCash());
			lvMove.Items.AddRange(await LoadMoveAsync());
		}

		private Task<FrmListTopUp.ComboBoxItem[]> LoadCash()
		{
			return Task<FrmListTopUp.ComboBoxItem[]>.Factory.StartNew(() =>
			{
				var list = new List<FrmListTopUp.ComboBoxItem>();
				DbReader reader;
				if ((reader = Db.Read("select id, name from cash order by name")) != null)
				{
					NameValueCollection buf;
					while ((buf = reader.Next()) != null)
					{
						var id = buf["id"];
						var name = buf["name"];
						var item = new FrmListTopUp.ComboBoxItem
						{
							Id = id,
							Name = name
						};
						list.Add(item);
					}
				}
				return list.ToArray();
			});
		}

		private Task<ListViewItem[]> LoadMoveAsync()
		{
			return Task<ListViewItem[]>.Factory.StartNew(() =>
			{
				var itemCollection = new List<ListViewItem>();
				string sql = "select p.id, p.date, p.sum, \n" +
					" (select c.name from cash c where c.id = p.cashid) as cashfrom, \n" +
					" (select (select c.name from cash c where c.id = p1.cashid) from purchase p1 where moveid=p.id) as cashto \n" +
					" from purchase p \n" +
					" where p.type=2 and moveid is null " +
					" order by date \n";
				DbReader reader;
				if ((reader = Db.Read(sql)) != null)
				{
					NameValueCollection buf;
					while ((buf = reader.Next()) != null)
					{
						string date = string.Empty;
						DateTime dateTime;
						if (DateTime.TryParse(buf["date"], out dateTime))
						{
							date = dateTime.ToString("dd-MM-yyyy");
						}
						var item = new ListViewItem
						{
							Tag = buf["id"],
							Text = date
						};
						item.SubItems.Add(buf["cashfrom"]);
						item.SubItems.Add(buf["cashto"]);
						item.SubItems.Add(buf["sum"].Replace("-",""));
						itemCollection.Add(item);
					}
				}
				return itemCollection.ToArray();
			});
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			gbAddEdit.Visible = false;
		}

		private void btnAddEdit_Click(object sender, EventArgs e) {
			double sum;
			string ssum = txbObject.Text.Replace(".", ",");
			if (!double.TryParse(ssum, out sum)) {
				MessageBox.Show(@"В поле 'Сумма для внесения' должно быть число!");
				return;
			}
			string summToDataFrom = (sum * -1).ToString("0.00").Replace(",", ".");
			string summToDataTo = (sum).ToString("0.00").Replace(",", ".");
			var cashidFrom = ((FrmListTopUp.ComboBoxItem)cbCashListFrom.SelectedItem).Id;
			var cashidTo = ((FrmListTopUp.ComboBoxItem)cbCashListTo.SelectedItem).Id;

			if (txbObject.Tag == null) {
				// Add
				string moveid = Guid.NewGuid().ToString();
				Db.Exec("insert into purchase (id, date, sum, cashid, type, number) values " +
						"('{0}','{1}','{2}','{3}', 2, (SELECT coalesce(max(p2.number),0)+1 FROM purchase p2 where p2.type=2))",
					moveid, DateTime.Now.ToString("yyyy-MM-dd"), summToDataFrom, cashidFrom);

				Db.Exec("insert into purchase (id, moveid, date, sum, cashid, type, number) values " +
						"('{0}','{1}','{2}','{3}','{4}', 2, (SELECT coalesce(max(p2.number),0)+1 FROM purchase p2 where p2.type=2))",
					Guid.NewGuid(), moveid, DateTime.Now.ToString("yyyy-MM-dd"), summToDataTo, cashidTo);

			} else {
				// Edit
				Db.Exec("update purchase set sum = '{1}', cashid='{2}' where id='{0}'", txbObject.Tag, summToDataFrom, cashidFrom);
				Db.Exec("update purchase set sum = '{1}', cashid='{2}' where moveid = '{0}'", txbObject.Tag, summToDataTo, cashidTo);
			}

			gbAddEdit.Visible = false;
			LoadDataAsync();
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e) {
			gbAddEdit.Visible = true;
			txbObject.Tag = null;
			btnAddEdit.Text = @"Добавить";
			lblAddEditHeader.Text = @"Добавить перемещение";
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvMove.SelectedItems.Count > 0) {
				txbObject.Tag = lvMove.SelectedItems[0].Tag;
				txbObject.Text = lvMove.SelectedItems[0].SubItems[3].Text;
				SelectComboBox(cbCashListFrom, lvMove.SelectedItems[0].SubItems[1].Text);
				SelectComboBox(cbCashListTo, lvMove.SelectedItems[0].SubItems[2].Text);
				gbAddEdit.Visible = true;
				btnAddEdit.Text = @"Изменить";
				lblAddEditHeader.Text = @"Изменить перемещение";
			}
		}

		private void removeToolStripMenuItem1_Click(object sender, EventArgs e) {
			if (lvMove.SelectedItems.Count > 0) {
				var data = lvMove.SelectedItems[0].Text;
				var cashFrom = lvMove.SelectedItems[0].SubItems[1].Text;
				var cashTo = lvMove.SelectedItems[0].SubItems[2].Text;
				var summ = lvMove.SelectedItems[0].SubItems[3].Text;
				var id = lvMove.SelectedItems[0].Tag;
				var result = MessageBox.Show(@"Вы действительно хотите удалить перемещение со счета " + cashFrom + @" на  счет "+cashTo+" ?", @"Внимание!",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					Db.Exec("delete from purchase where id='{0}'", id);
					Db.Exec("delete from purchase where moveid='{0}'", id);
				}
				LoadDataAsync();
			}
		}

		private void SelectComboBox(ComboBox cb, string selectItem) {
			foreach (object item in cb.Items) {
				if (item.ToString() == selectItem) {
					cb.SelectedItem = item;
				}
			}
		}

	}
}
