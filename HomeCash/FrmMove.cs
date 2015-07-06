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
					" (select (select c.name from cash c where c.id = p1.cashid) from purchase p1 where moveid=p.id), \n" +
					" as cashto \n" +
					" from purchase p \n" +
					" where p.type=2 " +
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
						item.SubItems.Add(buf["sum"]);
						itemCollection.Add(item);
					}
				}
				return itemCollection.ToArray();
			});
		}



	}
}
