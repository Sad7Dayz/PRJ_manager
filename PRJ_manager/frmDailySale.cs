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
	public partial class frmDailySale : Form
	{

		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		string sql;
		string _sdate;
		string _userid;

		frmPos _pos;

		public frmDailySale(frmPos frm)
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());

			_sdate = DateTime.Now.ToString("yyyyMMdd");

			lblSdate.Text = DateTime.Now.ToLongDateString();


			_pos = frm;
			lblUserName.Text = _pos.lblUserName.Text;
			_userid = _pos.lblUserID.Text;

			LoadDataSales();
		}

		public void LoadDataSales()
		{
			int i = 0;
			dataSales.Rows.Clear();


			int _taxAmt = 0;    // 과세상품 금액 합계
			double _vatAmt = 0; // 부가세 합계
			int _noAmt = 0;     // 면세상품 금액 합계
			double _totAmt = 0; // 합계

			double _cash = 0; //현금
			double _card = 0; //카드
			double _vat = 0;  //부가세

			con.Open();

			sql = "select s.id, s.transno, s.pcode, p.pname, s.price, s.qty, s.saleamt, p.notax, s.payment from tblSales As s Inner join tblProduct as p On p.pcode = s.pcode " +
				"where s.status = '판매' and s.sdate = '" + _sdate + "' and s.userid = '" + _userid + "' "; ;

			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				i += 1;
				i++;

				if (dr["notax"].ToString() == "t") //부가세 상품이면
				{
					_taxAmt += int.Parse(dr["saleAmt"].ToString());
					_vatAmt += int.Parse(dr["saleAmt"].ToString()) * 0.1; //부가세 10%

					if (dr["payment"].ToString() == "현금")
					{
						_cash += int.Parse(dr["saleAmt"].ToString());
						_vat = int.Parse(dr["saleAmt"].ToString()) * 0.1;
						_cash += _vat;
					}
					else
					{
						_card += int.Parse(dr["saleAmt"].ToString());
						_vat = int.Parse(dr["saleAmt"].ToString()) * 0.1;
						_card += _vat;
					}

				}
				else // 면세 "#"
				{
					_noAmt += int.Parse(dr["saleAmt"].ToString());

					if (dr["payment"].ToString() == "현금")
					{
						_cash += int.Parse(dr["saleAmt"].ToString()); ;
					}
					else
					{
						_card += int.Parse(dr["saleAmt"].ToString()); ;
					}
				}

			

				dataSales.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8]);

			}

			_totAmt = _taxAmt + _vatAmt + _noAmt;

			dr.Close();
			con.Close();

			lblTaxAmt.Text = _taxAmt.ToString("#,###,##0 ");
			lblVatAmt.Text = _vatAmt.ToString("#,###,##0 ");
			lblNoAmt.Text = _noAmt.ToString("#,###,##0 ");
			lblTotAmt.Text = _totAmt.ToString("#,###,##0 ");

			lblCash.Text = _cash.ToString("#,###,##0 ");
			lblCard.Text = _card.ToString("#,###,##0 ");

		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
