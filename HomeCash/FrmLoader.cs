using System;
using System.Windows.Forms;

namespace HomeCash
{
	using System.Collections.Specialized;
	using System.IO;
	using HomeCash.Properties;

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
					var messageResult = MessageBox.Show(Resources.FailCheckDatabase, @"Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
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
			string dbbak = Db.DatabaseFile + ".bak";
			if (File.Exists(dbbak)) {
				File.Move(dbbak, dbbak+"_"+Guid.NewGuid());
			}
			File.Copy(Db.DatabaseFile, dbbak);
			const string sqlAddTypeAndMoveid =
				" BEGIN TRANSACTION; " +
				" ALTER TABLE purchase ADD COLUMN type int; " +
				" ALTER TABLE purchase ADD COLUMN moveid varchar(36); " +
				" ALTER TABLE cash ADD COLUMN namel varchar(50); " +
				" ALTER TABLE product ADD COLUMN namel varchar(50); " +
				" update purchase set type=(select  CASE WHEN istotop THEN 1 ELSE 0 END from purchase p2 where p2.id = purchase.id); " +
				" CREATE TEMPORARY TABLE purchase_backup(id,moveid,number,cashid,productid,volume,date,sum,type); " +
				" INSERT INTO purchase_backup SELECT id,moveid,number,cashid,productid,volume,date,sum,type FROM purchase; " +
				" DROP TABLE purchase; " +
				" CREATE TABLE purchase (id varchar(36), moveid varchar(36), number int, cashid varchar(36), productid varchar(36), volume varchar(10), date datetime, sum DECIMAL(10,2), type int);" +
				" INSERT INTO purchase SELECT id,moveid,number,cashid,productid,volume,date,sum,type FROM purchase_backup; " +
				" DROP TABLE purchase_backup;" +
				" COMMIT;";
			Db.Connect();
			try {
				Db.ReadOne("select moveid from purchase");
			} catch {
				var messageResult = MessageBox.Show(@"Структура база данных устарела, обновить ?", @"Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
				if (messageResult == DialogResult.Yes) {
					Db.Exec(sqlAddTypeAndMoveid);

					var reader = Db.Read("select id, name from cash order by name");
					NameValueCollection buf;
					while ((buf = reader.Next()) != null) {
						Db.Exec("update cash set namel = '{1}' where id='{0}'", buf["id"], buf["name"].ToLower());
					}

					reader = Db.Read("select id, name from product order by name");
					while ((buf = reader.Next()) != null) {
						Db.Exec("update product set namel = '{1}' where id='{0}'", buf["id"], buf["name"].ToLower());
					}

					MessageBox.Show(@"Структура базы данных обновлена!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			Db.CreateIndexOfNotExist();
			Db.Disconnect();
		}

	}
}
