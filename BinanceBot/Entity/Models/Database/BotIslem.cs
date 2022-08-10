using Binance.Net.Enums;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static BinanceBot.Models.Enums;

namespace BinanceBot.Models
{
	public class BotIslem
	{
		[Key]
		public int BotIslemID { get; set; }
		[ForeignKey("Coin")]
		public string CoinName { get; set; }
		public double Fiyat { get; set; }
		public DateTime Tarih { get; set; }
		IslemStatu IslemDurumu { get; set; }
		OrderType IslemTipi { get; set; }
		public virtual Coin coin { get; set; }

	}
}
