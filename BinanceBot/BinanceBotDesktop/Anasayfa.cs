using BinanceBot;
using BinanceBot.Jobs;

using BinanceBotDesktop.PartialForms;

using CryptoExchange.Net;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceBotDesktop
{
	public partial class Anasayfa : Form
	{
		private void GridsNormalize(DataGridView grid)
		{
			foreach (DataGridViewRow row in grid.Rows)
			{
				foreach (DataGridViewCell hucre in row.Cells)
				{
					if (decimal.TryParse(hucre.Value.ToString(), out decimal value))
					{
						hucre.Value = value.Normalize();
					}
				}
			}
		}
		private async void PanelYenile()
		{
			panel1.Controls.Clear();
			var list = await BinanceAccount.GetHesapBilgileri();
			foreach (var item in list)
			{
				item.Asset = item.Asset.Equals(Rep.Ins.user.BorsaPara) ? item.Asset +Rep.Ins.user.YerelPara : item.Asset + Rep.Ins.user.BorsaPara;
				var form = new CoinBox(item);
				panel1.Controls.Add(form);
				form.Show();
			}
			var x = await BinanceAccount.GetHesapBilgileri();
		}

		 public Anasayfa()
		{
			InitializeComponent();
			PanelYenile();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}