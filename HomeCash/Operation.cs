
namespace HomeCash
{
	static class Operation
	{
		public static float GetBalance(string cashId) {
			var data = Db.ReadOne("select sum(p.sum) as sum from purchase p where p.cashid = '{0}'", cashId);
			return float.Parse(data["sum"]);
		}


	}
}
