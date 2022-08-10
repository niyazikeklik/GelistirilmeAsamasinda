using BinanceBot;
using BinanceBot.Models;

using DTO.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrate
{
	internal class CoinRepos : BaseRepo<Coin>
	{
		public CoinRepos(DatabaseContext context) : base(context)
		{
		}
	}
}
