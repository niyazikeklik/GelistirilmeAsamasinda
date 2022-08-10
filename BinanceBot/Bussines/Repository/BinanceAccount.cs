using Binance.Net.Objects;
using Binance.Net;
using Binance.Net.Objects.Spot.SpotData;

using CryptoExchange.Net.Authentication;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entity.Models;

namespace BinanceBot.Jobs
{
    public static class BinanceAccount
    {

        public async static Task<IEnumerable<BinanceBalance>> GetHesapBilgileri()
        {
            var result = await Rep.Ins.Client.General.GetAccountInfoAsync();
            var list = result.Data.Balances.Where(x => x.Total > 0); 
            foreach (var item in list)
            {
                
                Debug.WriteLine($"" +
                    $"Ürün: {item.Asset} " +
                    $"Serbest: {item.Free} " +
                    $"Kilitli: {item.Locked} " +
                    $"Toplam: {item.Total}");
            }
            return list;

        }
        public static  async Task<IEnumerable<Siparis>> GetAcikSiparisler()
        {
            var list = new List<Siparis>();

            var res = await Rep.Ins.Client.Spot.Order.GetOpenOrdersAsync();
            foreach (var item in res.Data)
            {

                Debug.WriteLine($"" +
                    $"Sipariş ID: {item.OrderId} " +
                    $"Sembol: {item.Symbol} " +
                    $"Oluşturma Zamanı: {item.CreateTime} " +
                    $"Fiyat: {item.Price} " +
                    $"Adet: {item.Quantity} " +
                    $"Türü: {item.Side} " +
                    $"Stop Fiyatı: {item.StopPrice} " +
                    $"Çalışıyor mu: {item.IsWorking} " +
                    $"Sipariş Tipi: {item.Type} " +
                    $"Durumu: {item.Status} ");
                list.Add(new Siparis(item));
            }
            return list;
        }
        public async static Task<IEnumerable<Siparis>> GetSiparisler()
        {
            var list = new List<Siparis>();
            var coinList = Rep.Ins.Client.General.GetAccountInfoAsync().Result.Data.Balances.Select(x=> x.Asset);
			foreach (var item in coinList)
			{
               
                var res = await Rep.Ins.Client.Spot.Order.GetOrdersAsync(item);
                if (res.Data == null) continue;
                foreach(var item3 in res.Data)
				{
                    list.Add(new Siparis(item3));
				}
            }
            return list;
        }
    }
}
