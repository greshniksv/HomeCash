using System.Collections.Specialized;
using System.Data.SQLite;

namespace HomeCash
{
	public static class Db
	{
		private static SQLiteConnection _connection;
		private static SQLiteCommand _command;
		private static SQLiteDataReader _reader;

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

		public static NameValueCollection ReadOne(string sql)
		{
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

		public static bool Read(string sql)
		{
			_command.CommandText = sql;
			_reader = _command.ExecuteReader();
			if (!_reader.HasRows)
			{
				_reader.Close();
				_reader.Dispose();
				return false;
			}
			return true;
		}

		public static NameValueCollection ReadNext()
		{
			if (_reader.IsClosed)
			{
				return null;
			}
			_reader.Read();
			if (!_reader.HasRows)
			{
				_reader.Close();
				_reader.Dispose();
				return null;
			}
			return _reader.GetValues();
		}
	}


}
