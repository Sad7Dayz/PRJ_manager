
namespace PRJ_manager
{
	partial class frmSalesReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReport));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataSales = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblCard = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblCash = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblTotAmt = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblNoAmt = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblVatAmt = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTaxAmt = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblUserName = new System.Windows.Forms.Label();
			this.cboCashier = new System.Windows.Forms.ComboBox();
			this.btnPrintView = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.dateTo = new System.Windows.Forms.DateTimePicker();
			this.dateFrom = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(1084, 48);
			this.panel1.TabIndex = 7;
			// 
			// picExit
			// 
			this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
			this.picExit.Location = new System.Drawing.Point(1024, 0);
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
			this.label1.BackColor = System.Drawing.Color.Green;
			this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "판매현황";
			// 
			// dataSales
			// 
			this.dataSales.AllowUserToAddRows = false;
			this.dataSales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataSales.ColumnHeadersHeight = 30;
			this.dataSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column7,
            this.Column9,
            this.Column8,
            this.Column3});
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.Honeydew;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightYellow;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataSales.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataSales.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataSales.EnableHeadersVisualStyles = false;
			this.dataSales.Location = new System.Drawing.Point(0, 98);
			this.dataSales.Name = "dataSales";
			this.dataSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataSales.RowHeadersVisible = false;
			this.dataSales.RowHeadersWidth = 51;
			this.dataSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataSales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
			this.dataSales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dataSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
			this.dataSales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.dataSales.RowTemplate.Height = 27;
			this.dataSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataSales.Size = new System.Drawing.Size(1084, 409);
			this.dataSales.TabIndex = 14;
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
			// Column10
			// 
			this.Column10.HeaderText = "ID";
			this.Column10.MinimumWidth = 6;
			this.Column10.Name = "Column10";
			this.Column10.Visible = false;
			this.Column10.Width = 125;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column4.HeaderText = "거래No.";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.HeaderText = "상품코드";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 107;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "상품명";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			// 
			// Column7
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.Format = "N0";
			dataGridViewCellStyle8.NullValue = null;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle8;
			this.Column7.HeaderText = "가격";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.Width = 125;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Format = "N0";
			dataGridViewCellStyle9.NullValue = null;
			this.Column9.DefaultCellStyle = dataGridViewCellStyle9;
			this.Column9.HeaderText = "수량";
			this.Column9.MinimumWidth = 6;
			this.Column9.Name = "Column9";
			this.Column9.Width = 71;
			// 
			// Column8
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Format = "N0";
			dataGridViewCellStyle10.NullValue = null;
			this.Column8.DefaultCellStyle = dataGridViewCellStyle10;
			this.Column8.HeaderText = "금액";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.Width = 71;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "구분";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 71;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lblCard);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.lblCash);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.lblTotAmt);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.lblNoAmt);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.lblVatAmt);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.lblTaxAmt);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 507);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1084, 135);
			this.panel3.TabIndex = 13;
			// 
			// lblCard
			// 
			this.lblCard.BackColor = System.Drawing.Color.LightYellow;
			this.lblCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCard.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblCard.ForeColor = System.Drawing.Color.Maroon;
			this.lblCard.Location = new System.Drawing.Point(891, 91);
			this.lblCard.Name = "lblCard";
			this.lblCard.Size = new System.Drawing.Size(153, 30);
			this.lblCard.TabIndex = 5;
			this.lblCard.Text = "0";
			this.lblCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label11.ForeColor = System.Drawing.Color.Maroon;
			this.label11.Location = new System.Drawing.Point(807, 99);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(39, 15);
			this.label11.TabIndex = 16;
			this.label11.Text = "카드";
			// 
			// lblCash
			// 
			this.lblCash.BackColor = System.Drawing.Color.FloralWhite;
			this.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCash.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblCash.ForeColor = System.Drawing.Color.Blue;
			this.lblCash.Location = new System.Drawing.Point(891, 54);
			this.lblCash.Name = "lblCash";
			this.lblCash.Size = new System.Drawing.Size(153, 30);
			this.lblCash.TabIndex = 4;
			this.lblCash.Text = "0";
			this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(807, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 15);
			this.label8.TabIndex = 16;
			this.label8.Text = "현금";
			// 
			// lblTotAmt
			// 
			this.lblTotAmt.BackColor = System.Drawing.Color.LightYellow;
			this.lblTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotAmt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblTotAmt.Location = new System.Drawing.Point(891, 14);
			this.lblTotAmt.Name = "lblTotAmt";
			this.lblTotAmt.Size = new System.Drawing.Size(153, 30);
			this.lblTotAmt.TabIndex = 3;
			this.lblTotAmt.Text = "0";
			this.lblTotAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.Location = new System.Drawing.Point(807, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 15);
			this.label9.TabIndex = 16;
			this.label9.Text = "합계금액";
			// 
			// lblNoAmt
			// 
			this.lblNoAmt.BackColor = System.Drawing.Color.LightYellow;
			this.lblNoAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNoAmt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblNoAmt.Location = new System.Drawing.Point(629, 14);
			this.lblNoAmt.Name = "lblNoAmt";
			this.lblNoAmt.Size = new System.Drawing.Size(153, 30);
			this.lblNoAmt.TabIndex = 2;
			this.lblNoAmt.Text = "0";
			this.lblNoAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(522, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 15);
			this.label7.TabIndex = 16;
			this.label7.Text = "면세금액(#)";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.LightYellow;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(345, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 30);
			this.label6.TabIndex = 1;
			this.label6.Text = "0";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblVatAmt
			// 
			this.lblVatAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblVatAmt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblVatAmt.Location = new System.Drawing.Point(352, 14);
			this.lblVatAmt.Name = "lblVatAmt";
			this.lblVatAmt.Size = new System.Drawing.Size(153, 30);
			this.lblVatAmt.TabIndex = 18;
			this.lblVatAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(284, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 15);
			this.label5.TabIndex = 16;
			this.label5.Text = "부가세";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.LightYellow;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(108, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 30);
			this.label3.TabIndex = 0;
			this.label3.Text = "0";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTaxAmt
			// 
			this.lblTaxAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTaxAmt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblTaxAmt.Location = new System.Drawing.Point(115, 14);
			this.lblTaxAmt.Name = "lblTaxAmt";
			this.lblTaxAmt.Size = new System.Drawing.Size(153, 30);
			this.lblTaxAmt.TabIndex = 18;
			this.lblTaxAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(12, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 15);
			this.label2.TabIndex = 16;
			this.label2.Text = "과세금액(t)";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblUserName);
			this.panel2.Controls.Add(this.cboCashier);
			this.panel2.Controls.Add(this.btnPrintView);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.dateTo);
			this.panel2.Controls.Add(this.dateFrom);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1084, 50);
			this.panel2.TabIndex = 12;
			// 
			// lblUserName
			// 
			this.lblUserName.BackColor = System.Drawing.SystemColors.Control;
			this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblUserName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblUserName.Location = new System.Drawing.Point(641, 13);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(136, 25);
			this.lblUserName.TabIndex = 20;
			this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cboCashier
			// 
			this.cboCashier.FormattingEnabled = true;
			this.cboCashier.Location = new System.Drawing.Point(451, 14);
			this.cboCashier.Name = "cboCashier";
			this.cboCashier.Size = new System.Drawing.Size(184, 23);
			this.cboCashier.TabIndex = 2;
			this.cboCashier.SelectedIndexChanged += new System.EventHandler(this.cboCashier_SelectedIndexChanged);
			this.cboCashier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCashier_KeyPress);
			// 
			// btnPrintView
			// 
			this.btnPrintView.BackColor = System.Drawing.Color.Orange;
			this.btnPrintView.Enabled = false;
			this.btnPrintView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnPrintView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintView.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnPrintView.ForeColor = System.Drawing.Color.White;
			this.btnPrintView.Location = new System.Drawing.Point(926, 6);
			this.btnPrintView.Name = "btnPrintView";
			this.btnPrintView.Size = new System.Drawing.Size(155, 40);
			this.btnPrintView.TabIndex = 4;
			this.btnPrintView.Text = "프린트 미리보기";
			this.btnPrintView.UseVisualStyleBackColor = false;
			this.btnPrintView.Click += new System.EventHandler(this.btnPrintView_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Orange;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(792, 7);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 40);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "조회";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(274, 17);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(18, 15);
			this.label10.TabIndex = 18;
			this.label10.Text = "~";
			// 
			// dateTo
			// 
			this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTo.Location = new System.Drawing.Point(298, 10);
			this.dateTo.Name = "dateTo";
			this.dateTo.Size = new System.Drawing.Size(136, 25);
			this.dateTo.TabIndex = 1;
			// 
			// dateFrom
			// 
			this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFrom.Location = new System.Drawing.Point(139, 10);
			this.dateFrom.Name = "dateFrom";
			this.dateFrom.Size = new System.Drawing.Size(129, 25);
			this.dateFrom.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(12, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 15);
			this.label4.TabIndex = 16;
			this.label4.Text = "판매일자(기간)";
			// 
			// frmSalesReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 642);
			this.ControlBox = false;
			this.Controls.Add(this.dataSales);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmSalesReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataSales;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.Label lblCard;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.Label lblCash;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label lblTotAmt;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label lblNoAmt;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label lblVatAmt;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label lblTaxAmt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnPrintView;
		public System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		public System.Windows.Forms.DateTimePicker dateFrom;
		public System.Windows.Forms.DateTimePicker dateTo;
		public System.Windows.Forms.ComboBox cboCashier;
	}
}