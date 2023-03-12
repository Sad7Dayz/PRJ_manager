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
	public partial class frmVendor : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;
		string varID;

		public frmVendor()
		{
			InitializeComponent();

			con = new SqlConnection(dbcon.posDBConnection());

			LoadData();
		}

		//공급자 정보 data Loading
		public void LoadData()
		{
			int i = 0;
			dataVendor.Rows.Clear();
			con.Open();
			sql = "Select * from tblVender ORDER By venName";

			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dataVendor.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
			}
			con.Close();
		}

		
		private void picClose_Click(object sender, EventArgs e)
		{
			pnlVendor.Visible = false;
			dataVendor.Enabled = true;
		}

		//데이터 추가 버튼
		private void picAddData_Click(object sender, EventArgs e)
		{
			ResetScreen();

			//화면 전환
			dataVendor.Enabled = false;
			pnlVendor.Visible = true;
			pnlVendor.BringToFront();

			btnSave.Enabled = true;
			btnUpdate.Enabled = false;
			btnCancel.Enabled = true;
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		//공급자 입력 Rtn
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("공급자 정보를 입력하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();
					sql = "INSERT INTO tblVender (venName, address, person, tel, fax, email) VALUES (@venName, @address, @person, @tel, @fax, @email)";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@venName", txtVenName.Text);
					cmd.Parameters.AddWithValue("@address", txtAddress.Text);
					cmd.Parameters.AddWithValue("@person", txtPerson.Text);
					cmd.Parameters.AddWithValue("@tel", txtTel.Text);
					cmd.Parameters.AddWithValue("@fax", txtFax.Text);
					cmd.Parameters.AddWithValue("@email", txtEmail.Text);
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("공급자 정보가 입력되었습니다.!", "확인!", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ResetScreen();
					LoadData();

					//화면 전환
					pnlVendor.Visible = false;
					dataVendor.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		

		//취소버튼
		private void btnCancel_Click(object sender, EventArgs e)
		{
			ResetScreen();
			txtVenName.Focus();
		}

		//화면 초기화
		public void ResetScreen()
		{
			txtVenName.Clear();
			txtAddress.Clear();
			txtPerson.Clear();
			txtTel.Clear();
			txtFax.Clear();
			txtEmail.Clear();
		}

		//공급자 정보 수정
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("공급자 정보를 수정하시겠습니까?", "수정", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();
					sql = "UPDATE tblVender SET venName=@venName, address=@address, person=@person, tel=@tel, fax=@fax, email=@email WHERE id=@id";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@venName", txtVenName.Text);
					cmd.Parameters.AddWithValue("@address", txtAddress.Text);
					cmd.Parameters.AddWithValue("@person", txtPerson.Text);
					cmd.Parameters.AddWithValue("@tel", txtTel.Text);
					cmd.Parameters.AddWithValue("@fax", txtFax.Text);
					cmd.Parameters.AddWithValue("@email", txtEmail.Text);
					cmd.Parameters.AddWithValue("@id", varID);
					cmd.ExecuteNonQuery();

					con.Close();

					MessageBox.Show("공급자 정보가 수정되었습니다.!", "확인!", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ResetScreen();
					LoadData();

					//화면 전환
					pnlVendor.Visible = false;
					dataVendor.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		//datavendor 클릭(수정pic/ 삭제pic)
		private void dataVendor_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataVendor.Columns[e.ColumnIndex].Name;
			if (colName =="Edit")
			{
				pnlVendor.BringToFront();

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				btnCancel.Enabled = false;

				varID = dataVendor[1, e.RowIndex].Value.ToString();
				txtVenName.Text = dataVendor.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtAddress.Text = dataVendor.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtPerson.Text = dataVendor.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtTel.Text = dataVendor.Rows[e.RowIndex].Cells[5].Value.ToString();
				txtFax.Text = dataVendor.Rows[e.RowIndex].Cells[6].Value.ToString();
				txtEmail.Text = dataVendor.Rows[e.RowIndex].Cells[7].Value.ToString();

				//화면 전환
				pnlVendor.Visible = true;
				dataVendor.Enabled = true;

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				btnCancel.Enabled = false;
			}

			else if (colName == "Delete")
			{
				if (MessageBox.Show("선택한 공급자 정보를 삭제하시겠습니까?", "정보삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();

					varID = dataVendor[1, e.RowIndex].Value.ToString();
					sql = "DELETE FROM tblVender WHERE id ='" + varID + "'";
					cmd = new SqlCommand(sql, con);
					cmd.ExecuteNonQuery();

					con.Close();

					MessageBox.Show("선택한 공급자 정보가 삭제 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

					LoadData();
				}
			}
		}
	}		
}			
			
			