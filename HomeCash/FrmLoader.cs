using System;
using System.Windows.Forms;

namespace HomeCash
{
	public partial class FrmLoader : Form
	{
		public FrmLoader()
		{
			InitializeComponent();
		}

		private void Loader_Load(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.None;
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Hide();
			Db.Connect();
			FrmMain form = new FrmMain();
			form.ShowDialog();
			Application.Exit();
		}

	}
}
