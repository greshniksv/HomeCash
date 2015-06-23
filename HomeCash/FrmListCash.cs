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
			LoadData();
		}

		private async void LoadData() {
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
							Text = id
						};
						item.SubItems.Add(name);
						item.SubItems.Add(balance.ToString(".00"));
						list.Add(item);
					}
				}
				return list.ToArray();
			});
		}

		private void AddToolStripMenuItem_Click(object sender, EventArgs e) {
			var cash = new FrmAddUpdateCash();
			cash.ShowDialog();
			LoadData();
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvCash.SelectedItems.Count > 0) {
				var cash = new FrmAddUpdateCash(lvCash.SelectedItems[0].Text);
				cash.ShowDialog();
				LoadData();
			}
		}

		private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvCash.SelectedItems.Count > 0) {
				var name = lvCash.SelectedItems[0].SubItems[1].Text;
				var id = lvCash.SelectedItems[0].text;
				var result = MessageBox.Show(@"Внимание!", @"Вы действительно хотите удалить счет: " + name + " ?",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					Db.Exec("delete from cash where id='{0}'", id);
				}
				LoadData();
			}
		}

	}
}
