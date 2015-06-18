using System;
using System.Globalization;
using System.Windows.Forms;

namespace HomeCash
{
	public partial class FrmAddUpdateCash : Form
	{
		private readonly string _id;

		public FrmAddUpdateCash(string id = null)
		{
			_id = id;
			InitializeComponent();
		}

		private void FrmAddUpdateCash_Load(object sender, System.EventArgs e)
		{
			if (!string.IsNullOrEmpty(_id))
			{
				btnAccept.Text = @"Изменить";
				lblCashName.Text = Db.ReadNameById("cash", _id);
				lblBalance.Text = Operation.GetBalance(_id).ToString(CultureInfo.InvariantCulture);
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnAccept_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(_id))
			{
				// Add
				Db.Exec("insert into cash (id, name) values ('{0}','{1}')", Guid.NewGuid(), lblCashName.Text);
			}
			else
			{
				// Update
				Db.Exec("update cash set name='{1}' where id='{0}'", _id, lblCashName.Text);
			}
			Close();
		}

	}
}
