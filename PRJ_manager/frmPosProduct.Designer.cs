
namespace PRJ_manager
{
	partial class frmPosProduct
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosProduct));
			this.dataProduct = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSelect = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtSearch = new MetroFramework.Controls.MetroTextBox();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlQty = new System.Windows.Forms.Panel();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			this.pnlQty.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataProduct
			// 
			this.dataProduct.AllowUserToAddRows = false;
			this.dataProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataProduct.ColumnHeadersHeight = 30;
			this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column9,
            this.colSelect});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightYellow;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataProduct.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataProduct.EnableHeadersVisualStyles = false;
			this.dataProduct.Location = new System.Drawing.Point(0, 48);
			this.dataProduct.Name = "dataProduct";
			this.dataProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataProduct.RowHeadersVisible = false;
			this.dataProduct.RowHeadersWidth = 51;
			this.dataProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
			this.dataProduct.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dataProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
			this.dataProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.dataProduct.RowTemplate.Height = 27;
			this.dataProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataProduct.Size = new System.Drawing.Size(998, 510);
			this.dataProduct.TabIndex = 10;
			this.dataProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduct_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column1.HeaderText = "번호";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 71;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "상품코드";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Visible = false;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column3.HeaderText = "바코드(Barcode)";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 171;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "상품명";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			// 
			// Column4
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = null;
			this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column4.HeaderText = "가격";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column9
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = null;
			this.Column9.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column9.HeaderText = "재고수량";
			this.Column9.MinimumWidth = 6;
			this.Column9.Name = "Column9";
			this.Column9.Width = 125;
			// 
			// colSelect
			// 
			this.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSelect.HeaderText = "";
			this.colSelect.Image = ((System.Drawing.Image)(resources.GetObject("colSelect.Image")));
			this.colSelect.MinimumWidth = 6;
			this.colSelect.Name = "colSelect";
			this.colSelect.Width = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Orange;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.picExit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(998, 48);
			this.panel1.TabIndex = 9;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtSearch);
			this.panel2.Location = new System.Drawing.Point(271, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(651, 39);
			this.panel2.TabIndex = 3;
			// 
			// txtSearch
			// 
			this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.txtSearch.Location = new System.Drawing.Point(0, 0);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PromptText = "상품검색";
			this.txtSearch.Size = new System.Drawing.Size(651, 39);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// picExit
			// 
			this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
			this.picExit.Location = new System.Drawing.Point(938, 0);
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
			this.label1.BackColor = System.Drawing.Color.Orange;
			this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "상품 리스트 검색/선택";
			// 
			// pnlQty
			// 
			this.pnlQty.BackColor = System.Drawing.Color.MintCream;
			this.pnlQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlQty.Controls.Add(this.txtQty);
			this.pnlQty.Controls.Add(this.label2);
			this.pnlQty.Location = new System.Drawing.Point(357, 248);
			this.pnlQty.Name = "pnlQty";
			this.pnlQty.Size = new System.Drawing.Size(238, 125);
			this.pnlQty.TabIndex = 11;
			this.pnlQty.Visible = false;
			// 
			// txtQty
			// 
			this.txtQty.BackColor = System.Drawing.Color.LightYellow;
			this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtQty.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtQty.Location = new System.Drawing.Point(30, 41);
			this.txtQty.Multiline = true;
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(171, 61);
			this.txtQty.TabIndex = 1;
			this.txtQty.Text = "1";
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(30, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "수량";
			// 
			// frmPosProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 558);
			this.ControlBox = false;
			this.Controls.Add(this.pnlQty);
			this.Controls.Add(this.dataProduct);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmPosProduct";
			((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			this.pnlQty.ResumeLayout(false);
			this.pnlQty.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataProduct;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private MetroFramework.Controls.MetroTextBox txtSearch;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlQty;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewImageColumn colSelect;
	}
}