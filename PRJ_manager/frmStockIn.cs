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
	public partial class frmStockIn : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;

		string _id; //Key 변수
		int _qty = 0; //입고(재고)수량

		public frmStockIn()
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());

			LoadVendor();
		}

		//상품 리스트 조회/선택
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmProductList frm = new frmProductList(this); //상품입고정보를 매개체로
			frm.ShowDialog();
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		//전표번호 생성 - Random
		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//년월일no (yyyymmdd1000)형식으로 생성
			string _date = DateTime.Now.ToString("yyyyMMdd");
			Random rnd = new Random();
			int num = rnd.Next(1, 9999);

			txtRefno.Clear();
			txtRefno.Text += _date + num.ToString();
		}


		//공급자 정보 loading
		public void LoadVendor()
		{
			cboVendor.Items.Clear();
			con.Open();
			sql = "select * from tblVender";
			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				cboVendor.Items.Add(dr[1].ToString());
			}

			dr.Close();
			con.Close();
		}

		//공급자 클릭(선택) Data Display
		private void cboVendor_TextChanged(object sender, EventArgs e)
		{
			con.Open();

			sql = "Select * from tblVender Where venName = '" + cboVendor.Text + "'";
			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();
			dr.Read();
			if (dr.HasRows)
			{
				lblVendorID.Text = dr[0].ToString(); //id
				txtPerson.Text = dr[3].ToString(); //담당자
				txtAddress.Text = dr[2].ToString(); //주소
			}
			con.Close();
		}

		//전표번호는 숫자(0-9)로만 처리한다.
		private void txtRefno_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48) || (e.KeyChar > 57)) //ascii code [0-9]
			{
				e.Handled = true;
			}
		}

		//상품 정보 data Loading
		public void LoadStockIn()
		{
			int i = 0;
			dataStockIn.Rows.Clear();
			con.Open();

			sql = "Select s.id, s.inRefno, v.venName, s.pcode, p.pname, s.qty, s.sdate from tblStockin AS s " +
				"Inner join tblVender As v On v.id = s.vendorId " +
				"Inner join tblProduct as p on p.pcode = s.pcode where s.inRefno like '" + txtRefno.Text + "' And status = '보류'";

			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dataStockIn.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
			}
			con.Close();
		}

		private void dataStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataStockIn.Columns[e.ColumnIndex].Name;
			if (colName == "Delete")
			{
				if (MessageBox.Show("선택한 상품을 삭제 하시겠습니까?", "상품삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();
					_id = dataStockIn.Rows[e.RowIndex].Cells[1].Value.ToString();

					sql = "Delete from tblStockIn where id = '" + _id + "'";
					cmd = new SqlCommand(sql, con);
					cmd.ExecuteNonQuery();

					con.Close();

					MessageBox.Show("선택한 상품을 삭제했습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadStockIn();
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataStockIn.Rows.Count > 0)
				{
					for (int i = 0; i < dataStockIn.Rows.Count; i++)
					{

						//update 상품테이블(tblProduct) 수량(qty)
						con.Open();

						_qty = int.Parse(dataStockIn.Rows[i].Cells[6].Value.ToString()); //수량
						_id = dataStockIn.Rows[i].Cells[4].Value.ToString(); //상품코드
						
						sql = "Update tblProduct Set qty = qty + " + _qty + " where pcode = '" + _id + "' ";
						cmd = new SqlCommand(sql, con);
						cmd.ExecuteNonQuery();

						con.Close();


						//update 상품테이블(tblStockin) 수량(qty)
						con.Open();

						_qty = int.Parse(dataStockIn.Rows[i].Cells[6].Value.ToString()); //수량
						_id = dataStockIn.Rows[i].Cells[1].Value.ToString(); //입고Id

						sql = "Update tblStockIn Set qty = qty + " + _qty + " ,status = '입고' " + " where id = '" +_id+ "' ";
						cmd = new SqlCommand(sql, con);
						cmd.ExecuteNonQuery();

						con.Close();
					}

					LoadStockIn();
					ResetScreen();

				}

			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ResetScreen()
		{
			txtRefno.Clear();
			txtManager.Clear();
			dtSdate.Value = DateTime.Now;
			cboVendor.Text = "";
			txtPerson.Clear();
			txtAddress.Clear();

			txtRefno.Focus();
		}

		private void btnQuery_Click(object sender, EventArgs e)
		{
			LoadStockInList();
		}

		//기간별 상품입고현황 loading
		private void LoadStockInList()
		{
			int i = 0;
			dataStockInList.Rows.Clear();
			con.Open();

			//id, 전표번호, 공급자, 상품코드, 상품명, 수량, 입고일자
			sql = "Select s.id, s.inRefno, v.venName, s.pcode, p.pname, s.qty, s.sdate as date, s.manager from tblStockin AS s " +
				"Inner join tblVender As v On v.id = s.vendorId " +
				"Inner join tblProduct as p on p.pcode = s.pcode " +
				" where cast(s.sdate as date) between '" + dtFrom.Value.ToShortDateString() + "' AND '" + dtTo.Value.ToShortDateString() + 
				"' And status = '입고'";

			cmd = new SqlCommand(sql,con);

			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dataStockInList.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
			}
			dr.Close();
			con.Close();
		}
	}
}
