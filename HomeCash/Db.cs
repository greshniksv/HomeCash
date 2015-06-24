using System.Collections.Specialized;
using System.Data.SQLite;

namespace HomeCash
{
	using System.IO;
	using System.Text;

	public class DbReader
	{
		private readonly SQLiteDataReader _reader;

		public DbReader(SQLiteDataReader reader) {
			_reader = reader;
		}

		public NameValueCollection Next() {
			if (_reader.IsClosed) {
				return null;
			}
			_reader.Read();
			if (!_reader.HasRows) {
				_reader.Close();
				_reader.Dispose();
				return null;
			}
			return _reader.GetValues();
		}

		public void Close() {
			if (_reader.IsClosed) {
				return;
			}
			_reader.Close();
			_reader.Dispose();
		}

	}

	public static class Db
	{
		private static SQLiteConnection _connection;
		private static SQLiteCommand _command;


		private static SQLiteCommand CreateCommandConnection() {
			//var connection = new SQLiteConnection(@"Data Source=.\homecashe.db;Version=3;");
			//connection.Open();
			return _connection.CreateCommand();
		}

		public static void Connect() {
			bool generateDatabase = !File.Exists(@".\homecashe.db");
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
