using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
	public partial class frmReciept : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;

		frmPos _frm;

		public frmReciept(frmPos frm)
		{
			InitializeComponent();

			con = new SqlConnection(dbcon.posDBConnection());

			LoadReport();

			_frm = frm;
		}

		public void LoadReport()
		{
			ReportDataSource rptDataSource;
			try
			{
				this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Reciept.rdlc";
				this.reportViewer1.LocalReport.DataSources.Clear();

				DataSet1 ds = new DataSet1();
				SqlDataAdapter da = new SqlDataAdapter();

				//사업자 정보
				con.Open();
				sql = "select * from tblStore";
				cmd = new SqlCommand(sql, con);
				SqlDataReader dr = cmd.ExecuteReader();

				string _bizname = "";    //사업자명
				string _biznumber = "";  //사업자번호
				string _owner = "";      //대표자
				string _address = "";    //주소
				string _tel = "";        //전화번호

				dr.Read();
				if (dr.HasRows)
				{
					_bizname = dr[0].ToString();    //사업자명
					_biznumber = dr[1].ToString();  //사업자번호
					_owner = dr[2].ToString();      //대표자
					_address = dr[3].ToString();    //주소
					_tel = dr[4].ToString();        //전화번호
				}

				con.Close();


				//판매정보 -> Dataset(dtSold)
				con.Open();
				sql = "select S.id, S.transno, S.pcode, S.price, S.qty, S.saleAmt, S.payment, S.status, S.pname, S.notax from tblSales As S Inner join tblProduct As P On S.pcode = P.pcode where transno = '" + _frm.lblTransno.Text + "' ";
				da.SelectCommand = new SqlCommand(sql, con);
				da.Fill(ds.Tables["dtSold"]);
				con.Close();

				ReportParameter pBizName = new ReportParameter("pBizName", _bizname);
				ReportParameter pBiznumber = new ReportParameter("pBiznumber", _biznumber);
				ReportParameter pOwner = new ReportParameter("pOwner", _owner);
				ReportParameter pAddress = new ReportParameter("pAddress", _address);
				ReportParameter pTel = new ReportParameter("pTel", _tel);
				
				
				ReportParameter pUserName = new ReportParameter("pUserName", _frm.lblUserName.Text);

				ReportParameter pTaxAmt = new ReportParameter("pTaxAmt", _frm.lblTaxAmt.Text);
				ReportParameter pVatAmt = new ReportParameter("pVatAmt", _frm.lblVatAmt.Text);
				ReportParameter pNoAmt = new ReportParameter("pNoAmt", _frm.lblNoAmt.Text);
				ReportParameter pTotAmt = new ReportParameter("pTotAmt", _frm.lblTotAmt.Text);
				ReportParameter pAmount = new ReportParameter("pAmount", _frm.txtAmount.Text);
				ReportParameter pChange = new ReportParameter("pChange", _frm.lblChange.Text);

				reportViewer1.LocalReport.SetParameters(pBizName);
				reportViewer1.LocalReport.SetParameters(pBiznumber);
				reportViewer1.LocalReport.SetParameters(pOwner);
				reportViewer1.LocalReport.SetParameters(pAddress);
				reportViewer1.LocalReport.SetParameters(pTel);

				reportViewer1.LocalReport.SetParameters(pUserName);
				
				reportViewer1.LocalReport.SetParameters(pTaxAmt);
				reportViewer1.LocalReport.SetParameters(pVatAmt);
				reportViewer1.LocalReport.SetParameters(pNoAmt);
				reportViewer1.LocalReport.SetParameters(pTotAmt);
				reportViewer1.LocalReport.SetParameters(pAmount);
				reportViewer1.LocalReport.SetParameters(pChange);

				rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtSold"]);
				reportViewer1.LocalReport.DataSources.Add(rptDataSource);
				reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

				reportViewer1.ZoomMode = ZoomMode.Percent;
				reportViewer1.ZoomPercent = 90;
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message);
			}
		}
	}
}
