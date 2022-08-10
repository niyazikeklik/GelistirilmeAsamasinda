using Skender.Stock.Indicators;

using System.ComponentModel.DataAnnotations;

namespace BinanceBot.Models
{
	public class Mum : Quote
	{
		[Key]
		public int Count { get; set; }
	}
}
