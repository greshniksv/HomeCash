using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCash
{
	public partial class FrmConfig : Form
	{
		public FrmConfig() {
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e) {
			AppSettings.FullScreen = cbxFullScreen.Checked;

			Close();
		}

		private void FrmConfig_Load(object sender, EventArgs e) {
			cbxFullScreen.Checked = AppSettings.FullScreen;
		}
	}
}
