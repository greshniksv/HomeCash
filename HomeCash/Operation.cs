
namespace HomeCash
{
	static class Operation
	{
		public static float GetBalance(string cashId) {
			var data = Db.ReadOne("select sum(p.sum) as sum from purchase p where p.cashid = '{0}'", cashId);
			var sum = data["sum"];
			if (string.IsNullOrEmpty(sum)) {
				return 0;
			}
			return float.Parse(data["sum"].Replace(".",","));
		}


	}
}
