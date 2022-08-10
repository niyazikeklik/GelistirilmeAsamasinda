using BinanceBot.Models;
using System;
using System.Windows.Forms;

namespace BinanceBotDesktop.CustomElement
{
	public class ComboBoxİndicts : ComboBox
	{
		public ComboBoxİndicts()
		{
			this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormattingEnabled = true;
			this.Location = new System.Drawing.Point(12, 191);
			this.Size = new System.Drawing.Size(145, 31);
			this.Items.AddRange(Enum.GetNames(typeof(Enums.Indıcators)));
		}
	}
}