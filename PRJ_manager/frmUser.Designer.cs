
namespace PRJ_manager
{
	partial class frmUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
			this.panel1 = new System.Windows.Forms.Panel();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.cboJob = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtRePassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.txtCRePassword = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCNewpassword = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCPassword = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCUserID = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.chkPermit = new System.Windows.Forms.CheckBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtPUser = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(643, 48);
			this.panel1.TabIndex = 3;
			// 
			// picExit
			// 
			this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
			this.picExit.Location = new System.Drawing.Point(583, 0);
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
			this.label1.Size = new System.Drawing.Size(172, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "사용자 계정 정보";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tabControl1.Location = new System.Drawing.Point(0, 48);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(643, 339);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cboJob);
			this.tabPage1.Controls.Add(this.btnCancel);
			this.tabPage1.Controls.Add(this.btnSave);
			this.tabPage1.Controls.Add(this.txtUserName);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.txtRePassword);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.txtPassword);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txtUserID);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(635, 308);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "[계정 등록]";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// cboJob
			// 
			this.cboJob.FormattingEnabled = true;
			this.cboJob.Items.AddRange(new object[] {
            "관리자",
            "계산원"});
			this.cboJob.Location = new System.Drawing.Point(225, 139);
			this.cboJob.Name = "cboJob";
			this.cboJob.Size = new System.Drawing.Size(314, 25);
			this.cboJob.TabIndex = 3;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Gray;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(416, 217);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(128, 40);
			this.btnCancel.TabIndex = 6;
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
			this.btnSave.Location = new System.Drawing.Point(282, 217);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 40);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "저장";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(225, 171);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(314, 27);
			this.txtUserName.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(98, 181);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "이름";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(98, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "직무";
			// 
			// txtRePassword
			// 
			this.txtRePassword.Location = new System.Drawing.Point(225, 105);
			this.txtRePassword.Name = "txtRePassword";
			this.txtRePassword.PasswordChar = '*';
			this.txtRePassword.Size = new System.Drawing.Size(314, 27);
			this.txtRePassword.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "비밀번호 확인";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(225, 72);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(314, 27);
			this.txtPassword.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "비밀번호";
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(225, 39);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(314, 27);
			this.txtUserID.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(79, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "사용자 ID";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.btnChange);
			this.tabPage2.Controls.Add(this.txtCRePassword);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.txtCNewpassword);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.txtCPassword);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.txtCUserID);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(635, 308);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "[비밀번호 변경]";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gray;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(404, 191);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 40);
			this.button1.TabIndex = 5;
			this.button1.Text = "취소";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btnChange
			// 
			this.btnChange.BackColor = System.Drawing.Color.Orange;
			this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChange.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnChange.ForeColor = System.Drawing.Color.White;
			this.btnChange.Location = new System.Drawing.Point(270, 191);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(128, 40);
			this.btnChange.TabIndex = 4;
			this.btnChange.Text = "변경";
			this.btnChange.UseVisualStyleBackColor = false;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// txtCRePassword
			// 
			this.txtCRePassword.Location = new System.Drawing.Point(221, 146);
			this.txtCRePassword.Name = "txtCRePassword";
			this.txtCRePassword.PasswordChar = '*';
			this.txtCRePassword.Size = new System.Drawing.Size(314, 27);
			this.txtCRePassword.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(71, 156);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "새 비밀번호 확인";
			// 
			// txtCNewpassword
			// 
			this.txtCNewpassword.Location = new System.Drawing.Point(221, 113);
			this.txtCNewpassword.Name = "txtCNewpassword";
			this.txtCNewpassword.PasswordChar = '*';
			this.txtCNewpassword.Size = new System.Drawing.Size(314, 27);
			this.txtCNewpassword.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(92, 123);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 17);
			this.label9.TabIndex = 12;
			this.label9.Text = "새 비밀번호";
			// 
			// txtCPassword
			// 
			this.txtCPassword.Location = new System.Drawing.Point(221, 80);
			this.txtCPassword.Name = "txtCPassword";
			this.txtCPassword.PasswordChar = '*';
			this.txtCPassword.Size = new System.Drawing.Size(314, 27);
			this.txtCPassword.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(83, 90);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(122, 17);
			this.label10.TabIndex = 13;
			this.label10.Text = "현재 비밀번호";
			// 
			// txtCUserID
			// 
			this.txtCUserID.Location = new System.Drawing.Point(221, 47);
			this.txtCUserID.Name = "txtCUserID";
			this.txtCUserID.Size = new System.Drawing.Size(314, 27);
			this.txtCUserID.TabIndex = 0;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(103, 57);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(83, 17);
			this.label11.TabIndex = 14;
			this.label11.Text = "사용자 ID";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.chkPermit);
			this.tabPage3.Controls.Add(this.btnOk);
			this.tabPage3.Controls.Add(this.txtPUser);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Location = new System.Drawing.Point(4, 27);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(635, 308);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "[사용 인증]";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// chkPermit
			// 
			this.chkPermit.AutoSize = true;
			this.chkPermit.Location = new System.Drawing.Point(226, 133);
			this.chkPermit.Name = "chkPermit";
			this.chkPermit.Size = new System.Drawing.Size(102, 21);
			this.chkPermit.TabIndex = 1;
			this.chkPermit.Text = "사용허가";
			this.chkPermit.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.Orange;
			this.btnOk.Enabled = false;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(412, 172);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(128, 40);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "확인";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtPUser
			// 
			this.txtPUser.Location = new System.Drawing.Point(227, 79);
			this.txtPUser.Name = "txtPUser";
			this.txtPUser.Size = new System.Drawing.Size(314, 27);
			this.txtPUser.TabIndex = 0;
			this.txtPUser.TextChanged += new System.EventHandler(this.txtPUser_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(76, 89);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 17);
			this.label8.TabIndex = 21;
			this.label8.Text = "사용자 ID";
			// 
			// frmUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 387);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmUser";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtRePassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cboJob;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.TextBox txtCRePassword;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCNewpassword;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCPassword;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtPUser;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox chkPermit;
		public System.Windows.Forms.TextBox txtCUserID;
	}
}