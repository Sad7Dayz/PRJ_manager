using Microsoft.Reporting.WinForms;
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
	public partial class frmPrintView : Form
	{
		SqlConnection con;
		//SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		string sql;

		public frmPrintView()
		{
			InitializeComponent();

			con = new SqlConnection(dbcon.posDBConnection());
		}

		private void frmPrintView_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
		}

		//상품 재고 현황
		public void LoadStockReport()
		{
			try
			{
				ReportDataSource rptDs;
				this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report.rdlc";
				this.reportViewer1.LocalReport.DataSources.Clear();

				DataSet ds = new DataSet();
				SqlDataAdapter da = new SqlDataAdapter();

				con.Open();
				sql = "select P.pcode, P.barcode, P.pname, B.brand, C.category, P.price, P.minQty, P.qty from tblProduct As P " +
					"Inner join tblBrand as B On B.id = P.bid Inner join tblCategory As C On C.id = P.cid";

				da.SelectCommand = new SqlCommand(sql, con);
				da.Fill(ds.Tables["dtStock"]);

				con.Close();

				rptDs = new ReportDataSource("DataSet1", ds.Tables["dtStock"]);
				reportViewer1.LocalReport.DataSources.Add(rptDs);
				reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
				reportViewer1.ZoomMode = ZoomMode.Percent;
				reportViewer1.ZoomPercent = 100;
			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		//경고 재고상품 프린터(주문할 상품 현황)
		public void LoadWarnStockReport()
		{
			try
			{
				ReportDataSource rptDs;
				this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report.rdlc";
				this.reportViewer1.LocalReport.DataSources.Clear();

				DataSet ds = new DataSet();
				SqlDataAdapter da = new SqlDataAdapter();

				con.Open();
				sql = "select P.pcode, P.barcode, P.pname, B.brand, C.category, P.price, P.minQty, P.qty from tblProduct As P " +
					"Inner join tblBrand as B On B.id = P.bid Inner join tblCategory As C On C.id = P.cid where P.qty <=P.minQty";

				da.SelectCommand = new SqlCommand(sql, con);
				da.Fill(ds.Tables["dtStock"]);

				con.Close();

				ReportParameter pStockTitle = new ReportParameter("pStockTitle", "재고 경고 상품 현황");
				reportViewer1.LocalReport.SetParameters(pStockTitle);

				rptDs = new ReportDataSource("DataSet1", ds.Tables["dtStock"]);
				reportViewer1.LocalReport.DataSources.Add(rptDs);
				reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
				reportViewer1.ZoomMode = ZoomMode.Percent;
				reportViewer1.ZoomPercent = 100;
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
