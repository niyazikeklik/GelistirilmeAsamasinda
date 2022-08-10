using Binance.Net;
using Binance.Net.Objects.Spot.SpotData;

using BinanceBot;
using BinanceBot.Jobs;

using CryptoExchange.Net;

using Entity.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BinanceBotDesktop.PartialForms
{
	public partial class CoinBox : Form
	{
		private decimal oncekiPrice;
		private BinanceBalance coin;
		public CoinBox(BinanceBalance balance)
		{
			coin = balance;
			this.BackColor = Color.White;
			this.Dock = DockStyle.Left;
			this.TopLevel = false;

			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void CoinBox_Load(object sender, EventArgs e)
		{
			lbl_CoinName.Text = coin.Asset;
			lbl_Adet.Text = "Adet: " + coin.Total.Normalize().ToString();
			lbl_Free.Text = "Serbest: " + coin.Free.Normalize().ToString();
			lbl_Lock.Text ="Kilitli: " +  coin.Locked.Normalize().ToString();
			 
			
			string url = Rep.Ins.CoinImgList.First(x => coin.Asset.Contains(x.Sembol)).Img;
			pictureBox1.Load(url);
			Rep.Ins.WebSocketClient.Spot.SubscribeToSymbolMiniTickerUpdatesAsync(coin.Asset, data =>
			{
				decimal last = data.Data.LastPrice;
				lbl_Deger.Text = (coin.Total * last).Normalize() + $" {Rep.Ins.user.BorsaPara}".ToString();
				label1.Text = (coin.Total * last * Rep.YerelPara).Normalize() + " " +Rep.Ins.user.YerelPara.ToString();
				lbl_Price.Text =  last.Normalize().ToString();
				lbl_Price.ForeColor = oncekiPrice < last ? Color.Green : Color.Red;
				oncekiPrice = last;
			});
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
