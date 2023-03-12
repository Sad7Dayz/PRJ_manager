
namespace PRJ_manager
{
	partial class frmPosPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosPassword));
			this.panel1 = new System.Windows.Forms.Panel();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnChange = new System.Windows.Forms.Button();
			this.txtConPassword = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNewpassword = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Orange;
			this.panel1.Controls.Add(this.picExit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(583, 48);
			this.panel1.TabIndex = 6;
			// 
			// picExit
			// 
			this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
			this.picExit.Location = new System.Drawing.Point(523, 0);
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
			this.label1.Size = new System.Drawing.Size(143, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "비밀번호 변경";
			// 
			// btnChange
			// 
			this.btnChange.BackColor = System.Drawing.Color.Green;
			this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChange.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnChange.ForeColor = System.Drawing.Color.White;
			this.btnChange.Location = new System.Drawing.Point(200, 190);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(314, 42);
			this.btnChange.TabIndex = 17;
			this.btnChange.Text = "변경";
			this.btnChange.UseVisualStyleBackColor = false;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// txtConPassword
			// 
			this.txtConPassword.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtConPassword.Location = new System.Drawing.Point(200, 145);
			this.txtConPassword.Name = "txtConPassword";
			this.txtConPassword.PasswordChar = '*';
			this.txtConPassword.Size = new System.Drawing.Size(314, 27);
			this.txtConPassword.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(50, 155);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 17);
			this.label7.TabIndex = 18;
			this.label7.Text = "새 비밀번호 확인";
			// 
			// txtNewpassword
			// 
			this.txtNewpassword.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtNewpassword.Location = new System.Drawing.Point(200, 112);
			this.txtNewpassword.Name = "txtNewpassword";
			this.txtNewpassword.PasswordChar = '*';
			this.txtNewpassword.Size = new System.Drawing.Size(314, 27);
			this.txtNewpassword.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.Location = new System.Drawing.Point(71, 122);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 17);
			this.label9.TabIndex = 19;
			this.label9.Text = "새 비밀번호";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtPassword.Location = new System.Drawing.Point(200, 79);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(314, 27);
			this.txtPassword.TabIndex = 14;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(62, 89);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(122, 17);
			this.label10.TabIndex = 20;
			this.label10.Text = "현재 비밀번호";
			// 
			// frmPosPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 263);
			this.ControlBox = false;
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.txtConPassword);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtNewpassword);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmPosPassword";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.TextBox txtConPassword;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNewpassword;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label10;
	}
}