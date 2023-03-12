
namespace PRJ_manager
{
	partial class frmPosBoard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosBoard));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblSaleAmt = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblSalesProduct = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblWarnProduct = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Green;
			this.panel1.Controls.Add(this.picExit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(890, 48);
			this.panel1.TabIndex = 3;
			// 
			// picExit
			// 
			this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
			this.picExit.Location = new System.Drawing.Point(830, 0);
			this.picExit.Name = "picExit";
			this.picExit.Size = new System.Drawing.Size(60, 48);
			this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picExit.TabIndex = 1;
			this.picExit.TabStop = false;
			this.picExit.Click += new System.EventHandler(this.picExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Teal;
			this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "POS 현황판";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel2.Controls.Add(this.lblSaleAmt);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(27, 75);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(260, 152);
			this.panel2.TabIndex = 4;
			// 
			// lblSaleAmt
			// 
			this.lblSaleAmt.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblSaleAmt.Location = new System.Drawing.Point(25, 70);
			this.lblSaleAmt.Name = "lblSaleAmt";
			this.lblSaleAmt.Size = new System.Drawing.Size(190, 38);
			this.lblSaleAmt.TabIndex = 1;
			this.lblSaleAmt.Text = "0";
			this.lblSaleAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(25, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 38);
			this.label2.TabIndex = 0;
			this.label2.Text = "일 판매 금액";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel3.Controls.Add(this.lblSalesProduct);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(320, 75);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(260, 152);
			this.panel3.TabIndex = 4;
			// 
			// lblSalesProduct
			// 
			this.lblSalesProduct.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblSalesProduct.Location = new System.Drawing.Point(25, 70);
			this.lblSalesProduct.Name = "lblSalesProduct";
			this.lblSalesProduct.Size = new System.Drawing.Size(190, 38);
			this.lblSalesProduct.TabIndex = 1;
			this.lblSalesProduct.Text = "0";
			this.lblSalesProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(25, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 38);
			this.label5.TabIndex = 0;
			this.label5.Text = "일 판매 금액";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.panel4.Controls.Add(this.lblWarnProduct);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Location = new System.Drawing.Point(613, 75);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(260, 152);
			this.panel4.TabIndex = 4;
			// 
			// lblWarnProduct
			// 
			this.lblWarnProduct.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblWarnProduct.Location = new System.Drawing.Point(3, 70);
			this.lblWarnProduct.Name = "lblWarnProduct";
			this.lblWarnProduct.Size = new System.Drawing.Size(254, 38);
			this.lblWarnProduct.TabIndex = 1;
			this.lblWarnProduct.Text = "0";
			this.lblWarnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(3, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(252, 38);
			this.label7.TabIndex = 0;
			this.label7.Text = "재고 경고 상품수";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(105, 245);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(715, 375);
			this.chart1.TabIndex = 5;
			this.chart1.Text = "chart1";
			// 
			// frmPosBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 643);
			this.ControlBox = false;
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmPosBoard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSaleAmt;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblSalesProduct;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblWarnProduct;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}