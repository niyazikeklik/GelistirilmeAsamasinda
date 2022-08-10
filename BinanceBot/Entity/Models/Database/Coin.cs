
using Skender.Stock.Indicators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BinanceBot.Models
{
    public class Coin
    {
        [Key]
        public string CoinName { get; set; }
        public ICollection<Mum> Mumlar { get; set; }
    }
}
