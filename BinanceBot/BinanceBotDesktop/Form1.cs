using BinanceBotDesktop.PartialForms;

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
	public partial class Form1 : Form
	{
		void IslemEkle(string baslik)
		{
			IslemForm islem = new IslemForm(this, baslik);
			islem.Dock = DockStyle.Top;
			islem.TopLevel = false;
			panel2.Controls.Add(islem);
			islem.BringToFront();
			islem.Show();
		}
		public string cumle = "";
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCustom1_Click(object sender, EventArgs e)
		{
			cumle += " && ";
			IslemEkle("Ve");
			customLabelBaslik1.Text = cumle;

		}

		private void buttonCustom3_Click(object sender, EventArgs e)
		{
			cumle += " || ";
			IslemEkle("Veya");
			customLabelBaslik1.Text = cumle;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			IslemEkle("");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new Anasayfa().Show();
		}
	}
}
