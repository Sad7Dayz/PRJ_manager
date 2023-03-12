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
	public partial class frmUser : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		string sql;

		mdiManage _mdi;

		public frmUser(mdiManage _pmdi)
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());
			this._mdi = _pmdi;
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void ResetScreen()
		{
			txtUserID.Clear();
			txtPassword.Clear();
			txtRePassword.Clear();
			cboJob.Text = "";
			txtUserName.Clear();

			txtUserID.Focus();
		}

		private void ResetScreen2()
		{
			//txtCUser.Clear();
			txtCPassword.Clear();
			txtCRePassword.Clear();
			txtCNewpassword.Clear();

			txtCUserID.Focus();
		}

		//사용자 계정정보 등록
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtPassword.Text != txtRePassword.Text)
				{
					MessageBox.Show("비밀번호를 확인하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				con.Open();
				sql = "Insert into tblUser (id, password, job, userName) values (@id, @password, @job, @userName)";
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@id", txtUserID.Text);
				cmd.Parameters.AddWithValue("@password", txtPassword.Text);
				cmd.Parameters.AddWithValue("@job", cboJob.Text);
				cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
				cmd.ExecuteNonQuery();

				con.Close();

				MessageBox.Show("사용자 계정 정보가 등록이 되었습니다.!", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

				ResetScreen();
			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ResetScreen();
		}

		//비밀번호 변경
		private void btnChange_Click(object sender, EventArgs e)
		{
			try
			{
				//현재 비밀번호 

				if (txtCPassword.Text != _mdi._password)
				{
					MessageBox.Show("현재 비밀번호가 틀립니다.!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				if (txtCNewpassword.Text != txtCRePassword.Text)
				{
					MessageBox.Show("비밀번호를 확인하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				con.Open();
				sql = "Update tblUser set password = @password where id = @id";
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@password", txtCNewpassword.Text);
				cmd.Parameters.AddWithValue("@id", txtCUserID.Text);
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("사용자 비밀번호가 변경 되었습니다.!", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

				ResetScreen2();
			}
			catch (Exception exe)
			{
				con.Close();
				MessageBox.Show(exe.Message);
			}
		}

		private void txtPUser_TextChanged(object sender, EventArgs e)
		{
			try
			{
				con.Open();

				sql = "select * from tblUser where id = @id";
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@id", txtPUser.Text);
				SqlDataReader dr = cmd.ExecuteReader();
				dr.Read();

				if (dr.HasRows)
				{
					chkPermit.Enabled = true;
					btnOk.Enabled = true;

					chkPermit.Checked = bool.Parse(dr["permit"].ToString());
				}
				else
				{
					chkPermit.Checked = false;
					btnOk.Enabled = false;

					chkPermit.Checked = false;
				}
				dr.Close();
				con.Close();
			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message);
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				bool _found = true;
				con.Open();

				sql = "Select * from tblUser where id = @id";
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@id", txtPUser.Text);
				SqlDataReader dr = cmd.ExecuteReader();
				dr.Read();

				if (dr.HasRows)
				{
					_found = true;
				}
				else
				{
					_found = false;
				}
				con.Close();

				if (_found == true)
				{
					con.Open();
					sql = "Update tblUser set permit = @permit where id = @id";
					cmd = new SqlCommand(sql, con);
					cmd.Parameters.AddWithValue("@permit", chkPermit.Checked.ToString());
					cmd.Parameters.AddWithValue("@id", txtPUser.Text);
					cmd.ExecuteNonQuery();

					con.Close();

					MessageBox.Show("사용허가가 인증 되었습니다.", "인증확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtPUser.Clear();
					chkPermit.Checked = false;
				}
				else
				{
					con.Close();
					MessageBox.Show("등록된 사용자가 아닙니다.!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message);
			}
		}
	}
}
