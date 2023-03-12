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
	public partial class frmPosBoard : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;

		public frmPosBoard()
		{
			InitializeComponent();

			con = new SqlConnection(dbcon.posDBConnection());

			LoadDailySalesAmt();
			LoadSalesProduct();
			LoadWarnProduct();
			LoadYearSalesChart();
		}

		//년도별 판매 차트
		private void LoadYearSalesChart()
		{
			con.Open();

			sql = "select Year(sdate) as YEAR, isnull(sum(saleAmt), 0) as Total from tblSales where status = '판매' group by Year(sdate)";
			SqlDataAdapter da = new SqlDataAdapter(sql, con);
			DataSet ds = new DataSet();

			da.Fill(ds, "Sales");
			chart1.DataSource = ds.Tables["Sales"];
			Series series1 = chart1.Series["Series1"];
			series1.ChartType = SeriesChartType.Doughnut;

			series1.Name = "년도별 판매 금액";

			var chart = chart1;
			chart.Series[series1.Name].XValueMember = "YEAR";
			chart.Series[series1.Name].YValueMembers = "TOTAL";
			chart.Series[0].IsValueShownAsLabel = true;

			con.Close();
		}

		//재고 경고 상품수
		public void LoadWarnProduct()
		{
			int _warnProduct;
			con.Open();
			sql = "Select count(*) from tblProduct where qty <= minQty";
			cmd = new SqlCommand(sql, con);
			_warnProduct = int.Parse(cmd.ExecuteScalar().ToString());
			lblWarnProduct.Text = _warnProduct.ToString("##,##0");
			con.Close();
		}

		public void LoadDailySalesAmt()
		{
			string _sdate = DateTime.Now.ToShortDateString();
			int _dailySaleAmt;

			con.Open();

			sql = "select ISNULL(SUM(saleAmt), 0) as total from tblSales where sdate = '" + _sdate+ "' and status = '판매'";
			cmd = new SqlCommand(sql, con);
			_dailySaleAmt = int.Parse(cmd.ExecuteScalar().ToString());
			lblSaleAmt.Text = _dailySaleAmt.ToString("##,###,##0");

			con.Close();
		}

		//판매 상품수 Data Load
		public void LoadSalesProduct()
		{
			int _salProduct;

			con.Open();

			sql = "Select count(*) from tblProduct";
			cmd = new SqlCommand(sql, con);
			_salProduct = int.Parse(cmd.ExecuteScalar().ToString());
			lblSalesProduct.Text = _salProduct.ToString("##,##0");

			con.Close();
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
