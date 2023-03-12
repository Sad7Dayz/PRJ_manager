namespace PRJ_manager
{
	partial class mdiManage
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiManage));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.기본정보관리AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자계정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.공급자정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.매장정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.상품정보관리BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.상품정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.브랜드정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.카테고리정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.재고정보관리CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.상품입고정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.재고조정정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.판매정보현황DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.판매현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.각종현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pOS현황판EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.로그아웃XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblUser);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1072, 48);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(24, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "POS 시스템 관리자 COM";
			// 
			// lblUser
			// 
			this.lblUser.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblUser.ForeColor = System.Drawing.Color.Yellow;
			this.lblUser.Location = new System.Drawing.Point(605, 15);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(464, 21);
			this.lblUser.TabIndex = 4;
			this.lblUser.Text = "사용자";
			this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.menuStrip1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1072, 32);
			this.panel2.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기본정보관리AToolStripMenuItem,
            this.상품정보관리BToolStripMenuItem,
            this.재고정보관리CToolStripMenuItem,
            this.판매정보현황DToolStripMenuItem,
            this.pOS현황판EToolStripMenuItem,
            this.로그아웃XToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1072, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 기본정보관리AToolStripMenuItem
			// 
			this.기본정보관리AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자계정ToolStripMenuItem,
            this.공급자정보ToolStripMenuItem,
            this.매장정보ToolStripMenuItem});
			this.기본정보관리AToolStripMenuItem.Name = "기본정보관리AToolStripMenuItem";
			this.기본정보관리AToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
			this.기본정보관리AToolStripMenuItem.Text = "기본정보관리(&A)";
			// 
			// 사용자계정ToolStripMenuItem
			// 
			this.사용자계정ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("사용자계정ToolStripMenuItem.Image")));
			this.사용자계정ToolStripMenuItem.Name = "사용자계정ToolStripMenuItem";
			this.사용자계정ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
			this.사용자계정ToolStripMenuItem.Text = "사용자계정";
			this.사용자계정ToolStripMenuItem.Click += new System.EventHandler(this.사용자계정ToolStripMenuItem_Click);
			// 
			// 공급자정보ToolStripMenuItem
			// 
			this.공급자정보ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("공급자정보ToolStripMenuItem.Image")));
			this.공급자정보ToolStripMenuItem.Name = "공급자정보ToolStripMenuItem";
			this.공급자정보ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
			this.공급자정보ToolStripMenuItem.Text = "공급자정보";
			this.공급자정보ToolStripMenuItem.Click += new System.EventHandler(this.공급자정보ToolStripMenuItem_Click);
			// 
			// 매장정보ToolStripMenuItem
			// 
			this.매장정보ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("매장정보ToolStripMenuItem.Image")));
			this.매장정보ToolStripMenuItem.Name = "매장정보ToolStripMenuItem";
			this.매장정보ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
			this.매장정보ToolStripMenuItem.Text = "사업장정보";
			this.매장정보ToolStripMenuItem.Click += new System.EventHandler(this.매장정보ToolStripMenuItem_Click);
			// 
			// 상품정보관리BToolStripMenuItem
			// 
			this.상품정보관리BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품정보ToolStripMenuItem,
            this.브랜드정보ToolStripMenuItem,
            this.카테고리정보ToolStripMenuItem});
			this.상품정보관리BToolStripMenuItem.Name = "상품정보관리BToolStripMenuItem";
			this.상품정보관리BToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
			this.상품정보관리BToolStripMenuItem.Text = "상품정보관리(&B)";
			// 
			// 상품정보ToolStripMenuItem
			// 
			this.상품정보ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("상품정보ToolStripMenuItem.Image")));
			this.상품정보ToolStripMenuItem.Name = "상품정보ToolStripMenuItem";
			this.상품정보ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
			this.상품정보ToolStripMenuItem.Text = "상품정보";
			this.상품정보ToolStripMenuItem.Click += new System.EventHandler(this.상품정보ToolStripMenuItem_Click);
			// 
			// 브랜드정보ToolStripMenuItem
			// 
			this.브랜드정보ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("브랜드정보ToolStripMenuItem.Image")));
			this.브랜드정보ToolStripMenuItem.Name = "브랜드정보ToolStripMenuItem";
			this.브랜드정보ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
			this.브랜드정보ToolStripMenuItem.Text = "브랜드정보";
			this.브랜드정보ToolStripMenuItem.Click += new System.EventHandler(this.브랜드정보ToolStripMenuItem_Click);
			// 
			// 카테고리정보ToolStripMenuItem
			// 
			this.카테고리정보ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("카테고리정보ToolStripMenuItem.Image")));
			this.카테고리정보ToolStripMenuItem.Name = "카테고리정보ToolStripMenuItem";
			this.카테고리정보ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
			this.카테고리정보ToolStripMenuItem.Text = "카테고리정보";
			this.카테고리정보ToolStripMenuItem.Click += new System.EventHandler(this.카테고리정보ToolStripMenuItem_Click);
			// 
			// 재고정보관리CToolStripMenuItem
			// 
			this.재고정보관리CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품입고정보ToolStripMenuItem,
            this.재고조정정보ToolStripMenuItem});
			this.재고정보관리CToolStripMenuItem.Name = "재고정보관리CToolStripMenuItem";
			this.재고정보관리CToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
			this.재고정보관리CToolStripMenuItem.Text = "재고정보관리(&C)";
			// 
			// 상품입고정보ToolStripMenuItem
			// 
			this.상품입고정보ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("상품입고정보ToolStripMenuItem.Image")));
			this.상품입고정보ToolStripMenuItem.Name = "상품입고정보ToolStripMenuItem";
			this.상품입고정보ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
			this.상품입고정보ToolStripMenuItem.Text = "상품입고정보";
			this.상품입고정보ToolStripMenuItem.Click += new System.EventHandler(this.상품입고정보ToolStripMenuItem_Click);
			// 
			// 재고조정정보ToolStripMenuItem
			// 
			this.재고조정정보ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("재고조정정보ToolStripMenuItem.Image")));
			this.재고조정정보ToolStripMenuItem.Name = "재고조정정보ToolStripMenuItem";
			this.재고조정정보ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
			this.재고조정정보ToolStripMenuItem.Text = "재고조정정보";
			this.재고조정정보ToolStripMenuItem.Click += new System.EventHandler(this.재고조정정보ToolStripMenuItem_Click);
			// 
			// 판매정보현황DToolStripMenuItem
			// 
			this.판매정보현황DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.판매현황ToolStripMenuItem,
            this.각종현황ToolStripMenuItem});
			this.판매정보현황DToolStripMenuItem.Name = "판매정보현황DToolStripMenuItem";
			this.판매정보현황DToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
			this.판매정보현황DToolStripMenuItem.Text = "판매정보현황(&D)";
			// 
			// 판매현황ToolStripMenuItem
			// 
			this.판매현황ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("판매현황ToolStripMenuItem.Image")));
			this.판매현황ToolStripMenuItem.Name = "판매현황ToolStripMenuItem";
			this.판매현황ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.판매현황ToolStripMenuItem.Text = "판매현황";
			this.판매현황ToolStripMenuItem.Click += new System.EventHandler(this.판매현황ToolStripMenuItem_Click);
			// 
			// 각종현황ToolStripMenuItem
			// 
			this.각종현황ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("각종현황ToolStripMenuItem.Image")));
			this.각종현황ToolStripMenuItem.Name = "각종현황ToolStripMenuItem";
			this.각종현황ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.각종현황ToolStripMenuItem.Text = "각종현황";
			this.각종현황ToolStripMenuItem.Click += new System.EventHandler(this.각종현황ToolStripMenuItem_Click);
			// 
			// pOS현황판EToolStripMenuItem
			// 
			this.pOS현황판EToolStripMenuItem.Name = "pOS현황판EToolStripMenuItem";
			this.pOS현황판EToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
			this.pOS현황판EToolStripMenuItem.Text = "POS현황판(&E)";
			this.pOS현황판EToolStripMenuItem.Click += new System.EventHandler(this.pOS현황판EToolStripMenuItem_Click);
			// 
			// 로그아웃XToolStripMenuItem
			// 
			this.로그아웃XToolStripMenuItem.Name = "로그아웃XToolStripMenuItem";
			this.로그아웃XToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
			this.로그아웃XToolStripMenuItem.Text = "로그아웃(&X)";
			this.로그아웃XToolStripMenuItem.Click += new System.EventHandler(this.로그아웃XToolStripMenuItem_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 80);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1072, 33);
			this.panel3.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1072, 57);
			this.panel5.TabIndex = 3;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.toolStrip1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1072, 32);
			this.panel6.TabIndex = 3;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1072, 27);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton4.Text = "toolStripButton4";
			this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton5.Text = "toolStripButton5";
			this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// mdiManage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1072, 568);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "mdiManage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmManage";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 기본정보관리AToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 사용자계정ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 공급자정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 매장정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 상품정보관리BToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 상품정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 브랜드정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 카테고리정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 재고정보관리CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 상품입고정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 재고조정정보ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 판매정보현황DToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 판매현황ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 각종현황ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pOS현황판EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 로그아웃XToolStripMenuItem;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.Label lblUser;
	}
}