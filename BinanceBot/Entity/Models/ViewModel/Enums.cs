namespace BinanceBot.Models
{
	public static class Enums
	{
		public enum IslemStatu
		{
			Gerceklesti = 0,
			Bekliyor = 1,
			İptalEdildi = 2,
		}
		public enum Indıcators
		{
			EMA5 = 0,
			EMA10 = 1,
			EMA20 = 2,
			EMA99 = 3,
			EMA100 = 4,
			EMA200 = 5,
			RSI = 6,
			BBLOW = 7,
			BBMID = 8,
			BBUPP = 9,

		}
		public static string[] Islecler = { "<", "<=", ">",">=", "==", "!="};
	}
}
