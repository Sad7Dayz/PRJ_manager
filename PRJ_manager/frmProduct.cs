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
	public partial class frmProduct : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;

		public frmProduct()
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());

			LoadData();
		}

		//브랜드정보
		public void LoadBrand()
		{
			cboBrand.Items.Clear();
			con.Open();

			sql = "Select brand from tblbrand";

			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				cboBrand.Items.Add(dr[0]);
			}
			dr.Close();
			con.Close();
		}


		//카테고리 정보 data Loading
		public void LoadCategory()
		{
			cboCategory.Items.Clear();
			con.Open();

			sql = "Select Category from tblCategory";

			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				cboCategory.Items.Add(dr[0]);
			}
			dr.Close();
			con.Close();
		}

		//화면 초기화
		public void ResetScreen()
		{
			txtPcode.Clear();
			txtPname.Clear();
			txtBarcode.Clear();
			cboBrand.Text ="";
			cboCategory.Text = "";
			txtPrice.Clear();
			chkNotax.Checked = false;
			txtMinQty.Clear();

			txtSearch.Clear();
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			pnlProduct.Visible = false;
			dataProduct.Enabled = true;
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void picAddData_Click(object sender, EventArgs e)
		{
			ResetScreen();

			//화면 전환
			dataProduct.Enabled = false;
			pnlProduct.Visible = true;
			pnlProduct.BringToFront();

			LoadBrand();
			LoadCategory();

			txtPcode.ReadOnly = false;

			btnSave.Enabled = true;
			btnUpdate.Enabled = false;
			btnCancel.Enabled = true;
		}

		//상품 정보 data Loading
		public void LoadData()
		{
			int i = 0;
			dataProduct.Rows.Clear();
			con.Open();

			sql = "Select p.pcode, p.barcode, p.pname, b.brand, c.category, p.price, p.notax, p.minQty from tblProduct AS p " +
				"Inner join tblBrand as b on b.id = p.bid " +
				"Inner join tblCategory as c on c.id = p.cid " +
				"Where p.pname like '" + txtSearch.Text + "%'";

			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dataProduct.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
			}
			con.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("상품 정보를 입력하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					string varBid = "";
					string varCid = "";
					string varNotax = "t";

					//브랜드 읽기
					con.Open();
					sql = "Select id from tblBrand Where brand = '" + cboBrand.Text + "'";
					cmd = new SqlCommand(sql, con);
					SqlDataReader dr = cmd.ExecuteReader();
					dr.Read();
					if (dr.HasRows)
					{
						varBid = dr[0].ToString();
					}

					dr.Close();
					con.Close();

					//브랜드 읽기
					con.Open();
					sql = "Select id from tblCategory Where Category = '" + cboCategory.Text + "'";
					cmd = new SqlCommand(sql, con);
					dr = cmd.ExecuteReader();
					dr.Read();
					if (dr.HasRows)
					{
						varCid = dr[0].ToString();
					}

					dr.Close();
					con.Close();

					if (chkNotax.Checked == true)
					{
						varNotax = "#";
					}

					//상품정보 insert
					con.Open();
					sql = "INSERT INTO tblProduct (pcode, barcode, pname, bid, cid, price, notax, minQty) VALUES (@pcode, @barcode, @pname, @bid, @cid, @price, @notax, @minQty)";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@pcode", txtPcode.Text);
					cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
					cmd.Parameters.AddWithValue("@pname", txtPname.Text);
					cmd.Parameters.AddWithValue("@bid", varBid);
					cmd.Parameters.AddWithValue("@cid", varCid);
					cmd.Parameters.AddWithValue("@price", txtPrice.Text);
					cmd.Parameters.AddWithValue("@notax", varNotax);
					cmd.Parameters.AddWithValue("@minQty", txtMinQty.Text);
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("상품 정보가 입력되었습니다.!", "확인!", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ResetScreen();
					LoadData();
					txtPcode.Focus();
				}
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("상품 정보를 입력하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					string varBid = "";
					string varCid = "";
					string varNotax = "t";

					//브랜드 읽기
					con.Open();
					sql = "Select id from tblBrand Where brand = '" + cboBrand.Text + "'";
					cmd = new SqlCommand(sql, con);
					SqlDataReader dr = cmd.ExecuteReader();
					dr.Read();
					if (dr.HasRows)
					{
						varBid = dr[0].ToString();
					}

					dr.Close();
					con.Close();

					//브랜드 읽기
					con.Open();
					sql = "Select id from tblCategory Where Category = '" + cboCategory.Text + "'";
					cmd = new SqlCommand(sql, con);
					dr = cmd.ExecuteReader();
					dr.Read();
					if (dr.HasRows)
					{
						varCid = dr[0].ToString();
					}

					dr.Close();
					con.Close();

					if (chkNotax.Checked == true)
					{
						varNotax = "#";
					}

					//상품정보 Update
					con.Open();
					sql = "Update tblProduct  Set barcode=@barcode, pname=@pname, bid=@bid, cid=@cid, price=@price, notax=@notax, minQty=@minQty where pcode=@pcode";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@pcode", txtPcode.Text);
					cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
					cmd.Parameters.AddWithValue("@pname", txtPname.Text);
					cmd.Parameters.AddWithValue("@bid", varBid);
					cmd.Parameters.AddWithValue("@cid", varCid);
					cmd.Parameters.AddWithValue("@price", txtPrice.Text);
					cmd.Parameters.AddWithValue("@notax", varNotax);
					cmd.Parameters.AddWithValue("@minQty", txtMinQty.Text);
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("상품 정보가 입력되었습니다.!", "확인!", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ResetScreen();
					LoadData();
				}
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ResetScreen();
			txtPcode.Focus();
		}

		private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string varNotax = "";
			string varPcode = "";

			string colName = dataProduct.Columns[e.ColumnIndex].Name;
			if (colName == "Edit")
			{
				pnlProduct.BringToFront();
				
				LoadBrand();
				LoadCategory();

				txtPcode.ReadOnly = true;

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				btnCancel.Enabled = false;

			
				txtPcode.Text = dataProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtBarcode.Text = dataProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtPname.Text = dataProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
				cboBrand.Text = dataProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
				cboCategory.Text = dataProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
				txtPrice.Text = dataProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
				varNotax = dataProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
				if (varNotax == "#")
				{
					chkNotax.Checked = true;
				}
				txtMinQty.Text = dataProduct.Rows[e.RowIndex].Cells[8].Value.ToString();

				//화면 전환
				pnlProduct.Visible = true;
				dataProduct.Enabled = true;

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				btnCancel.Enabled = false;
			}

			else if (colName == "Delete")
			{
				if (MessageBox.Show("선택한 상품 정보를 삭제하시겠습니까?", "정보삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();

					varPcode = dataProduct[1, e.RowIndex].Value.ToString();
					sql = "DELETE FROM tblProduct WHERE Pcode ='" + varPcode + "'";
					cmd = new SqlCommand(sql, con);
					cmd.ExecuteNonQuery();

					con.Close();

					MessageBox.Show("선택한 상품 정보가 삭제 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

					LoadData();
				}
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
