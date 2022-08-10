namespace BinanceBotDesktop
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonCustom1 = new BinanceBotDesktop.CustomElement.ButtonCustom();
			this.customLabelBaslik1 = new BinanceBotDesktop.CustomElement.CustomLabelBaslik();
			this.buttonCustom3 = new BinanceBotDesktop.CustomElement.ButtonCustom();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// buttonCustom1
			// 
			this.buttonCustom1.BackColor = System.Drawing.Color.Maroon;
			this.buttonCustom1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCustom1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonCustom1.ForeColor = System.Drawing.Color.White;
			this.buttonCustom1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCustom1.Location = new System.Drawing.Point(493, 192);
			this.buttonCustom1.Name = "buttonCustom1";
			this.buttonCustom1.Size = new System.Drawing.Size(88, 36);
			this.buttonCustom1.TabIndex = 2;
			this.buttonCustom1.Text = "Ve Ekle";
			this.buttonCustom1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCustom1.UseVisualStyleBackColor = false;
			this.buttonCustom1.Click += new System.EventHandler(this.buttonCustom1_Click);
			// 
			// customLabelBaslik1
			// 
			this.customLabelBaslik1.AutoSize = true;
			this.customLabelBaslik1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.customLabelBaslik1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.customLabelBaslik1.Location = new System.Drawing.Point(355, 86);
			this.customLabelBaslik1.Name = "customLabelBaslik1";
			this.customLabelBaslik1.Size = new System.Drawing.Size(155, 27);
			this.customLabelBaslik1.TabIndex = 3;
			this.customLabelBaslik1.Text = "customLabelBaslik1";
			this.customLabelBaslik1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonCustom3
			// 
			this.buttonCustom3.BackColor = System.Drawing.Color.Maroon;
			this.buttonCustom3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCustom3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCustom3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonCustom3.ForeColor = System.Drawing.Color.White;
			this.buttonCustom3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCustom3.Location = new System.Drawing.Point(387, 192);
			this.buttonCustom3.Name = "buttonCustom3";
			this.buttonCustom3.Size = new System.Drawing.Size(100, 36);
			this.buttonCustom3.TabIndex = 2;
			this.buttonCustom3.Text = "Veya Ekle";
			this.buttonCustom3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCustom3.UseVisualStyleBackColor = false;
			this.buttonCustom3.Click += new System.EventHandler(this.buttonCustom3_Click);
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(602, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(535, 450);
			this.panel2.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1137, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.customLabelBaslik1);
			this.Controls.Add(this.buttonCustom3);
			this.Controls.Add(this.buttonCustom1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private CustomElement.ButtonCustom buttonCustom1;
		private CustomElement.ButtonCustom buttonCustom3;
		private System.Windows.Forms.Panel panel2;
		public CustomElement.CustomLabelBaslik customLabelBaslik1;
	}
}