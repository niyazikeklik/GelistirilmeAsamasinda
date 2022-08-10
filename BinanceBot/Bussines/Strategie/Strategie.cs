using Binance.Net.Enums;
using Binance.Net.Interfaces;

using BinanceBot.Models;

using Microsoft.EntityFrameworkCore;
using Skender.Stock.Indicators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace BinanceBot.Jobs
{
    public class Strategie : IStrategie
    {
        public static List<Mum> ConvertBinanceToQuote(IEnumerable<IBinanceKline> list)
        {
            List<Mum> listem = new();
            foreach (var BinanceKline in list)
            {
                Mum yeniQuote = new();
                yeniQuote.Close = BinanceKline.Close;
                yeniQuote.Date = BinanceKline.OpenTime;
                yeniQuote.High = BinanceKline.High;
                yeniQuote.Low = BinanceKline.Low;
                yeniQuote.Open = BinanceKline.Open;
                yeniQuote.Volume = BinanceKline.QuoteVolume;
                listem.Add(yeniQuote);
            }
            return listem;
        }
        public async Task<List<Mum>> GetData(string coinName, KlineInterval mumSuresi = KlineInterval.FourHour, DateTime? basla = null, DateTime? son = null, int? count = null)
        {
           // List<Quote> quotes = new();
           // var context = new DatabaseContext();
           // var records = context.Mumlar.Where(x => coinName.Equals(coinName)).Include("Mumlar");
           // var sonTarih = records.Last().Mumlar.Last().Date;
           // Debug.WriteLine(KlineInterval.FourHour);
           //// if (sonTarih < )
            var x = await Rep.Ins.Client.Spot.Market.GetKlinesAsync(coinName, mumSuresi, basla, son, count);
            return ConvertBinanceToQuote(x.Data);
        }

        public static bool CheckData()
        {
            return false;

        }
        public bool BuySignal(string coinName)
        {
            var data = GetData(coinName).Result;
            var rsi = data.GetRsi(14).Last();
            var sma = data.GetEma(10).Last();
            var sma200 = data.GetEma(200).Last();
            var BB = data.GetBollingerBands().Last();
            Debug.WriteLine($@"RSİ: {rsi.Rsi} Ema10: {sma.Ema} Ema200: {sma200.Ema}");
            return 
                rsi.Rsi < 30 && BB.LowerBand > 0.085m && sma.Ema < -1 
                        || 
                10000 < sma200.Ema;


            
        }

        public bool SellSignal(string coinName)
        {
            //var data = GetData(coinName).Result;
      

            return false;
        }
    }
}
