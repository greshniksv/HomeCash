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
	using System.Diagnostics;
	using System.Linq;

	public partial class FrmMain : Form
	{
		private bool _loading = false;
		private bool _loadingPurchase = false;
		private object _lock = new object();
		private readonly Dictionary<string, string> _productDict = new Dictionary<string, string>();

		public FrmMain() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e) {
			dtpEnd.Value = DateTime.Now.AddDays(1);
			LoadDataAsync();
		}

		private async void LoadPurchase() {
			if(_loadingPurchase)
				return;
			_loadingPurchase = true;
			var cashId=string.Empty;
			if (cbCashFilter.Items.Count > 0 && cbCashFilter.SelectedItem.ToString() != "Все") {
				cashId = ((ComboBoxItem)cbCashFilter.SelectedItem).Id;
			}
			lvPurchase.Items.Clear();
			lvPurchase.Items.AddRange(await LoadPurcaseAsync(cashId));
			CalculateSumm();
			_loadingPurchase = false;
		}

		private async void LoadDataAsync() {
			if (_loading)
				return;
			_loading = true;
			LoadPurchase();
			cbCash.Items.Clear();
			scbProduct.Items.Clear();
			cbCashFilter.Items.Clear();
			PlaceCashOnPanel(await LoadHeadCashAsync());
			cbCash.Items.AddRange(await LoadCashAsync());
			cbCashFilter.Items.AddRange(LoadCash());
			cbCashFilter.Items.Add("Все");
			cbCashFilter.SelectedItem = cbCashFilter.Items[cbCashFilter.Items.Count - 1];
			scbProduct.Items.AddRange(await LoadProductAsync());
			
			_loading = false;
		}

		private void CalculateSumm() {
			double sum = lvPurchase.Items.Cast<ListViewItem>().Sum(item => double.Parse(item.SubItems[5].Text.Replace(".", ",")));
			toolStripStatusSum.Text = @"Сумма: " + sum.ToString("0.00");
		}

		private Task<ListViewItem[]> LoadPurcaseAsync(string cashId = "") {
			return Task<ListViewItem[]>.Factory.StartNew(() => {
				string start = dtpStart.Value.ToString("yyyy-MM-dd");
				string end = dtpEnd.Value.ToString("yyyy-MM-dd");
				var itemCollection = new List<ListViewItem>();
				string productFilter = txbProductFilter.Text;
				string sql = string.Format("select p.id, p.number, \n" +
					"(select c.name from cash c where c.id = p.cashid) as cash, \n" +
					"(select pr.name from product pr where pr.id = p.productid) as product, \n" +
					"p.volume, p.date, p.sum \n" +
					" from purchase p \n" +
					" where p.date >= '{0}' and p.date <= '{1}' \n" +
					" and type = 0 " +
					(!string.IsNullOrEmpty(cashId) ? " and p.cashid = '{2}'" : string.Empty) +
					(!string.IsNullOrEmpty(productFilter) ?
					" and p.productid = (select pr1.id from product pr1 where LOWER(pr1.name) like LOWER('%{3}%') ) " : string.Empty) +
					" order by date \n", start, end, cashId, productFilter);
				Debug.WriteLine("Select purchase: {0}", sql);
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
						item.SubItems.Add(float.Parse(buf["sum"].Replace("-", "").Replace(".",",")).ToString("0.00"));
						itemCollection.Add(item);
					}
				}
				return itemCollection.ToArray();
			});
		}

		private Task<Dictionary<string, string>> LoadHeadCashAsync() {
			return Task<Dictionary<string, string>>.Factory.StartNew(() => {
				var dictionary = new Dictionary<string, string>();

				DbReader reader;
				if ((reader = Db.Read("select id, name from cash order by name")) != null) {
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						var id = buf["id"];
						var balance = Operation.GetBalance(id);
						var name = buf["name"];
						dictionary.Add(name, balance.ToString("0.00"));
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

		private ComboBoxItem[] LoadCash() {
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
		}

		private string GetProductId(string name)
		{
			string key;
			lock (_lock)
			{
				if (!_productDict.ContainsValue(name.ToLower())) {
					// Need add product
					Guid newId = Guid.NewGuid();
					Db.Exec("insert into product (id, name) values ('{0}','{1}')", newId, name);
					_productDict.Add(newId.ToString(), name);
					return newId.ToString();
				}
				key = _productDict.First(x => x.Value == name.ToLower()).Key;
			}
			return key;
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

		private void PlaceCashOnPanel(Dictionary<string, string> dictionary) {
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
					Font = new Font(new FontFamily("Courier New"), 11, FontStyle.Bold)
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

		private void dtpStart_ValueChanged(object sender, EventArgs e) {
			LoadDataAsync();
		}

		private void dtpEnd_ValueChanged(object sender, EventArgs e) {
			LoadDataAsync();
		}

		private void btnAddEdit_Click(object sender, EventArgs e) {
			double sum;
			string ssum = txbSum.Text.Replace(".", ",");
			if (!double.TryParse(ssum, out sum)) {
				MessageBox.Show(@"В поле 'Сумма для внесения' должна быть сумма!");
				return;
			}
			string summToData = (sum * -1).ToString("0.00").Replace(",", ".");
			var cashid = ((ComboBoxItem)cbCash.SelectedItem).Id;
			var productName = (string)scbProduct.SelectedItem ?? scbProduct.Text;
			if (productName == string.Empty)
			{
				MessageBox.Show(@"Необходимо указать товар!", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			var productid = GetProductId(productName);
			if (scbProduct.Tag == null) {
				// Add
				Db.Exec("insert into purchase (id, date, sum, cashid, productid, volume,  type, number) values " +
						"('{0}','{1}','{2}','{3}','{4}','{5}', 0, (SELECT coalesce(max(number),0)+1 FROM purchase))",
					Guid.NewGuid(), dtpDate.Value.ToString("yyyy-MM-dd"), summToData, cashid, productid, txbVolume.Text);
			} else {
				// Edit
				Db.Exec("update purchase set date = '{1}', sum='{2}', cashid='{3}', productid='{4}', volume='{5}' where id='{0}'",
					scbProduct.Tag, dtpDate.Value.ToString("yyyy-MM-dd"), summToData, cashid, productid, txbVolume.Text);
			}
			if (cbOneMore.Checked) {
				AddOneMore();
			} else {
				gbPurchase.Visible = false;
				LoadDataAsync();
			}
		}

		private void AddOneMore() {
			scbProduct.Text = string.Empty;
			lsbProduct.Visible = false;
			txbVolume.Text = string.Empty;
			txbSum.Text = string.Empty;
			scbProduct.Focus();
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
			scbProduct.Focus();
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lvPurchase.SelectedItems.Count > 0) {
				scbProduct.Tag = lvPurchase.SelectedItems[0].Tag;
				dtpDate.Value = DateTime.Parse(lvPurchase.SelectedItems[0].SubItems[1].Text);
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
			LoadDataAsync();
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

		private void moveToolStripMenuItem_Click(object sender, EventArgs e) {
			var move = new FrmMove();
			move.ShowDialog();
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

		private void scbProduct_SelectionChangeCommitted(object sender, EventArgs e) {
			lsbProduct.Visible = false;
		}

		private void scbProduct_Leave(object sender, EventArgs e) {
			//lsbProduct.Visible = false;
		}

		private void txbSum_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				btnAddEdit_Click(null, null);
			}
		}

		private void lsbProduct_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				lsbProduct.Visible = false;
				scbProduct.Focus();
			}
		}

		private void tsbAddPurchase_Click(object sender, EventArgs e) {
			AddToolStripMenuItem_Click(null, null);
		}

		private void tsbCash_Click(object sender, EventArgs e) {
			CashToolStripMenuItem1_Click(null, null);
		}

		private void tsbProduct_Click(object sender, EventArgs e) {
			ProductToolStripMenuItem_Click(null, null);
		}

		private void tsbTopUp_Click(object sender, EventArgs e) {
			topupMenuToolStripMenuItem_Click(null, null);
		}

		private void movetoolStripButton1_Click(object sender, EventArgs e) {
			moveToolStripMenuItem_Click(null, null);
		}

		private void cbCashFilter_SelectedIndexChanged(object sender, EventArgs e) {
			LoadPurchase();
		}

		private void txbProductFilter_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				LoadPurchase();
			}
			if (string.IsNullOrEmpty(txbProductFilter.Text)) {
				LoadPurchase();
			}
		}



	}
}
