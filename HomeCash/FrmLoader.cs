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
					CheckDbStructureOnExistTypeAndMoveid();
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

		private void CheckDbStructureOnExistTypeAndMoveid() {
			string sqlAddTypeAndMoveid = 
				" BEGIN TRANSACTION; "+
				" ALTER TABLE purchase ADD COLUMN type int; "+
				" ALTER TABLE purchase ADD COLUMN moveid varchar(36); "+
				" update purchase set type=(select  CASE WHEN istotop THEN 1 ELSE 0 END from purchase p2 where p2.id = purchase.id); "+
				" CREATE TEMPORARY TABLE purchase_backup(id,moveid,number,cashid,productid,volume,date,sum,type); "+
				" INSERT INTO purchase_backup SELECT id,moveid,number,cashid,productid,volume,date,sum,type FROM purchase; "+
				" DROP TABLE purchase; "+
				" CREATE TABLE purchase(id,moveid,number,cashid,productid,volume,date,sum,type); "+
				" INSERT INTO purchase SELECT id,moveid,number,cashid,productid,volume,date,sum,type FROM purchase_backup; " +
				" DROP TABLE purchase_backup;"+
				" COMMIT;";
			Db.Connect();
			try {
				Db.ReadOne("select moveid from purchase");
			} catch {
				var messageResult = MessageBox.Show(@"Структура база данных устарела, обновить ?", @"Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
				if (messageResult == DialogResult.Yes) {
					Db.Exec(sqlAddTypeAndMoveid);
					MessageBox.Show(@"Структуру базы данных обновлена!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			Db.Disconnect();
		}

	}
}
