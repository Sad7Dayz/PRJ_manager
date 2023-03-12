
namespace PRJ_manager
{
	partial class frmStockAdjust
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockAdjust));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtSearch = new MetroFramework.Controls.MetroTextBox();
			this.dataProduct = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRefno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPcode = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.cboAction = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1103, 48);
			this.panel1.TabIndex = 5;
			// 
			// picExit
			// 
			this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
			this.picExit.Location = new System.Drawing.Point(1043, 0);
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
			this.label1.Size = new System.Drawing.Size(201, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "상품 재고 조정 정보";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtSearch);
			this.panel2.Location = new System.Drawing.Point(12, 54);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(710, 39);
			this.panel2.TabIndex = 3;
			// 
			// txtSearch
			// 
			this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.txtSearch.ForeColor = System.Drawing.Color.White;
			this.txtSearch.Location = new System.Drawing.Point(0, 0);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PromptText = "상품검색";
			this.txtSearch.Size = new System.Drawing.Size(710, 39);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// dataProduct
			// 
			this.dataProduct.AllowUserToAddRows = false;
			this.dataProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column7,
            this.Column9,
            this.Edit});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightYellow;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataProduct.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataProduct.EnableHeadersVisualStyles = false;
			this.dataProduct.Location = new System.Drawing.Point(12, 99);
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
			this.dataProduct.Size = new System.Drawing.Size(1079, 349);
			this.dataProduct.TabIndex = 0;
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
			// Column4
			// 
			this.Column4.HeaderText = "바코드";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "상품명";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "브랜드";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.Width = 89;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "카테고리";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column7
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = null;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column7.HeaderText = "상품가격";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.Width = 125;
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
			// Edit
			// 
			this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Edit.HeaderText = "";
			this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
			this.Edit.MinimumWidth = 6;
			this.Edit.Name = "Edit";
			this.Edit.Width = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(12, 478);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "전표번호";
			// 
			// txtRefno
			// 
			this.txtRefno.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtRefno.Location = new System.Drawing.Point(85, 475);
			this.txtRefno.Name = "txtRefno";
			this.txtRefno.Size = new System.Drawing.Size(457, 27);
			this.txtRefno.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(12, 511);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "상품코드";
			// 
			// txtPcode
			// 
			this.txtPcode.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtPcode.Location = new System.Drawing.Point(85, 508);
			this.txtPcode.Name = "txtPcode";
			this.txtPcode.Size = new System.Drawing.Size(457, 27);
			this.txtPcode.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(20, 544);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "상품명";
			// 
			// txtPname
			// 
			this.txtPname.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtPname.Location = new System.Drawing.Point(85, 541);
			this.txtPname.Name = "txtPname";
			this.txtPname.Size = new System.Drawing.Size(457, 27);
			this.txtPname.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(12, 577);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "조정수량";
			// 
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtQty.Location = new System.Drawing.Point(85, 574);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(457, 27);
			this.txtQty.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(589, 481);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "상품처리";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(605, 514);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 15);
			this.label7.TabIndex = 9;
			this.label7.Text = "비고";
			// 
			// txtRemark
			// 
			this.txtRemark.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtRemark.Location = new System.Drawing.Point(670, 511);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(416, 27);
			this.txtRemark.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(597, 547);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 15);
			this.label8.TabIndex = 9;
			this.label8.Text = "관리자";
			// 
			// txtUserId
			// 
			this.txtUserId.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtUserId.Location = new System.Drawing.Point(670, 544);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(416, 27);
			this.txtUserId.TabIndex = 7;
			// 
			// cboAction
			// 
			this.cboAction.FormattingEnabled = true;
			this.cboAction.Items.AddRange(new object[] {
            "재고추가",
            "재고삭제"});
			this.cboAction.Location = new System.Drawing.Point(671, 482);
			this.cboAction.Name = "cboAction";
			this.cboAction.Size = new System.Drawing.Size(415, 23);
			this.cboAction.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Orange;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(958, 579);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 40);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "입력";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmStockAdjust
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 631);
			this.ControlBox = false;
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cboAction);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtUserId);
			this.Controls.Add(this.txtPname);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtRemark);
			this.Controls.Add(this.txtPcode);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtRefno);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataProduct);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmStockAdjust";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private MetroFramework.Controls.MetroTextBox txtSearch;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewImageColumn Edit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRefno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPcode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPname;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.ComboBox cboAction;
		private System.Windows.Forms.Button btnSave;
	}
}