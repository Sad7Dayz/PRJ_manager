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
	public partial class frmSalesReportPrint : Form
	{
		SqlConnection con;
		//SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		frmSalesReport _frm;
		string sql;

		public frmSalesReportPrint(frmSalesReport frm)
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());
			_frm = frm;

			LoadReport();
		}

		private void LoadReport()
		{
			try
			{
				ReportDataSource rptDs;
				this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SalesReport.rdlc";
				this.reportViewer1.LocalReport.DataSources.Clear();

				DataSet1 ds = new DataSet1();
				SqlDataAdapter da = new SqlDataAdapter();

				con.Open();

				if (_frm.lblUserName.Text == "")
				{
					sql = "select S.id, S.transno, S.pcode, S.pname, S.price, S.qty, S.saleAmt, P.notax from tblSales as S Inner Join tblProduct as P on S.pcode = P.pcode where S.status = '판매' and S.sdate between '" + _frm.dateFrom.Value.ToShortDateString() + "' and '" + _frm.dateTo.Value.ToShortDateString() + "' ";
				}
				else
				{
					sql = "select S.id, S.transno, S.pcode, S.pname, S.price, S.qty, S.saleAmt, P.notax from tblSales as S Inner Join tblProduct as P on S.pcode = P.pcode where S.status = '판매' and S.sdate between '" + _frm.dateFrom.Value.ToShortDateString() + "' and '" + _frm.dateTo.Value.ToShortDateString() + "' and userid = '" + _frm.cboCashier.Text + "' ";
				}

				da.SelectCommand = new SqlCommand(sql, con);
				da.Fill(ds.Tables["dtSalesReport"]);
				con.Close();

				ReportParameter pDate = new ReportParameter("pDate", "판매일자 : " + _frm.dateFrom.Value.ToShortDateString() + "~" + _frm.dateTo.Value.ToShortDateString());
				ReportParameter pCashier = new ReportParameter("pCashier", "판매자 : " + _frm.lblUserName.Text);
				
				ReportParameter pTaxAmt = new ReportParameter("pTaxAmt", "과세금액(t) : " + _frm.lblTaxAmt.Text);
				ReportParameter pVatAmt = new ReportParameter("pVatAmt", "부가세 : " + _frm.lblVatAmt.Text);
				ReportParameter pNoAmt = new ReportParameter("pNoAmt",   "면세금액(t) : " + _frm.lblNoAmt.Text);
				ReportParameter pTotAmt = new ReportParameter("pTotAmt", "합계금액(t) : " + _frm.lblTotAmt.Text);
				ReportParameter pCash = new ReportParameter("pCash",     "	   	현금 : " + _frm.lblCash.Text);
				ReportParameter pCard = new ReportParameter("pCard",     "		카드 : " + _frm.lblCard.Text);

				reportViewer1.LocalReport.SetParameters(pDate);
				reportViewer1.LocalReport.SetParameters(pCashier);

				reportViewer1.LocalReport.SetParameters(pTaxAmt);
				reportViewer1.LocalReport.SetParameters(pVatAmt);
				reportViewer1.LocalReport.SetParameters(pNoAmt);
				reportViewer1.LocalReport.SetParameters(pTotAmt);
				reportViewer1.LocalReport.SetParameters(pCash);
				reportViewer1.LocalReport.SetParameters(pCard);

				rptDs = new ReportDataSource("DataSet1", ds.Tables["dtSalesReport"]);

				reportViewer1.LocalReport.DataSources.Add(rptDs);
				reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
				reportViewer1.ZoomMode = ZoomMode.Percent;
				reportViewer1.ZoomPercent = 100;


			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message);
			}
		}

		private void frmSalesReportPrint_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
		}
	}
}
