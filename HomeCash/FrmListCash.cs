using System;
using System.Windows.Forms;

namespace HomeCash
{
	using System.Collections.Generic;
	using System.Collections.Specialized;
	using System.Threading.Tasks;

	public partial class FrmListCash : Form
	{
		public FrmListCash() {
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e) {
			Close();
		}

		private void FrmListCash_Load(object sender, EventArgs e) {
			LoadDataAsync();
		}

		private async void LoadDataAsync() {
			lvCash.Items.Clear();
			lvCash.Items.AddRange(await LoadCash());
		}

		private Task<ListViewItem[]> LoadCash() {
			return Task<ListViewItem[]>.Factory.StartNew(() => {
				var list = new List<ListViewItem>();
				DbReader reader;
				if ((reader = Db.Read("select id, name from cash order by name")) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						var id = buf["id"];
						var balance = Operation.GetBalance(id);
						var name = buf["name"];
						var item = new ListViewItem {
							Text = name,
							Tag = id
						};
						item.SubItems.Add(balance.ToString(".00"));
						list.Add(item);
					}
				}
				return list.ToArray();
			});
		}

		private void AddToolStripMenuItem_Click(object sender, EventArgs e) {
			gbAddEdit.Visible = true;
			txbObjectName.Tag = null;
			btnAddEdit.Text = @"Добавить";
			lblAddEditHeader.Text = @"Добавить счет";
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvCash.SelectedItems.Count > 0) {
				txbObjectName.Tag = lvCash.SelectedItems[0].Tag;
				txbObjectName.Text = lvCash.SelectedItems[0].Text;
				gbAddEdit.Visible = true;
				btnAddEdit.Text = @"Изменить";
				lblAddEditHeader.Text = @"Изменить счет";
			}
		}

		private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvCash.SelectedItems.Count > 0) {
				var name = lvCash.SelectedItems[0].Text;
				var sum = Double.Parse(lvCash.SelectedItems[0].SubItems[1].Text);
				var id = lvCash.SelectedItems[0].Tag;
				if (sum > 0) {
					MessageBox.Show(@"Счет содержит сумму, его нельзя удалить !", @"Внимание!",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				var result = MessageBox.Show(@"Вы действительно хотите удалить счет: " + name + " ?", @"Внимание!",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					Db.Exec("delete from cash where id='{0}'", id);
				}
				LoadDataAsync();
			}
		}

		private void btnAddEdit_Click(object sender, EventArgs e) {
			if (txbObjectName.Tag == null) {
				// Add
				Db.Exec("insert into cash (id, name) values ('{0}','{1}')", Guid.NewGuid().ToString(), txbObjectName.Text);
			} else {
				// Edit
				Db.Exec("update cash set name = '{1}' where id='{0}'", txbObjectName.Tag, txbObjectName.Text);
			}
			gbAddEdit.Visible = false;
			LoadDataAsync();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			gbAddEdit.Visible = false;
		}

	}
}
