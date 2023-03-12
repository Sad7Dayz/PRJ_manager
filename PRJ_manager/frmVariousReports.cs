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
using System.Windows.Forms.DataVisualization.Charting;

namespace PRJ_manager
{
	public partial class frmVariousReports : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		string sql;

		public frmVariousReports()
		{
			InitializeComponent();

			con = new SqlConnection(dbcon.posDBConnection());
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnInquiry_Click(object sender, EventArgs e)
		{
			if (cboSelect.Text == string.Empty)
			{
				MessageBox.Show("조회할 옵션(수량, 금액)을 선택 하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			LoadTop10Data();
			LoadSoldTop10Chart();
		}
		
		//판매 Top 10 현황
		private void LoadTop10Data()
		{
			try
			{
				dataSales.Rows.Clear();
				int i = 0;
				con.Open();

				if (cboSelect.Text == "수량")
				{
					sql = "Select top 10 pcode, pname, isnull(sum(qty),0) as qty, isnull(sum(saleAmt),0) as saleAmt from vwSoldTop10 " +
						"where sdate between @dateFrom and @dateTo and status = '판매' Group by pcode, pname order by qty DESC";
				}
				else if (cboSelect.Text == "금액")
				{
					sql = "Select top 10 pcode, pname, isnull(sum(qty),0) as qty, isnull(sum(saleAmt),0) as saleAmt from vwSoldTop10 " +
						"where sdate between @dateFrom and @dateTo and status = '판매' Group by pcode, pname order by saleAmt DESC";
				}

				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@dateFrom", dateFrom.Value.ToShortDateString());
				cmd.Parameters.AddWithValue("@dateTo", dateTo.Value.ToShortDateString());
				SqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					i++;
					dataSales.Rows.Add(i, dr[0], dr[1], dr[2], dr[3]);
				}
				dr.Close();
				con.Close();
			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		//판매 top 10
		public void LoadSoldTop10Chart()
		{
			con.Open();

			if (cboSelect.Text == "수량")
			{
				sql = "Select top 10 pname, isnull(sum(qty),0) as qty from vwSoldTop10 " +
					"where sdate between '" + dateFrom.Value.ToShortDateString() + "' and '" + dateTo.Value.ToShortDateString() + "' and status = '판매' Group by pcode, pname order by qty DESC";
			}
			else if (cboSelect.Text == "금액")
			{
				sql = "Select top 10 pname, isnull(sum(saleAmt),0) as saleAmt from vwSoldTop10 " +
					"where sdate between '" + dateFrom.Value.ToShortDateString() + "' and '" + dateTo.Value.ToShortDateString() + "' and status = '판매' Group by pcode, pname order by saleAmt DESC";
			}

			SqlDataAdapter da = new SqlDataAdapter(sql, con);
			DataSet ds = new DataSet();
			da.Fill(ds, "TOPSOLD");
			chart1.DataSource = ds.Tables["TOPSOLD"];
			Series series = chart1.Series[0];
			series.ChartType = SeriesChartType.Doughnut;

			series.Name = "판매 TOP 10";
			var chart = chart1;
			chart.Series[0].XValueMember = "pname";
			if (cboSelect.Text == "수량")
			{
				chart.Series[0].YValueMembers = "qty";
			}

			else if (cboSelect.Text == "금액")
			{
				chart.Series[0].YValueMembers = "saleAmt";
			}

			chart.Series[0].IsValueShownAsLabel = true;
			if (cboSelect.Text == "수량")
			{
				chart.Series[0].LabelFormat = "{#,##0}";
			}

			else if (cboSelect.Text == "금액")
			{
				chart.Series[0].LabelFormat = "{#,###, ##0}";
			}

			con.Close();
		}

		//상품 재고 현황 조회
		private void btnInquiry2_Click(object sender, EventArgs e)
		{
			try
			{
				dataStock.Rows.Clear();
				int i = 0;

				con.Open();
				
				sql = "select P.pcode, P.barcode, P.pname, B.brand, C.category, P.price, P.minQty, P.qty from tblProduct As P " +
					"Inner join tblBrand as B On B.id = P.bid Inner join tblCategory As C On C.id = P.cid";
				cmd = new SqlCommand(sql, con);
				SqlDataReader dr = cmd.ExecuteReader();

				if (dr.Read())
				{
					i++;
					dataStock.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
				}
				dr.Close();
				con.Close();
			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		//상품 재고 현황 프린트
		private void btnPrint2_Click(object sender, EventArgs e)
		{
			frmPrintView frm = new frmPrintView();
			frm.LoadStockReport();
			frm.ShowDialog();
		}

		//재고 경고상품 현황 조회
		private void btnInquiry3_Click(object sender, EventArgs e)
		{
			try
			{
				datawWarnStock.Rows.Clear();
				int i = 0;

				con.Open();

				sql = "select P.pcode, P.barcode, P.pname, B.brand, C.category, P.price, P.minQty, P.qty from tblProduct As P " +
					"Inner join tblBrand as B On B.id = P.bid Inner join tblCategory As C On C.id = P.cid where P.qty <= p.minQty"; //현 재고 수량 <= 최소 재소수량
				cmd = new SqlCommand(sql, con);
				SqlDataReader dr = cmd.ExecuteReader();

				if (dr.Read())
				{
					i++;
					datawWarnStock.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
				}
				dr.Close();
				con.Close();
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


		//재고 경고상품 형황 프린트
		private void btnPrint3_Click(object sender, EventArgs e)
		{
			frmPrintView frm = new frmPrintView();
			frm.LoadWarnStockReport();
			frm.ShowDialog();
		}
	}
}
