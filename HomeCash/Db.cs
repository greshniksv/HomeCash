using System.Collections.Specialized;
using System.Data.SQLite;

namespace HomeCash
{
	public class DbReader
	{
		private static SQLiteDataReader _reader;

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
		

		public static void Connect()
		{
			_connection = new SQLiteConnection(@"Data Source=.\homecashe.db;Version=3;");
			_connection.Open();
			_command = _connection.CreateCommand();
		}

		public static void Exec(string sql, params object[] parameter)
		{
			if (parameter != null)
			{
				sql = string.Format(sql, parameter);
			}
			_command.CommandText = sql;
			_command.ExecuteNonQuery();
		}

		public static NameValueCollection ReadOne(string sql, params object[] parameter)
		{
			if (parameter != null)
			{
				sql = string.Format(sql, parameter);
			}
			_command.CommandText = sql;
			using (var reader = _command.ExecuteReader())
			{
				return reader.GetValues();
			}
		}

		public static NameValueCollection ReadOneById(string table, string id)
		{
			_command.CommandText = string.Format("select * from {0} where id = '{1}'",table, id);
			using (var reader = _command.ExecuteReader())
			{
				return reader.GetValues();
			}
		}

		public static string ReadNameById(string table, string id)
		{
			_command.CommandText = string.Format("select name from {0} where id = '{1}'", table, id);
			using (var reader = _command.ExecuteReader())
			{
				return reader["name"].ToString();
			}
		}

		public static DbReader Read(string sql, params object[] parameter)
		{
			if (parameter != null) {
				sql = string.Format(sql, parameter);
			}
			_command.CommandText = sql;
			var reader = _command.ExecuteReader();
			if (!reader.HasRows)
			{
				reader.Close();
				reader.Dispose();
				return null;
			}
			return new DbReader(reader);
		}

	}


}
