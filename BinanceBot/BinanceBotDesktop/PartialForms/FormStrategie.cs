using BinanceBot;
using BinanceBot.Jobs;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceBotDesktop.PartialForms
{
	public partial class FormStrategie : Form
	{
		private string CoinName;
		private IStrategie strategie;
		public FormStrategie(string coinName, IStrategie strategie)
		{
			CoinName = coinName;
			this.strategie = strategie;	
			InitializeComponent();
		}

		private void FormStrategie_Load(object sender, EventArgs e)
		{
			
			Rep.Ins.WebSocketClient.Spot.SubscribeToSymbolMiniTickerUpdatesAsync(CoinName, data => {
				decimal last = data.Data.LastPrice;
				if (strategie.BuySignal(CoinName))
					new Telegram.Telegram().MesajGonder($"{ CoinName} için al sinyali. Fiyat: " + last);
				else if (strategie.SellSignal(CoinName))
					new Telegram.Telegram().MesajGonder($"{ CoinName} için sat sinyali. Fiyat: " + last);

			});
		}
	}
}
