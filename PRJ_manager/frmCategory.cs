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
	public partial class frmCategory : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;
		string varID;

		public frmCategory()
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());

			LoadData();
		}

		//공급자 정보 data Loading
		public void LoadData()
		{
			int i = 0;
			dataCategory.Rows.Clear();
			con.Open();
			sql = "Select * from tblCategory ORDER By Category";

			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				i++;
				dataCategory.Rows.Add(i, dr[0], dr[1]);
			}
			con.Close();
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void picAddData_Click(object sender, EventArgs e)
		{
			ResetScreen();

			//화면 전환
			dataCategory.Enabled = false;
			pnlCategory.Visible = true;
			pnlCategory.BringToFront();

			btnSave.Enabled = true;
			btnUpdate.Enabled = false;
			btnCancel.Enabled = true;
		}

		//화면 초기화
		public void ResetScreen()
		{
			txtCategory.Clear();
		}

		private void picClose_Click(object sender, EventArgs e)
		{
			pnlCategory.Visible = false;
			dataCategory.Enabled = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("카테고리 정보를 입력하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();
					sql = "INSERT INTO tblCategory (Category) VALUES (@Category)";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@Category", txtCategory.Text);

					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("카테고리 정보가 입력되었습니다.!", "확인!", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ResetScreen();
					LoadData();

					//화면 전환
					pnlCategory.Visible = false;
					dataCategory.Enabled = false;
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
				if (MessageBox.Show("카테고리 정보를 수정하시겠습니까?", "수정", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();
					sql = "UPDATE tblCategory SET Category = @Category Where id = @id";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
					cmd.Parameters.AddWithValue("@id", varID);
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("카테고리 정보가 수정되었습니다.!", "확인!", MessageBoxButtons.OK, MessageBoxIcon.Information);


					ResetScreen();
					LoadData();

					//화면 전환
					pnlCategory.Visible = false;
					dataCategory.Enabled = true;
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
			txtCategory.Focus();
		}

		private void dataCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataCategory.Columns[e.ColumnIndex].Name;
			if (colName == "Edit")
			{
				pnlCategory.BringToFront();

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				btnCancel.Enabled = false;

				varID = dataCategory[1, e.RowIndex].Value.ToString();
				txtCategory.Text = dataCategory.Rows[e.RowIndex].Cells[2].Value.ToString();


				//화면 전환
				pnlCategory.Visible = true;
				dataCategory.Enabled = false;

				btnSave.Enabled = false;
				btnUpdate.Enabled = true;
				btnCancel.Enabled = false;
			}

			else if (colName == "Delete")
			{
				if (MessageBox.Show("선택한 카테고리 정보를 삭제하시겠습니까?", "정보삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();

					varID = dataCategory[1, e.RowIndex].Value.ToString();

					sql = "DELETE FROM tblCategory WHERE id ='" + varID + "'";
					cmd = new SqlCommand(sql, con);
					cmd.ExecuteNonQuery();

					con.Close();

					MessageBox.Show("선택한 카테고리 정보가 삭제 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

					LoadData();
				}
			}
		}
	}
}
