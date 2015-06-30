using System.Collections.Specialized;
using System.Data.SQLite;

namespace HomeCash
{
	using System;
	using System.IO;
	using System.Text;


	public static class Db
	{
		private static SQLiteConnection _connection;
		private static SQLiteCommand _command;
		private const string Database = @".\homecashe.db";

		public static string DatabaseFile {
			get {
				return Database;
			}
		}

		private static SQLiteCommand CreateCommandConnection() {
			//var connection = new SQLiteConnection(@"Data Source=.\homecashe.db;Version=3;");
			//connection.Open();
			return _connection.CreateCommand();
		}

		private static bool CheckTable(string table, SQLiteCommand command) {
			try {
				command.CommandText = "select * from " + table;
				var reader = command.ExecuteReader();
				while (reader.Read()) { }
				reader.Close();
			} catch (Exception) {
				return false;
			}
			return true;
		}

		public static bool ValidateDatabase(Action<string, int> eventing=null) {
			SQLiteConnection connection;
			if (!File.Exists(Database)) {
				return false;
			}
			try {
				connection = new SQLiteConnection(@"Data Source=.\homecashe.db;Version=3;");
				connection.Open();
			} catch (Exception) {
				return false;
			}
			var command = connection.CreateCommand();
			var tables = new[] { "purchase", "cash", "product" };
			int count = 0;
			foreach (var table in tables) {
				count++;
				if (eventing != null) {
					eventing(@"Check table" + table, (count * 100 / tables.Length));
				}
				if (!CheckTable(table, command)) {
					return false;
				}
			}
			return true;
		}

		public static void Connect() {
			bool generateDatabase = !File.Exists(Database);
			_connection = new SQLiteConnection(@"Data Source=.\homecashe.db;Version=3;");
			_connection.Open();
			_command = _connection.CreateCommand();
			if (generateDatabase) {
				GenerateDatabase();
			}
		}

		private static void GenerateDatabase() {
			var builder = new StringBuilder();
			builder.Append("create table purchase " +
						   "(id varchar(36), number int, cashid varchar(36), productid varchar(36), volume varchar(10), " +
						   "date datetime, sum DECIMAL(10,2), istotop BOOLEAN);");
			builder.Append("create table cash (id varchar(36), name varchar(50));");
			builder.Append("create table product (id varchar(36), name varchar(50));");
			Exec(builder.ToString());
		}

		public static void Exec(string sql, params object[] parameter) {
			if (parameter != null) {
				sql = string.Format(sql, parameter);
			}
			_command.CommandText = sql;
			_command.ExecuteNonQuery();
		}

		public static NameValueCollection ReadOne(string sql, params object[] parameter) {
			if (parameter != null) {
				sql = string.Format(sql, parameter);
			}
			_command.CommandText = sql;
			using (var reader = _command.ExecuteReader()) {
				return reader.GetValues();
			}
		}

		public static NameValueCollection ReadOneById(string table, string id) {
			_command.CommandText = string.Format("select * from {0} where id = '{1}'", table, id);
			using (var reader = _command.ExecuteReader()) {
				return reader.GetValues();
			}
		}

		public static string ReadNameById(string table, string id) {
			_command.CommandText = string.Format("select name from {0} where id = '{1}'", table, id);
			using (var reader = _command.ExecuteReader()) {
				return reader["name"].ToString();
			}
		}

		public static DbReader Read(string sql, params object[] parameter) {
			var command = CreateCommandConnection();
			if (parameter != null) {
				sql = string.Format(sql, parameter);
			}
			command.CommandText = sql;
			var reader = command.ExecuteReader();
			if (!reader.HasRows) {
				reader.Close();
				reader.Dispose();
				return null;
			}
			return new DbReader(reader);
		}

	}


}
