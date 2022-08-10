using Binance.Net.Objects;
using Binance.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BinanceBot.Jobs
{
	public static class Trader
	{

		public static async void SellTrainer(string coinName, decimal? maliyet, decimal? minimumKar, decimal? fiyatSuOluncaStopKoy, decimal? stopKoymaOrani)
		{
			var WebSocket = await Rep.Ins.WebSocketClient.Spot.SubscribeToSymbolMiniTickerUpdatesAsync(coinName, async data =>
			{
				var item = data.Data;

				if ((item.LastPrice / maliyet) >= minimumKar && item.LastPrice >= fiyatSuOluncaStopKoy)
				{
					fiyatSuOluncaStopKoy = item.LastPrice * stopKoymaOrani;
					var stopFiyat = (item.LastPrice * stopKoymaOrani);
					var satisFiyati = stopFiyat * 0.099m;
					var acikSiparisler = await BinanceAccount.GetAcikSiparisler();
					var Urun = acikSiparisler.FirstOrDefault(x => x.Sembol == coinName);


					var x = await Rep.Ins.Client.Spot.Order.PlaceTestOrderAsync(
						Urun.Sembol,
						Binance.Net.Enums.OrderSide.Sell,
						Binance.Net.Enums.OrderType.StopLoss,
						Urun.Adet * 1,
						null, null,
						satisFiyati,
						null,
						stopFiyat,
						null
						);





					Debug.WriteLine($"\n\n\nSEMBOL ADI: {coinName}");
					Debug.WriteLine("-------------------------");
					Debug.WriteLine($"Güncel fiyat: {item.LastPrice}");
					Debug.WriteLine($"Ürün şu fiyatın altına düşerse satılacak: {stopFiyat}");
					Debug.WriteLine($"Bir dahaki stoploss satış emri verilmesi için ulaşılması gereken fiyat: {fiyatSuOluncaStopKoy}");
					Debug.WriteLine("-------------------------\n\n\n");
				}

			});
		}
		public static async void BuyTrainer(string coinName, decimal? fiyatSuOluncaStopKoy)
		{
			var WebSocket = await Rep.Ins.WebSocketClient.Spot.SubscribeToSymbolMiniTickerUpdatesAsync(coinName, async data =>
			{
				var item = data.Data;
				if (item.LastPrice < fiyatSuOluncaStopKoy)
				{
					decimal stopFiyat = item.LastPrice * 1.05m;
					decimal satinAlmaFiyat = stopFiyat * 1.003m;
					var x = await Rep.Ins.Client.Spot.Order.PlaceTestOrderAsync(
							coinName,
							Binance.Net.Enums.OrderSide.Buy,
							Binance.Net.Enums.OrderType.StopLoss, null, null, null, satinAlmaFiyat, null, stopFiyat);
					fiyatSuOluncaStopKoy = item.LastPrice * 0.99m;
				}


			});
		}


	}
}
