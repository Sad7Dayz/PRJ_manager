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
	public partial class frmLogin_M : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		string sql;

		public string _store;
		public string _userId, _password, _job, _userName;
		public bool _permit = false;

		public frmLogin_M()
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("시스템을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				bool _found = false;

				//사용자 Check
				con.Open();

				sql = "select * from tblUser where id = @id and password = @password";
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@id", txtUserId.Text);
				cmd.Parameters.AddWithValue("@password", txtPassword.Text);
				SqlDataReader dr = cmd.ExecuteReader();

				dr.Read();
				if (dr.HasRows)
				{
					_found = true;

					_userId = dr[0].ToString();
					_password = dr[1].ToString();
					_job = dr[2].ToString();
					_userName = dr[3].ToString();
					_permit = bool.Parse(dr[4].ToString());
				}
				else
				{
					_found = false;
				}
				dr.Close();
				con.Close();

				if (_found == true)
				{
					//사용인가가 되었는가?
					if (_permit == false)
					{
						MessageBox.Show("인증이 안된 사용자 입니다.!", "확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}


					//직무가 "계산원"인가?
					if (_job == "계산원")
					{
						
						//사업장 정보 loading
						con.Open();
						sql = "Select * from tblStore";
						cmd = new SqlCommand(sql, con);
						dr = cmd.ExecuteReader();
						dr.Read();

						if (dr.HasRows)
						{
							_store = dr[0].ToString();
							dr.Close();
							con.Close();

							//
							//POS 시스템로딩
							//
							txtUserId.Clear();
							txtPassword.Clear();

							frmPos frm = new frmPos();
							frm.lblBizName.Text = _store;
							frm.lblJob.Text = _job;
							frm.lblUserID.Text = _userId;
							frm.lblUserName.Text = _userName;
							this.Hide();
							frm.ShowDialog();
						}

						else
						{
							dr.Close();
							con.Close();
							MessageBox.Show("사업장정보가 없습니다.!", "확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
				
						//MessageBox.Show("관리자가 아닙니다.!", "확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						//return;
					}
					else
					{

						//
						//관리자 시스템 로딩
						//
						txtUserId.Clear();
						txtPassword.Clear();

						mdiManage mdi = new mdiManage();
						mdi._userid = _userId;
						mdi._userName = _userName;
						mdi._job = _job;
						mdi._password = _password;
						mdi.lblUser.Text = _job + " | " + _userId + " | " + _userName;
						this.Hide();
						mdi.ShowDialog();
					}
				}
				else
				{
					MessageBox.Show("인증이 안된 사용자입니다.!", "확인", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch(Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}