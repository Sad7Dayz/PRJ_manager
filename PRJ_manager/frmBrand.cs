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
	public partial class frmBrand : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;
		string varID;

		public frmBrand()
		{
			InitializeComponent();

			con = new SqlConnection(dbcon.posDBConnection());

			LoadData();
		}


		//공급자 정보 data Loading
		public void LoadData()
		{
			int i = 0;
			dataBrand.Rows.Clear();
			con.Open();
			sql = "Select * from tblBrand ORDER By Brand";

			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dataBrand.Rows.Add(i, dr[0], dr[1]);
			}
			con.Close();
		}

		private void picAddData_Click(object sender, EventArgs e)
		{
			ResetScreen();

			//화면 전환
			dataBrand.Enabled = false;
			pnlBrand.Visible = true;
			pnlBrand.BringToFront();

			btnSave.Enabled = true;
			btnUpdate.Enabled = false;
			btnCancel.Enabled = true;


			//pnlBrand.Visible = false;
			//dataBrand.Enabled = true;
		}

		//화면 초기화
		public void ResetScreen()
		{
			txtBrand.Clear();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("브랜드 정보를 입력하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();
					sql = "INSERT INTO tblBrand (Brand) VALUES (@Brand)";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
					
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("브랜드 정보가 입력되었습니다.!", "확인!", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ResetScreen();
					LoadData();

					//화면 전환
					pnlBrand.Visible = false;
					dataBrand.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		//브랜드 수정 Rtn
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("브랜드 정보를 수정하시겠습니까?", "수정", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();
					sql = "UPDATE tblBrand SET Brand = @Brand Where id = @id";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
					cmd.Parameters.AddWithValue("@id", varID);
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("브랜드 정보가 수정되었습니다.!", "확인!", MessageBoxButtons.OK, MessageBoxIcon.Information);


					ResetScreen();
					LoadData();

					//화면 전환
					pnlBrand.Visible = false;
					dataBrand.Enabled = true;
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
			txtBrand.Focus();
		}

		private void dataBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataBrand.Columns[e.ColumnIndex].Name;
			if (colName == "Edit")
			{
				pnlBrand.BringToFront();

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				btnCancel.Enabled = false;

				varID = dataBrand[1, e.RowIndex].Value.ToString();
				txtBrand.Text = dataBrand.Rows[e.RowIndex].Cells[2].Value.ToString();
		

				//화면 전환
				pnlBrand.Visible = true;
				dataBrand.Enabled = false;

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				btnCancel.Enabled = false;
			}

			else if (colName == "Delete")
			{
				if (MessageBox.Show("선택한 브랜드 정보를 삭제하시겠습니까?", "정보삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();

					varID = dataBrand[1, e.RowIndex].Value.ToString();

					sql = "DELETE FROM tblBrand WHERE id ='" + varID + "'";
					cmd = new SqlCommand(sql, con);
					cmd.ExecuteNonQuery();

					con.Close();

					MessageBox.Show("선택한 브랜드 정보가 삭제 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

					LoadData();
				}
			}
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			pnlBrand.Visible = false;
			dataBrand.Enabled = true;
		}
	}
}
