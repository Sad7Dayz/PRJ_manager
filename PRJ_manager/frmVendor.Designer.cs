
namespace PRJ_manager
{
	partial class frmVendor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendor));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picAddData = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlVendor = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPerson = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtVenName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataVendor = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
			this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAddData)).BeginInit();
			this.pnlVendor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataVendor)).BeginInit();
			this.SuspendLayout();
			// 
			// picExit
			// 
			this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
			this.picExit.Location = new System.Drawing.Point(1225, 0);
			this.picExit.Name = "picExit";
			this.picExit.Size = new System.Drawing.Size(60, 48);
			this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picExit.TabIndex = 1;
			this.picExit.TabStop = false;
			this.picExit.Click += new System.EventHandler(this.picExit_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Green;
			this.panel1.Controls.Add(this.picAddData);
			this.panel1.Controls.Add(this.picExit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1285, 48);
			this.panel1.TabIndex = 1;
			// 
			// picAddData
			// 
			this.picAddData.Dock = System.Windows.Forms.DockStyle.Right;
			this.picAddData.Image = ((System.Drawing.Image)(resources.GetObject("picAddData.Image")));
			this.picAddData.Location = new System.Drawing.Point(1165, 0);
			this.picAddData.Name = "picAddData";
			this.picAddData.Size = new System.Drawing.Size(60, 48);
			this.picAddData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picAddData.TabIndex = 2;
			this.picAddData.TabStop = false;
			this.picAddData.Click += new System.EventHandler(this.picAddData_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Teal;
			this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "공급자 정보";
			// 
			// pnlVendor
			// 
			this.pnlVendor.Controls.Add(this.btnCancel);
			this.pnlVendor.Controls.Add(this.btnSave);
			this.pnlVendor.Controls.Add(this.btnUpdate);
			this.pnlVendor.Controls.Add(this.picClose);
			this.pnlVendor.Controls.Add(this.txtEmail);
			this.pnlVendor.Controls.Add(this.label7);
			this.pnlVendor.Controls.Add(this.txtFax);
			this.pnlVendor.Controls.Add(this.label6);
			this.pnlVendor.Controls.Add(this.txtTel);
			this.pnlVendor.Controls.Add(this.label5);
			this.pnlVendor.Controls.Add(this.txtAddress);
			this.pnlVendor.Controls.Add(this.txtPerson);
			this.pnlVendor.Controls.Add(this.label3);
			this.pnlVendor.Controls.Add(this.label4);
			this.pnlVendor.Controls.Add(this.txtVenName);
			this.pnlVendor.Controls.Add(this.label2);
			this.pnlVendor.Location = new System.Drawing.Point(292, 112);
			this.pnlVendor.Name = "pnlVendor";
			this.pnlVendor.Size = new System.Drawing.Size(716, 302);
			this.pnlVendor.TabIndex = 2;
			this.pnlVendor.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Gray;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(515, 225);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(128, 40);
			this.btnCancel.TabIndex = 8;
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
			this.btnSave.Location = new System.Drawing.Point(247, 225);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 40);
			this.btnSave.TabIndex = 6;
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
			this.btnUpdate.Location = new System.Drawing.Point(381, 225);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(128, 40);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "수정";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// picClose
			// 
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(681, 3);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(32, 28);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picClose.TabIndex = 7;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(144, 185);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(499, 25);
			this.txtEmail.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(10, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 17);
			this.label7.TabIndex = 3;
			this.label7.Text = "이메일(Email)";
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(144, 154);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(499, 25);
			this.txtFax.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(10, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "팩스(Fax)";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(144, 123);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(499, 25);
			this.txtTel.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(10, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "전화번호";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(144, 61);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(499, 25);
			this.txtAddress.TabIndex = 1;
			// 
			// txtPerson
			// 
			this.txtPerson.Location = new System.Drawing.Point(144, 92);
			this.txtPerson.Name = "txtPerson";
			this.txtPerson.Size = new System.Drawing.Size(499, 25);
			this.txtPerson.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(10, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "주소";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(10, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "담당자";
			// 
			// txtVenName
			// 
			this.txtVenName.Location = new System.Drawing.Point(144, 30);
			this.txtVenName.Name = "txtVenName";
			this.txtVenName.Size = new System.Drawing.Size(499, 25);
			this.txtVenName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(10, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "공급자상호";
			// 
			// dataVendor
			// 
			this.dataVendor.AllowUserToAddRows = false;
			this.dataVendor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataVendor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataVendor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataVendor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataVendor.ColumnHeadersHeight = 30;
			this.dataVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Edit,
            this.Delete});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataVendor.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataVendor.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataVendor.EnableHeadersVisualStyles = false;
			this.dataVendor.Location = new System.Drawing.Point(0, 48);
			this.dataVendor.Name = "dataVendor";
			this.dataVendor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataVendor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataVendor.RowHeadersVisible = false;
			this.dataVendor.RowHeadersWidth = 51;
			this.dataVendor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataVendor.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
			this.dataVendor.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dataVendor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
			this.dataVendor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.dataVendor.RowTemplate.Height = 27;
			this.dataVendor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataVendor.Size = new System.Drawing.Size(1285, 343);
			this.dataVendor.TabIndex = 3;
			this.dataVendor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataVendor_CellContentClick);
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
			this.Column2.HeaderText = "ID";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Visible = false;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "공급자상호";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column4.HeaderText = "주소";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 71;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column5.HeaderText = "담당자";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 89;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column6.HeaderText = "전화번호";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 107;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column7.HeaderText = "팩스(Fax)";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 115;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column8.HeaderText = "이메일(Email)";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 146;
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
			// frmVendor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1285, 476);
			this.ControlBox = false;
			this.Controls.Add(this.dataVendor);
			this.Controls.Add(this.pnlVendor);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmVendor";
			this.Text = "frmVendor";
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAddData)).EndInit();
			this.pnlVendor.ResumeLayout(false);
			this.pnlVendor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataVendor)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picAddData;
		private System.Windows.Forms.Panel pnlVendor;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPerson;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtVenName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGridView dataVendor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewImageColumn Edit;
		private System.Windows.Forms.DataGridViewImageColumn Delete;
	}
}