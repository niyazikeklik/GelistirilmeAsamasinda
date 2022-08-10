using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceBotDesktop.CustomElement
{
	public class ButtonCustom : Button
	{
		public ButtonCustom()
		{
			this.BackColor = System.Drawing.Color.Maroon;
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Location = new System.Drawing.Point(80, 40);
			this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UseVisualStyleBackColor = false;
		}
	}

}
