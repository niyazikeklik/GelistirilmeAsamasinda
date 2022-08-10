using BinanceBotDesktop.CustomElement;

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
	public partial class IslemForm : Form 
	{
		Form1 Cagiran;
		string Baslik;
		public IslemForm(Form1 cagiran, string baslik)
		{
			Cagiran = cagiran;
			Baslik = baslik;
			InitializeComponent();
		}

		private void buttonCustom2_Click(object sender, EventArgs e)
		{
			Cagiran.cumle += gosterge1.Text + " " + islem.Text + " " + gosterge2.Text + " ";
			Cagiran.customLabelBaslik1.Text = Cagiran.cumle;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			this.customLabelBaslik1.Text = Baslik;

		}
	}
}
