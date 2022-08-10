namespace BinanceBotDesktop.PartialForms
{
	partial class IslemForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.customLabelBaslik1 = new BinanceBotDesktop.CustomElement.CustomLabelBaslik();
			this.islem = new BinanceBotDesktop.CustomElement.CustomComboBoxIslecBase();
			this.gosterge2 = new BinanceBotDesktop.CustomElement.ComboBoxİndicts();
			this.buttonCustom2 = new BinanceBotDesktop.CustomElement.ButtonCustom();
			this.gosterge1 = new BinanceBotDesktop.CustomElement.ComboBoxİndicts();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.customLabelBaslik1);
			this.panel1.Controls.Add(this.islem);
			this.panel1.Controls.Add(this.gosterge2);
			this.panel1.Controls.Add(this.buttonCustom2);
			this.panel1.Controls.Add(this.gosterge1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(536, 95);
			this.panel1.TabIndex = 6;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// customLabelBaslik1
			// 
			this.customLabelBaslik1.AutoSize = true;
			this.customLabelBaslik1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.customLabelBaslik1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.customLabelBaslik1.Location = new System.Drawing.Point(226, 9);
			this.customLabelBaslik1.Name = "customLabelBaslik1";
			this.customLabelBaslik1.Size = new System.Drawing.Size(24, 27);
			this.customLabelBaslik1.TabIndex = 3;
			this.customLabelBaslik1.Text = "...";
			this.customLabelBaslik1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// islem
			// 
			this.islem.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.islem.FormattingEnabled = true;
			this.islem.Items.AddRange(new object[] {
            "<",
            "<=",
            ">",
            ">=",
            "==",
            "!=",
            "<",
            "<=",
            ">",
            ">=",
            "==",
            "!=",
            "<",
            "<=",
            ">",
            ">=",
            "==",
            "!=",
            "<",
            "<=",
            ">",
            ">=",
            "==",
            "!=",
            "<",
            "<=",
            ">",
            ">=",
            "==",
            "!=",
            "<",
            "<=",
            ">",
            ">=",
            "==",
            "!="});
			this.islem.Location = new System.Drawing.Point(158, 46);
			this.islem.Name = "islem";
			this.islem.Size = new System.Drawing.Size(145, 31);
			this.islem.TabIndex = 1;
			// 
			// gosterge2
			// 
			this.gosterge2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gosterge2.FormattingEnabled = true;
			this.gosterge2.Items.AddRange(new object[] {
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP"});
			this.gosterge2.Location = new System.Drawing.Point(309, 46);
			this.gosterge2.Name = "gosterge2";
			this.gosterge2.Size = new System.Drawing.Size(145, 31);
			this.gosterge2.TabIndex = 0;
			// 
			// buttonCustom2
			// 
			this.buttonCustom2.BackColor = System.Drawing.Color.Maroon;
			this.buttonCustom2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCustom2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCustom2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonCustom2.ForeColor = System.Drawing.Color.White;
			this.buttonCustom2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCustom2.Location = new System.Drawing.Point(460, 29);
			this.buttonCustom2.Name = "buttonCustom2";
			this.buttonCustom2.Size = new System.Drawing.Size(64, 54);
			this.buttonCustom2.TabIndex = 2;
			this.buttonCustom2.Text = "Ekle";
			this.buttonCustom2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCustom2.UseVisualStyleBackColor = false;
			this.buttonCustom2.Click += new System.EventHandler(this.buttonCustom2_Click);
			// 
			// gosterge1
			// 
			this.gosterge1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gosterge1.FormattingEnabled = true;
			this.gosterge1.Items.AddRange(new object[] {
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP",
            "EMA5",
            "EMA10",
            "EMA20",
            "EMA99",
            "EMA100",
            "EMA200",
            "RSI",
            "BBLOW",
            "BBMID",
            "BBUPP"});
			this.gosterge1.Location = new System.Drawing.Point(7, 46);
			this.gosterge1.Name = "gosterge1";
			this.gosterge1.Size = new System.Drawing.Size(145, 31);
			this.gosterge1.TabIndex = 0;
			// 
			// IslemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 95);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "IslemForm";
			this.Text = "IslemForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private CustomElement.CustomComboBoxIslecBase islem;
		private CustomElement.ComboBoxİndicts gosterge2;
		private CustomElement.ButtonCustom buttonCustom2;
		private CustomElement.ComboBoxİndicts gosterge1;
		private CustomElement.CustomLabelBaslik customLabelBaslik1;
	}
}