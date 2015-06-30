namespace HomeCash
{
	using System;
	using System.IO;

	public class DBBackup : IDisposable
	{
		private const string BackupFolder = @".\Backup";
		private string _newBackupFile;
		private bool _firstRun = false;

		public DBBackup() {
			if (!Directory.Exists(BackupFolder)) {
				Directory.CreateDirectory(BackupFolder);
			}
			var backupFiles = Directory.GetFiles(BackupFolder, "*.dbbak");
			if (backupFiles.Length > 20) {
				File.Delete(backupFiles[0]);
			}
			PrepeareDatabase();
		}

		private void PrepeareDatabase() {
			if (!File.Exists(Db.DatabaseFile)) {
				_firstRun = true;
				return;
			}
			_newBackupFile = BackupFolder + @"\" + DateTime.Now.ToString("yyyy.MM.dd");
			File.Copy(Db.DatabaseFile, _newBackupFile);
		}

		public void Create() {
			if (_firstRun) {
				return;
			}
			if (_newBackupFile == null) {
				throw new Exception("You can't create backup twice from one DBBackup instance!");
			}
			File.Move(_newBackupFile, _newBackupFile+".dbbak");
			_newBackupFile = null;
		}

		public void Dispose() {
			if (_newBackupFile != null)
			{
				File.Delete(_newBackupFile);
			}
		}
	}
}
