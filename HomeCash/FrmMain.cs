using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCash
{
	public partial class FrmMain : Form
	{

		public FrmMain()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			dtpEnd.Value = DateTime.Now.AddDays(1);
			LoadData();
		}

		private async void LoadData()
		{
			lstPurchase.Items.AddRange(await LoadPurcaseAsync());
			PlaceCashOnPanel(await LoadCashAsync());
		}

		private Task<ListViewItem[]> LoadPurcaseAsync()
		{
			return Task<ListViewItem[]>.Factory.StartNew(() =>
			{
				string start = dtpStart.Value.ToString("yyyy-MM-dd");
				string end = dtpEnd.Value.ToString("yyyy-MM-dd");
				List<ListViewItem> itemCollection = new List<ListViewItem>();
				string sql = string.Format("select p.id, p.number, \n" +
					"(select c.name from cash c where c.id = p.cashid) as cash, \n" +
					"(select pr.name from product pr where pr.id = p.productid) as product, \n" +
					"p.volume, p.date, p.sum \n" +
					" from purchase p \n" +
					" where p.date >= '{0}' and p.date <= '{1}' \n" +
					" order by date \n",start,end );
				if (Db.Read(sql))
				{
					NameValueCollection buf;
					while ((buf = Db.ReadNext()) != null)
					{
						string date=string.Empty;
						DateTime dateTime;
						if (DateTime.TryParse(buf["date"], out dateTime))
						{
							date = dateTime.ToString("dd-MM-yyyy");
						}
						ListViewItem item = new ListViewItem();
						item.Text = buf["id"];
						item.SubItems.Add(buf["number"]);
						item.SubItems.Add(date);
						item.SubItems.Add(buf["cash"]);
						item.SubItems.Add(buf["product"]);
						item.SubItems.Add(buf["volume"]);
						item.SubItems.Add(buf["sum"]);
						itemCollection.Add(item);
					}
				}
				return itemCollection.ToArray();
			});
		}

		private Task<Dictionary<string, double>> LoadCashAsync()
		{
			return Task<Dictionary<string, double>>.Factory.StartNew(() =>
			{
				Dictionary<string, double> dictionary = new Dictionary<string, double>();

				if (Db.Read("select id, name from cash order by name"))
				{
					NameValueCollection buf;
					while ((buf = Db.ReadNext()) != null)
					{
						var id = buf["id"];
						var balance = Operation.GetBalance(id);
						var name = buf["name"];
						dictionary.Add(name,balance);
					}
				}
				return dictionary;
			});
		}

		private void PlaceCashOnPanel(Dictionary<string, double> dictionary)
		{
			gbCashPanel.Controls.Clear();
			int location=0;
			foreach (var item in dictionary)
			{
				Font arialBold = new Font("Microsoft Sans Serif", 11.0F);
				Size textSize = TextRenderer.MeasureText(item.Key, arialBold);
				int blockSize = textSize.Width+10;
				Label label = new Label
				{
					Text = item.Value.ToString(CultureInfo.InvariantCulture),
					Size = new Size(blockSize - 10, 16),
					Location = new Point(8, 24),
					Font = new Font(new FontFamily("Microsoft Sans Serif"), 11, FontStyle.Bold)
				};
				GroupBox box = new GroupBox
				{
					Size = new Size(blockSize, 55),
					Location = new Point(8 + location, 22),
					Text = item.Key
				};
				box.Controls.Add(label);
				gbCashPanel.Controls.Add(box);
				location += blockSize+8;
			}

		}


		private void CreateCash()
		{
			FrmAddUpdateCash cash = new FrmAddUpdateCash();
			cash.ShowDialog();
			LoadData();
		}

		private void cashToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CreateCash();
		}

		private void dtpStart_ValueChanged(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dtpEnd_ValueChanged(object sender, EventArgs e)
		{
			LoadData();
		}


	}
}
