using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_manager
{
	public partial class mdiManage : Form
	{
		int count = 0;
		int len = 0;
		string txtDisplay;

		public string _userid, _password, _job, _userName;

		public mdiManage()
		{
			InitializeComponent();
			
			NeonSign();
		}


		private void NeonSign()
		{
			lblUser.Text = _job + "/" + _userid + "/" + _userName;
			//len = txtDisplay.Length;
			//timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			count++;

			if (count > len)
			{
				count = 0;
				txtDisplay = lblUser.Text;
				lblUser.Text = "";
			}
			else
			{
				lblUser.Text = txtDisplay.Substring(0, count);
				//color 입히기
				if (lblUser.ForeColor == Color.Black)
				{
					lblUser.ForeColor = Color.White;
				}
				else
				{
					lblUser.ForeColor = Color.Black;
				}
			}
		}

		private void 로그아웃XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("로그아웃 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				//timer1.Stop();
				this.Dispose();
				frmLogin_M frm = new frmLogin_M();
				frm.ShowDialog();
			}
		}

		private void 매장정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmStore frm = new frmStore();
			frm.ShowDialog();

		}

		private void 공급자정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmVendor frm = new frmVendor();
			frm.ShowDialog();
		}

		private void 브랜드정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBrand frm = new frmBrand();
			frm.ShowDialog();
		}

		private void 카테고리정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCategory frm = new frmCategory();
			frm.ShowDialog();
		}
		
		private void 재고조정정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmStockAdjust frm = new frmStockAdjust(this);

			frm.ShowDialog();
		}

		private void 판매현황ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmSalesReport frm = new frmSalesReport();
			frm.ShowDialog();
		}

		private void 각종현황ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmVariousReports frm = new frmVariousReports();
			frm.ShowDialog();
		}

		private void pOS현황판EToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPosBoard frm = new frmPosBoard();
			frm.ShowDialog();
		}

		//상품 정보
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			frmProduct frm = new frmProduct();
			frm.ShowDialog();
		}

		//상품 입고 정보
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			frmStockIn frm = new frmStockIn();
			frm.ShowDialog();
		}

		//재고 조정 정보
		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			frmSalesReport frm = new frmSalesReport();
			frm.ShowDialog();
		}

		//판매 현황
		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			frmVariousReports frm = new frmVariousReports();
			frm.ShowDialog();
		}

		//각종 현황
		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			frmVariousReports frm = new frmVariousReports();
			frm.ShowDialog();
		}

		private void 상품정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmProduct frm = new frmProduct();
			frm.ShowDialog();
		}

		private void 상품입고정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmStockIn frm = new frmStockIn();
			frm.ShowDialog();
		}

		private void 사용자계정ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUser frm = new frmUser(this);
			frm.txtCUserID.Text = _userid;
			frm.ShowDialog();
		}
	}
}

