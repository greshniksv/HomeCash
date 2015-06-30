using System;
using System.Windows.Forms;

namespace HomeCash
{
	public partial class FrmLoader : Form
	{
		public FrmLoader() {
			InitializeComponent();
		}

		private void Loader_Load(object sender, EventArgs e) {
			FormBorderStyle = FormBorderStyle.None;
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e) {
			using (var backup = new DBBackup()) {
				timer1.Enabled = false;
				bool isValidDatabse = Db.ValidateDatabase((text, progress) => {
					lblInfo.Text = text;
					progressBar.Value = progress;
					Application.DoEvents();
				});
				if (isValidDatabse) {
					backup.Create();
				} else {
					var messageResult = MessageBox.Show("База данных повреждена или отсутствует!\n" +
					                "Если это первый запуск программы на жмите 'Да' это создает новую базу данных.\n" +
					                "Если вы уже пользуетесь программой то во избижании потери данных," +
					                "сообщите системеому администратору о поломке и нажмите 'НЕТ'", @"Внимание!", MessageBoxButtons.YesNoCancel , MessageBoxIcon.Error);
					if (messageResult != DialogResult.Yes) {
						Application.Exit();
						return;
					}
				}
			}
			Db.Connect();
			var form = new FrmMain();
			Hide();
			form.ShowDialog();
			Application.Exit();
		}

	}
}
