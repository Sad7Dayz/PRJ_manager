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
	public partial class frmPosPassword : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		string sql;

		frmPos _pos;

		public frmPosPassword(frmPos frm)
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());
			_pos = frm;
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				string _oldPassword = GetPassword(_pos.lblUserID.Text);
				if (_oldPassword != txtPassword.Text)
				{
					MessageBox.Show("현재 비밀번호가 틀립니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if (txtNewpassword.Text != txtConPassword.Text)
				{
					MessageBox.Show("비밀번호가 맞지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					if (MessageBox.Show("비밀번호를 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						con.Open();

						sql = "Update tblUser set password = @password where id = @id";
						cmd = new SqlCommand(sql, con);
						cmd.Parameters.AddWithValue("@password", txtNewpassword.Text);
						cmd.Parameters.AddWithValue("@id", _pos.lblUserID.Text);
						cmd.ExecuteNonQuery();
						con.Close();

						MessageBox.Show("비밀번호가 변경되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

						txtPassword.Clear();
						txtNewpassword.Clear();
						txtConPassword.Clear();

						txtPassword.Focus();
					}
				}

				con.Close();

			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "비밀번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


		//현재 비밀번호		
		private string GetPassword(string userid)
		{
			string _password = "";

			con.Open();

			sql = "select * from tblUser where id = @id";
			cmd = new SqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@id", userid);
			SqlDataReader dr = cmd.ExecuteReader();
			dr.Read();

			if (dr.HasRows)
			{
				_password = dr["password"].ToString();
			}

			dr.Close();
			con.Close();

			return _password;
		}
	}
}
