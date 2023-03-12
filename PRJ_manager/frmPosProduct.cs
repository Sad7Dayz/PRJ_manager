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
	public partial class frmPosProduct : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;

		frmPos _frm;

		string _transno; //거래No
		string _pcode;	 //상품코드
		int _price;		 //가격
		int _qty;		 //재고

		public frmPosProduct(frmPos frm)
		{
			InitializeComponent();

			con = new SqlConnection(dbcon.posDBConnection());

			LoadProduct();

			_frm = frm;
			this.KeyPreview = true;
		}

		private void LoadProduct()
		{
			int i = 0;
			dataProduct.Rows.Clear();

			con.Open();

			sql = "select pcode, barcode, pname, price, qty from tblProduct where pcode like '" + txtSearch.Text + "%' "; ;
			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				i++;
				dataProduct.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4]);
			}
			dr.Close();
			con.Close();
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadProduct();
		}

		//상품 select
		private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataProduct.Columns[e.ColumnIndex].Name;
			if (colName == "colSelect")
			{
				_transno = _frm.lblTransno.Text;
				_pcode = dataProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
				_price = int.Parse(dataProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
				_qty = int.Parse(dataProduct.Rows[e.RowIndex].Cells[5].Value.ToString());

				txtSearch.Enabled = false;
				dataProduct.Enabled = false;
				pnlQty.Visible = true;

				txtQty.Focus();
			}
		}

		//key control
		private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Esc Key
			if (e.KeyChar == 27)
			{
				ResetScreen();
			}

			//Esc Key
			if (e.KeyChar == 8)
			{
				//ResetScreen();
			}

			//Ascii code 48 ~ 57 -> 0 ~ 9, 8 -> BackSpace
			if ((e.KeyChar < 48) || (e.KeyChar > 57) || (e.KeyChar == 8))
			{
				e.Handled = true;
			}

			//Enter Key
			if ((e.KeyChar == 13) && (txtQty.Text != string.Empty))
			{
				string id = "";
				int cart_qty = 0;
				bool found = false;

				con.Open();

				sql = "select * from tblSales where transno = @transno and pcode = @pcode";
				cmd = new SqlCommand(sql, con);
				//cmd.Parameters.AddWithValue("@transno", _frm.lblTransno.Text);
				cmd.Parameters.AddWithValue("@transno", _transno);
				cmd.Parameters.AddWithValue("@pcode", _pcode);
				SqlDataReader dr = cmd.ExecuteReader();
				dr.Read();

				if (dr.HasRows)
				{
					found = true;
					id = dr["id"].ToString();
					cart_qty = int.Parse(dr["qty"].ToString()) + cart_qty;

					//saleAmt -> 트리거 comSaleAmt 적용
				}
				else
				{
					found = false;
				}

				dr.Close();
				con.Close();

				if (found == true)
				{
					//재고 수량이 입력 받은 (수량 + 기입력된 수량)보다 작으면
					if (_qty < int.Parse(txtQty.Text) + cart_qty)
					{
						MessageBox.Show("재고 수량이 부족합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					con.Open();

					sql = "update tblSales set by qty = qty + @qty where id = @id";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@id", id);
					cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
					//saleAmt -> 트리거 comSaleAmt 적용
					cmd.ExecuteNonQuery();

					con.Close();
					ResetScreen();
				}
				else
				{
					//재고 수량이 입력 받은 수량보다 작으면
					if (_qty < int.Parse(txtQty.Text))
					{
						MessageBox.Show("재고 수량이 부족합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					con.Open();
					
					sql = "Insert into tblSales (transno, pcode, price, qty, sdate, userid) VALUES (@transno, @pcode, @price, @qty, @sdate, @userid)";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@transno", _transno);
					cmd.Parameters.AddWithValue("@pcode", _pcode);
					cmd.Parameters.AddWithValue("@price", _price);
					cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
					cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
					cmd.Parameters.AddWithValue("@userid", _frm.lblUserID.Text);
					cmd.ExecuteNonQuery();

					con.Close();
					ResetScreen();
				}
			}
		}
		//화면 초기화
		private void ResetScreen()
		{
			txtSearch.Enabled = true;
			dataProduct.Enabled = true;
			pnlQty.Visible = false;

			_frm.txtBarcode.Clear();
			_frm.txtBarcode.Focus();
			_frm.LoadToCart();
			this.Dispose();
		}
	}
}
