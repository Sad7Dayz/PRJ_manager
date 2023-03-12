
namespace PRJ_manager
{
	partial class frmBrand
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrand));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picAddData = new System.Windows.Forms.PictureBox();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataBrand = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
			this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
			this.pnlBrand = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.txtBrand = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAddData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBrand)).BeginInit();
			this.pnlBrand.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			this.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(769, 48);
			this.panel1.TabIndex = 2;
			// 
			// picAddData
			// 
			this.picAddData.Dock = System.Windows.Forms.DockStyle.Right;
			this.picAddData.Image = ((System.Drawing.Image)(resources.GetObject("picAddData.Image")));
			this.picAddData.Location = new System.Drawing.Point(649, 0);
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
			this.picExit.Location = new System.Drawing.Point(709, 0);
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
			this.label1.Size = new System.Drawing.Size(122, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "브랜드 정보";
			// 
			// dataBrand
			// 
			this.dataBrand.AllowUserToAddRows = false;
			this.dataBrand.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataBrand.ColumnHeadersHeight = 30;
			this.dataBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataBrand.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataBrand.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataBrand.EnableHeadersVisualStyles = false;
			this.dataBrand.Location = new System.Drawing.Point(0, 48);
			this.dataBrand.Name = "dataBrand";
			this.dataBrand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataBrand.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataBrand.RowHeadersVisible = false;
			this.dataBrand.RowHeadersWidth = 51;
			this.dataBrand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataBrand.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
			this.dataBrand.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.dataBrand.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
			this.dataBrand.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.dataBrand.RowTemplate.Height = 27;
			this.dataBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataBrand.Size = new System.Drawing.Size(769, 209);
			this.dataBrand.TabIndex = 4;
			this.dataBrand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBrand_CellContentClick);
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
			this.Column3.HeaderText = "브랜드";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
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
			// pnlBrand
			// 
			this.pnlBrand.Controls.Add(this.btnCancel);
			this.pnlBrand.Controls.Add(this.btnSave);
			this.pnlBrand.Controls.Add(this.btnUpdate);
			this.pnlBrand.Controls.Add(this.picClose);
			this.pnlBrand.Controls.Add(this.txtBrand);
			this.pnlBrand.Controls.Add(this.label2);
			this.pnlBrand.Location = new System.Drawing.Point(29, 252);
			this.pnlBrand.Name = "pnlBrand";
			this.pnlBrand.Size = new System.Drawing.Size(680, 125);
			this.pnlBrand.TabIndex = 5;
			this.pnlBrand.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Gray;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(513, 70);
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
			this.btnSave.Location = new System.Drawing.Point(245, 70);
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
			this.btnUpdate.Location = new System.Drawing.Point(379, 70);
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
			this.picClose.Location = new System.Drawing.Point(646, 0);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(32, 28);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picClose.TabIndex = 7;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// txtBrand
			// 
			this.txtBrand.Location = new System.Drawing.Point(144, 36);
			this.txtBrand.Name = "txtBrand";
			this.txtBrand.Size = new System.Drawing.Size(499, 25);
			this.txtBrand.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(10, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "브랜드 명";
			// 
			// frmBrand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 389);
			this.ControlBox = false;
			this.Controls.Add(this.pnlBrand);
			this.Controls.Add(this.dataBrand);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmBrand";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAddData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBrand)).EndInit();
			this.pnlBrand.ResumeLayout(false);
			this.pnlBrand.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picAddData;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataBrand;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewImageColumn Edit;
		private System.Windows.Forms.DataGridViewImageColumn Delete;
		private System.Windows.Forms.Panel pnlBrand;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.TextBox txtBrand;
		private System.Windows.Forms.Label label2;
	}
}