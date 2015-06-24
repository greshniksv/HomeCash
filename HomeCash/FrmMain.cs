using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBoxItem = HomeCash.FrmListTopUp.ComboBoxItem;
namespace HomeCash
{
	using System.Data.SQLite;
	using System.Linq;

	public partial class FrmMain : Form
	{
		private bool _loading = false;
		private object _lock = new object();
		private readonly Dictionary<string, string> _productDict = new Dictionary<string, string>();

		public FrmMain() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e) {
			dtpEnd.Value = DateTime.Now.AddDays(1);
			LoadDataAsync();
		}

		private async void LoadDataAsync() {
			if (_loading)
				return;
			_loading = true;

			lvPurchase.Items.Clear();
			cbCash.Items.Clear();
			scbProduct.Items.Clear();
			lvPurchase.Items.AddRange(await LoadPurcaseAsync());
			PlaceCashOnPanel(await LoadHeadCashAsync());
			cbCash.Items.AddRange(await LoadCashAsync());
			scbProduct.Items.AddRange(await LoadProductAsync());

			_loading = false;
		}

		private Task<ListViewItem[]> LoadPurcaseAsync() {
			return Task<ListViewItem[]>.Factory.StartNew(() => {
				string start = dtpStart.Value.ToString("yyyy-MM-dd");
				string end = dtpEnd.Value.ToString("yyyy-MM-dd");
				var itemCollection = new List<ListViewItem>();
				string sql = string.Format("select p.id, p.number, \n" +
					"(select c.name from cash c where c.id = p.cashid) as cash, \n" +
					"(select pr.name from product pr where pr.id = p.productid) as product, \n" +
					"p.volume, p.date, p.sum \n" +
					" from purchase p \n" +
					" where p.date >= '{0}' and p.date <= '{1}' \n" +
					" and istotop = '0' " +
					" order by date \n", start, end);
				DbReader reader;
				if ((reader = Db.Read(sql)) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						string date = string.Empty;
						DateTime dateTime;
						if (DateTime.TryParse(buf["date"], out dateTime)) {
							date = dateTime.ToString("dd-MM-yyyy");
						}
						var item = new ListViewItem();
						item.Tag = buf["id"];
						item.Text = buf["number"];
						item.SubItems.Add(date);
						item.SubItems.Add(buf["cash"]);
						item.SubItems.Add(buf["product"]);
						item.SubItems.Add(buf["volume"]);
						item.SubItems.Add(buf["sum"].Replace("-",""));
						itemCollection.Add(item);
					}
				}
				return itemCollection.ToArray();
			});
		}

		private Task<Dictionary<string, double>> LoadHeadCashAsync() {
			return Task<Dictionary<string, double>>.Factory.StartNew(() => {
				var dictionary = new Dictionary<string, double>();

				DbReader reader;
				if ((reader = Db.Read("select id, name from cash order by name")) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						var id = buf["id"];
						var balance = Operation.GetBalance(id);
						var name = buf["name"];
						dictionary.Add(name, balance);
					}
				}
				return dictionary;
			});
		}

		private Task<ComboBoxItem[]> LoadCashAsync() {
			return Task<ComboBoxItem[]>.Factory.StartNew(() => {
				var list = new List<ComboBoxItem>();
				DbReader reader;
				if ((reader = Db.Read("select id, name from cash order by name")) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						var id = buf["id"];
						var name = buf["name"];
						var item = new ComboBoxItem {
							Name = name,
							Id = id
						};
						list.Add(item);
					}
				}
				return list.ToArray();
			});
		}

		private string GetProductId(string name) {
			if (!_productDict.ContainsValue(name.ToLower())) {
				// Need add product
				Guid newId = Guid.NewGuid();
				Db.Exec("insert into product (id, name) values ('{0}','{1}')", newId, name);
				_productDict.Add(newId.ToString(), name);
				return newId.ToString();
			}
			return _productDict.First(x => x.Value == name.ToLower()).Key;
		}

		private Task<string[]> LoadProductAsync() {
			return Task<string[]>.Factory.StartNew(() => {
				var list = new List<string>();
				DbReader reader;
				if ((reader = Db.Read("select id, name from product order by name")) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						var id = buf["id"];
						var name = buf["name"];
						list.Add(name);
						lock (_lock) {
							if (!_productDict.ContainsKey(id)) {
								_productDict.Add(id, name.ToLower());
							}
						}
					}
				}
				return list.ToArray();
			});
		}

		private void PlaceCashOnPanel(Dictionary<string, double> dictionary) {
			gbCashPanel.Controls.Clear();
			int location = 0;
			foreach (var item in dictionary) {
				var arialBold = new Font("Microsoft Sans Serif", 12.0F);
				Size textSize = TextRenderer.MeasureText(item.Key, arialBold);
				int blockSize = textSize.Width + 10;
				var label = new Label {
					Text = item.Value.ToString(CultureInfo.InvariantCulture),
					Size = new Size(blockSize - 10, 16),
					Location = new Point(8, 24),
					Font = new Font(new FontFamily("Microsoft Sans Serif"), 11, FontStyle.Bold)
				};
				var box = new GroupBox {
					Size = new Size(blockSize, 55),
					Location = new Point(8 + location, 22),
					Text = item.Key
				};
				box.Controls.Add(label);
				gbCashPanel.Controls.Add(box);
				location += blockSize + 8;
			}

		}

		private void CreateCash() {

		}

		private void cashToolStripMenuItem_Click(object sender, EventArgs e) {
			CreateCash();
		}

		private void dtpStart_ValueChanged(object sender, EventArgs e) {
			LoadDataAsync();
		}

		private void dtpEnd_ValueChanged(object sender, EventArgs e) {
			LoadDataAsync();
		}

		private void btnAddEdit_Click(object sender, EventArgs e) {
			double sum;
			if (!double.TryParse(txbSum.Text, out sum)) {
				MessageBox.Show(@"В поле 'Сумма для внесения' должна быть сумма!");
				return;
			}
			var cashid = ((ComboBoxItem)cbCash.SelectedItem).Id;
			var productName = (string)scbProduct.SelectedItem ?? scbProduct.Text;
			var productid = GetProductId(productName);
			if (scbProduct.Tag == null) {
				// Add
				Db.Exec("insert into purchase (id, date, sum, cashid, productid, volume,  istotop, number) values " +
						"('{0}','{1}','{2}','{3}','{4}','{5}', '0', (SELECT max(number) FROM purchase))",
					Guid.NewGuid(), DateTime.Now.ToString("yyyy-MM-dd"), sum * -1, cashid, productid, txbVolume.Text);
			} else {
				// Edit
				Db.Exec("update purchase set date = '{1}', sum='{2}', cashid='{3}', productid='{4}', volume='{5}' where id='{0}'",
					scbProduct.Tag, DateTime.Now.ToString("yyyy-MM-dd"), sum * -1, cashid, productid, txbVolume.Text);
			}
			gbPurchase.Visible = false;
			LoadDataAsync();
		}

		private void AddToolStripMenuItem_Click(object sender, EventArgs e) {
			gbPurchase.Visible = true;
			scbProduct.Tag = null;
			txbVolume.Text = "";
			txbSum.Text = "0";
			scbProduct.Text = "";
			btnAddEdit.Text = @"Добавить";
			lblAddEdit.Text = @"Добавить покупку";
			scbProduct.SelectedText = "";
			cbCash.SelectedIndex = 0;
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvPurchase.SelectedItems.Count > 0) {
				scbProduct.Tag = lvPurchase.SelectedItems[0].Tag;
				scbProduct.Text = lvPurchase.SelectedItems[0].SubItems[3].Text;
				txbVolume.Text = lvPurchase.SelectedItems[0].SubItems[4].Text;
				txbSum.Text = lvPurchase.SelectedItems[0].SubItems[5].Text.Replace("-", "");
				SelectComboBox(cbCash, lvPurchase.SelectedItems[0].SubItems[2].Text);
				gbPurchase.Visible = true;
				btnAddEdit.Text = @"Изменить";
				lblAddEdit.Text = @"Изменить покупку";
			}
		}

		private void RemoveToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvPurchase.SelectedItems.Count > 0) {
				var id = lvPurchase.SelectedItems[0].Tag;
				var number = lvPurchase.SelectedItems[0].Text;
				var result = MessageBox.Show(
					string.Format(@"Вы действительно хотите удалить покупку под номером {0} ?", number),
					@"Внимание!",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					Db.Exec("delete from purchase where id='{0}'", id);
				}
				LoadDataAsync();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			gbPurchase.Visible = false;
		}

		private void CashToolStripMenuItem1_Click(object sender, EventArgs e) {
			var cash = new FrmListCash();
			cash.ShowDialog();
			LoadDataAsync();
		}

		private void ProductToolStripMenuItem_Click(object sender, EventArgs e) {
			var product = new FrmListProduct();
			product.ShowDialog();
			LoadDataAsync();
		}

		private void topupMenuToolStripMenuItem_Click(object sender, EventArgs e) {
			var topup = new FrmListTopUp();
			topup.ShowDialog();
			LoadDataAsync();
		}

		private void SelectComboBox(ComboBox cb, string selectItem) {
			foreach (object item in cb.Items) {
				if (item.ToString() == selectItem) {
					cb.SelectedItem = item;
				}
			}
		}

		private void lsbProduct_Click(object sender, EventArgs e) {
			SelectComboBox(scbProduct, (string)lsbProduct.SelectedItem);
			lsbProduct.Visible = false;
		}

		private void scbProduct_SelectedIndexChanged(object sender, EventArgs e) {
			lsbProduct.Visible = false;
		}

		private void scbProduct_KeyDown(object sender, KeyEventArgs e) {
			lsbProduct.Visible = true;
			string data = scbProduct.Text;
			lsbProduct.Items.Clear();
			foreach (string item in scbProduct.Items) {
				if (item.ToLower().Contains(data.ToLower())) {
					lsbProduct.Items.Add(item);
				}
			}
		}

	}
}
