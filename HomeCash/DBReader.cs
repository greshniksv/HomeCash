namespace HomeCash
{
	using System.Collections.Specialized;
	using System.Data.SQLite;

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
}
