using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceBotDesktop.CustomElement
{
	public class CustomLabelBaslik : Label
	{
		public CustomLabelBaslik()
		{

			this.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Location = new System.Drawing.Point(150, 12);
			this.Size = new System.Drawing.Size(133, 42);
			this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		}
	}

}
