using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinanceBot.Jobs
{
   public interface IStrategie
    {
        public bool SellSignal(string coinName);
        public bool BuySignal(string coinName);

    }
}
