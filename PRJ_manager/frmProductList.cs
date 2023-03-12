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
	public partial class frmProductList : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;

		string _id; //참조 Key 변수
		//int qty = 0; //입고 수량

		//상품입고정보 참조
		frmStockIn _stockin;

		public frmProductList(frmStockIn _pstockin) //상품입고정보를 매개체로 불러옴
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());

			_stockin = _pstockin;

			LoadProduct();
		}

		//상품정보 loading
		private void LoadProduct()
		{
			int i = 0;
			dataProduct.Rows.Clear();

			con.Open();

			sql = "select pcode, pname, qty from tblProduct where pname like '%" + txtSearch.Text + "%' order by pname";
			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				i++;
				dataProduct.Rows.Add(i, dr[0], dr[1], dr[2]);
			}
			con.Close();
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataProduct.Columns[e.ColumnIndex].Name;
			if (colName == "Select")
			{
				if (_stockin.txtRefno.Text == string.Empty)
				{
					MessageBox.Show("전표번호를 생성(입력)하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_stockin.txtRefno.Focus();
					return;
				}
				if (_stockin.txtManager.Text == string.Empty)
				{
					MessageBox.Show("상품입고 관리자를 입력하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_stockin.txtManager.Focus();
					return;
				}
				if (_stockin.cboVendor.Text == string.Empty)
				{
					MessageBox.Show("상품 공급자를 입력하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_stockin.cboVendor.Focus();
					return;
				}

				if (MessageBox.Show("선택한 상품을 입고 하겠습니까?", "입고처리", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					_id = dataProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
					con.Open();

					//전표번호, 상품코드, 입고일자, 관리자, 공급자ID
					sql = "Insert into tblStockin(inRefno, pcode, sdate, manager, vendorId) values (@inRefno, @pcode, @sdate, @manager, @vendorId)";
					
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@inRefno", _stockin.txtRefno.Text);
					cmd.Parameters.AddWithValue("@pcode", _id);
					cmd.Parameters.AddWithValue("@sdate", _stockin.dtSdate.Value.ToShortDateString());
					cmd.Parameters.AddWithValue("@manager", _stockin.txtManager.Text);
					cmd.Parameters.AddWithValue("@vendorId", _stockin.lblVendorID.Text);
					cmd.ExecuteNonQuery();

					con.Close();

					MessageBox.Show("입고상품이 등록 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

					_stockin.LoadStockIn();
				}
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadProduct();
		}
	}
}
