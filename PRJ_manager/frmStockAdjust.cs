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
	public partial class frmStockAdjust : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		string sql;
		int _qty;

		mdiManage _mdi;


		public frmStockAdjust(mdiManage _pmdi)
		{
			InitializeComponent();

			con = new SqlConnection(dbcon.posDBConnection());

			LoadProduct();
			ReferenceNo();
			this._mdi = _pmdi;

			txtUserId.Text = _mdi._userid;
		}

		//상품정보 loading (재고 수량 조정)
		private void LoadProduct()
		{
			int i = 0;
			dataProduct.Rows.Clear();

			con.Open();
			sql = "select p.pcode, p.barcode, p.pname, b.brand, category, price, qty from tblProduct as p " +
				   "inner join tblBrand as b on b.id = p.bid " +
				   "inner join tblCategory as c on c.id = p.cid where p.pname like '" + txtSearch.Text + "%' ";
			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				i++;
				dataProduct.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
			}
			dr.Close();
			con.Close();

		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				//입력 재고 수량 체크	
				if (int.Parse(txtQty.Text) > _qty)
				{
					MessageBox.Show("조정 수량은 재고 수량보다 적어야합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				//재고 수량 상품 정보에서 삭제
				if (cboAction.Text == "재고삭제")
				{
					sql = "Update  tblProduct set qty = (qty - @qty) where pcode = @pcode";
					SqlProdutUpdate(sql);
				}

				else if (cboAction.Text == "재고 추가")
				{
					sql = "Update  tblProduct set qty = (qty + @qty) where pcode = @pcode";
					SqlProdutUpdate(sql);
				}

				//재고 조정 정보 DataTable
				sql = "Insert into tblStockAdjust(inRefno, pcode, qty, action, remarks, userid, sdate) values (@inRefno, @pcode, @qty, @action, @remarks, @userid, @sdate)";
				SqlStockAdjustInsert(sql);

				MessageBox.Show("재고 조정 정보가 입력 되었습니다.!", "재고조정", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadProduct();
				ResetScreen();
			}
			catch (Exception ex)
			{
				con.Close();
				; MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		//화면 초기화
		private void ResetScreen()
		{
			txtRefno.Clear();
			txtPcode.Clear();
			txtPname.Clear();
			txtQty.Clear();
			cboAction.Text = "";
			txtRemark.Clear();
			//txtUserId.Clear();
		}

		//재고 조정 정보 Data Insert
		private void SqlStockAdjustInsert(string _sql)
		{
			con.Open();

			cmd = new SqlCommand(_sql, con);
			cmd.Parameters.AddWithValue("@inRefno", txtRefno.Text);
			cmd.Parameters.AddWithValue("@pcode", txtPcode.Text);
			cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
			cmd.Parameters.AddWithValue("@action", cboAction.Text);
			cmd.Parameters.AddWithValue("@remarks", txtRemark.Text);
			cmd.Parameters.AddWithValue("@userid", txtUserId.Text);
			cmd.Parameters.AddWithValue("@sdate", DateTime.Now.ToShortDateString());

			cmd.ExecuteNonQuery();

			con.Close();
		}

		//재고 수량 Update
		private void SqlProdutUpdate(string _sql)
		{
			con.Open();

			cmd = new SqlCommand(_sql, con);
			cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
			cmd.Parameters.AddWithValue("@pcode", txtPcode.Text);
			cmd.ExecuteNonQuery();

			con.Close();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadProduct();
		}

		//전표번호 생성
		private void ReferenceNo()
		{
			//년월일no (yyyymmdd1000)형식으로 생성
			string _date = DateTime.Now.ToString("yyyyMMdd");
			Random rnd = new Random();
			int num = rnd.Next(1, 9999);

			txtRefno.Clear();
			txtRefno.Text += _date + num.ToString();
		}

		//상품 선택 Datagridview 클릭
		private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataProduct.Columns[e.ColumnIndex].Name;
			if (colName == "Select")
			{
				txtPcode.Text = dataProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtPname.Text = dataProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
				_qty = int.Parse(dataProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
			}
		}
	}
}
