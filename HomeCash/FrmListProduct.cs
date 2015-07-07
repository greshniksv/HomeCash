using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCash
{
	using System.Collections.Specialized;

	public partial class FrmListProduct : Form
	{
		public FrmListProduct() {
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e) {
			Close();
		}

		private async void LoadDataAsync() {
			lvProduct.Items.Clear();
			lvProduct.Items.AddRange(await LoadProduct());
		}

		private Task<ListViewItem[]> LoadProduct() {
			return Task<ListViewItem[]>.Factory.StartNew(() => {
				var list = new List<ListViewItem>();
				DbReader reader;
				if ((reader = Db.Read("select id, name from product order by name")) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						var id = buf["id"];
						var name = buf["name"];
						var item = new ListViewItem {
							Text = name,
							Tag = id
						};
						list.Add(item);
					}
				}
				return list.ToArray();
			});
		}

		private void FrmListProduct_Load(object sender, EventArgs e) {
			LoadDataAsync();
		}

		private void AddToolStripMenuItem_Click(object sender, EventArgs e) {
			gbAddEditProduct.Visible = true;
			txbProductName.Tag = null;
			btnAddEdit.Text = @"Добавить";
			lblAddEditHeader.Text = @"Добавить продукт";
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvProduct.SelectedItems.Count > 0) {
				txbProductName.Tag = lvProduct.SelectedItems[0].Tag;
				txbProductName.Text = lvProduct.SelectedItems[0].Text;
				gbAddEditProduct.Visible = true;
				btnAddEdit.Text = @"Изменить";
				lblAddEditHeader.Text = @"Изменить продукт";
			}
		}

		private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvProduct.SelectedItems.Count > 0) {
				var productName = lvProduct.SelectedItems[0].Text;
				var productId = lvProduct.SelectedItems[0].Tag;
				var result = MessageBox.Show(@"Удалить", @"Вы действительно хотите удалить продукт: " + productName,
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					Db.Exec("delete from product where id='{0}'", productId);
				}
				LoadDataAsync();
			}
		}

		private void btnAddEdit_Click(object sender, EventArgs e) {
			if (txbProductName.Tag == null) {
				// Add
				Db.Exec("insert into product (id, name, namel) values ('{0}','{1}', '{2}')", Guid.NewGuid().ToString(), txbProductName.Text, txbProductName.Text.ToLower());
			} else {
				// Edit
				Db.Exec("update product set name = '{1}', namel='{2}' where id='{0}'", txbProductName.Tag, txbProductName.Text, txbProductName.Text.ToLower());
			}
			gbAddEditProduct.Visible = false;
			LoadDataAsync();
		}

	}
}
