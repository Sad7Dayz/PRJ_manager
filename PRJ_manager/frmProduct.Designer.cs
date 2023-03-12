
namespace PRJ_manager
{
	partial class frmProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtSearch = new MetroFramework.Controls.MetroTextBox();
			this.picAddData = new System.Windows.Forms.PictureBox();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlProduct = new System.Windows.Forms.Panel();
			this.chkNotax = new System.Windows.Forms.CheckBox();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.cboBrand = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMinQty = new System.Windows.Forms.TextBox();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPname = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPcode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataProduct = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
			this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAddData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			this.pnlProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Green;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.picAddData);
			this.panel1.Controls.Add(this.picExit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1037, 48);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtSearch);
			this.panel2.Location = new System.Drawing.Point(164, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(710, 39);
			this.panel2.TabIndex = 3;
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.Color.Black;
			this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
			this.txtSearch.Location = new System.Drawing.Point(0, 0);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PromptText = "상품검색";
			this.txtSearch.Size = new System.Drawing.Size(710, 39);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// picAddData
			// 
			this.picAddData.Dock = System.Windows.Forms.DockStyle.Right;
			this.picAddData.Image = ((System.Drawing.Image)(resources.GetObject("picAddData.Image")));
			this.picAddData.Location = new System.Drawing.Point(917, 0);
			this.picAddData.Name = "picAddData";
			this.picAddData.Size = new System.Drawing.Size(60, 48);
			this.picAddData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picAddData.TabIndex = 2;
			this.picAddData.TabStop = false;
			this.picAddData.Click += new System.EventHandler(this.picAddData_Click);
			// 
			// picExit
			// 
			this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
			this.picExit.Location = new System.Drawing.Point(977, 0);
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
			this.label1.Size = new System.Drawing.Size(101, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "상품 정보";
			// 
			// pnlProduct
			// 
			this.pnlProduct.Controls.Add(this.chkNotax);
			this.pnlProduct.Controls.Add(this.cboCategory);
			this.pnlProduct.Controls.Add(this.cboBrand);
			this.pnlProduct.Controls.Add(this.btnCancel);
			this.pnlProduct.Controls.Add(this.btnSave);
			this.pnlProduct.Controls.Add(this.btnUpdate);
			this.pnlProduct.Controls.Add(this.picClose);
			this.pnlProduct.Controls.Add(this.txtPrice);
			this.pnlProduct.Controls.Add(this.label5);
			this.pnlProduct.Controls.Add(this.txtMinQty);
			this.pnlProduct.Controls.Add(this.txtBarcode);
			this.pnlProduct.Controls.Add(this.label8);
			this.pnlProduct.Controls.Add(this.txtPname);
			this.pnlProduct.Controls.Add(this.label7);
			this.pnlProduct.Controls.Add(this.label3);
			this.pnlProduct.Controls.Add(this.label4);
			this.pnlProduct.Controls.Add(this.label6);
			this.pnlProduct.Controls.Add(this.txtPcode);
			this.pnlProduct.Controls.Add(this.label2);
			this.pnlProduct.Location = new System.Drawing.Point(192, 263);
			this.pnlProduct.Name = "pnlProduct";
			this.pnlProduct.Size = new System.Drawing.Size(682, 385);
			this.pnlProduct.TabIndex = 8;
			this.pnlProduct.Visible = false;
			// 
			// chkNotax
			// 
			this.chkNotax.AutoSize = true;
			this.chkNotax.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.chkNotax.Location = new System.Drawing.Point(144, 244);
			this.chkNotax.Name = "chkNotax";
			this.chkNotax.Size = new System.Drawing.Size(108, 21);
			this.chkNotax.TabIndex = 6;
			this.chkNotax.Text = "면세 상품";
			this.chkNotax.UseVisualStyleBackColor = true;
			// 
			// cboCategory
			// 
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(144, 166);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(499, 23);
			this.cboCategory.TabIndex = 4;
			// 
			// cboBrand
			// 
			this.cboBrand.FormattingEnabled = true;
			this.cboBrand.Location = new System.Drawing.Point(144, 132);
			this.cboBrand.Name = "cboBrand";
			this.cboBrand.Size = new System.Drawing.Size(499, 23);
			this.cboBrand.TabIndex = 3;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Gray;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(515, 324);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(128, 40);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "취소";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Orange;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(247, 324);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 40);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "입력";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Orange;
			this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(381, 324);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(128, 40);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "수정";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// picClose
			// 
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(647, 3);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(32, 28);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picClose.TabIndex = 7;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(144, 198);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(499, 25);
			this.txtPrice.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(47, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "브랜드";
			// 
			// txtMinQty
			// 
			this.txtMinQty.Location = new System.Drawing.Point(144, 280);
			this.txtMinQty.Name = "txtMinQty";
			this.txtMinQty.Size = new System.Drawing.Size(499, 25);
			this.txtMinQty.TabIndex = 7;
			// 
			// txtBarcode
			// 
			this.txtBarcode.Location = new System.Drawing.Point(144, 62);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(499, 25);
			this.txtBarcode.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(38, 206);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 17);
			this.label8.TabIndex = 3;
			this.label8.Text = "상품가격";
			// 
			// txtPname
			// 
			this.txtPname.Location = new System.Drawing.Point(144, 96);
			this.txtPname.Name = "txtPname";
			this.txtPname.Size = new System.Drawing.Size(499, 25);
			this.txtPname.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(20, 282);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 17);
			this.label7.TabIndex = 3;
			this.label7.Text = "최고재고수량";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(47, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "바코드";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(47, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "상품명";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(38, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "카테고리";
			// 
			// txtPcode
			// 
			this.txtPcode.Location = new System.Drawing.Point(144, 28);
			this.txtPcode.Name = "txtPcode";
			this.txtPcode.Size = new System.Drawing.Size(499, 25);
			this.txtPcode.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(38, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "상품코드";
			// 
			// dataProduct
			// 
			this.dataProduct.AllowUserToAddRows = false;
			this.dataProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            this.Column8,
            this.Column9,
            this.Edit,
            this.Delete});
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.Honeydew;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightYellow;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataProduct.DefaultCellStyle = dataGridViewCellStyle17;
			this.dataProduct.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataProduct.EnableHeadersVisualStyles = false;
			this.dataProduct.Location = new System.Drawing.Point(0, 48);
			this.dataProduct.Name = "dataProduct";
			this.dataProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.dataProduct.RowHeadersVisible = false;
			this.dataProduct.RowHeadersWidth = 51;
			this.dataProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
			this.dataProduct.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dataProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
			this.dataProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.dataProduct.RowTemplate.Height = 27;
			this.dataProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataProduct.Size = new System.Drawing.Size(1037, 209);
			this.dataProduct.TabIndex = 7;
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
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle14.Format = "N0";
			dataGridViewCellStyle14.NullValue = null;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle14;
			this.Column7.HeaderText = "상품가격";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.Width = 125;
			// 
			// Column8
			// 
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column8.DefaultCellStyle = dataGridViewCellStyle15;
			this.Column8.HeaderText = "Tax";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.Width = 125;
			// 
			// Column9
			// 
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.Format = "N0";
			dataGridViewCellStyle16.NullValue = null;
			this.Column9.DefaultCellStyle = dataGridViewCellStyle16;
			this.Column9.HeaderText = "최소수량";
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
			// Delete
			// 
			this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Delete.HeaderText = "";
			this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
			this.Delete.MinimumWidth = 6;
			this.Delete.Name = "Delete";
			this.Delete.Width = 6;
			// 
			// frmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1037, 700);
			this.ControlBox = false;
			this.Controls.Add(this.pnlProduct);
			this.Controls.Add(this.dataProduct);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmProduct";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picAddData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			this.pnlProduct.ResumeLayout(false);
			this.pnlProduct.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picAddData;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlProduct;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.TextBox txtPcode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataProduct;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMinQty;
		private System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPname;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboCategory;
		private System.Windows.Forms.ComboBox cboBrand;
		private System.Windows.Forms.CheckBox chkNotax;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewImageColumn Edit;
		private System.Windows.Forms.DataGridViewImageColumn Delete;
		private System.Windows.Forms.Panel panel2;
		private MetroFramework.Controls.MetroTextBox txtSearch;
	}
}