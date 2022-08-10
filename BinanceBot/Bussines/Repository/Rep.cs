using Binance.Net.Objects;
using Binance.Net;
using CryptoExchange.Net.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Models;
using Newtonsoft.Json;
using System.IO;
using static BinanceBot.UserSettings;
using BinanceBot.Models;
using CryptoExchange.Net;
using System.Drawing;

namespace BinanceBot
{
	public class Rep
	{
		public static decimal YerelPara;
		static Rep instance;
		public static Rep Ins
		{
			get
			{
				if (instance == null)
					instance = new Rep();
				return instance;
			}
		}
		public Rep()
		{
			var jsonstr = File.ReadAllText(@"C:\Users\niyazi\Desktop\Projeler\BinanceBot\Bussines\Jsons\CoinList.json");
			CoinImgList = JsonConvert.DeserializeObject<List<ListEntit>>(jsonstr);
			var x = UserInfo.Get().ApiKey;
			var y = UserInfo.Get().ApiSecret;
			Client = new BinanceClient(new BinanceClientOptions()
			{
				ApiCredentials = new ApiCredentials(x, y)
			});
			WebSocketClient = new BinanceSocketClient(new BinanceSocketClientOptions());
			user = UserInfo.Get();
			WebSocketClient.Spot.SubscribeToSymbolMiniTickerUpdatesAsync(user.BorsaPara + user.YerelPara, data =>
			{
				decimal last = data.Data.LastPrice;
				YerelPara = last;
			});                                                                                                                                                                        
		}
		public UserInfo user;
		public BinanceClient Client;
		public BinanceSocketClient WebSocketClient;
		public List<ListEntit> CoinImgList;


	}
}
