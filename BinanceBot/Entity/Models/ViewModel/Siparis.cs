using Binance.Net.Enums;
using Binance.Net.Objects.Shared;
using Binance.Net.Objects.Spot.SpotData;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
	public class Siparis
	{
		public long SiparisID { get; set; }
		public string Sembol { get; set; }
		public DateTime OlusturmaTarihi { get; set; }
		public decimal Fiyat { get; set; }
		public decimal Adet { get; set; }
		public decimal? StopFiyat { get; set; }
		public OrderSide Turu { get; set; }
		public bool? CalisiyorMu { get; set; }
		public OrderType Tip { get; set; }
		public OrderStatus Durumu { get; set; }
		public Siparis()
		{

		}
		public Siparis(BinanceOrder siparis)
		{

			this.SiparisID = siparis.OrderId;
			this.OlusturmaTarihi = siparis.CreateTime;
			this.Sembol = siparis.Symbol;
			this.Fiyat = siparis.Price;
			this.Adet = siparis.Quantity;
			this.Turu = siparis.Side;
			this.StopFiyat = siparis.StopPrice;
			this.CalisiyorMu = siparis.IsWorking;
			this.Tip = siparis.Type;
			this.Durumu = siparis.Status;


		}

	}
}
