using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRJ_manager
{
	public partial class frmStore : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();
		string sql;

		public frmStore()
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());
		}


		//사업장 정보 Loading
		public void Loading()
		{
			con.Open();
			sql = "SELECT * FROM tblStore";
			cmd = new SqlCommand(sql, con);
			SqlDataReader dr = cmd.ExecuteReader();
			dr.Read();
			if (dr.HasRows)
			{
				txtBizName.Text = dr[0].ToString();
				txtBizNumber.Text = dr[1].ToString();
				txtOwner.Text = dr[2].ToString();
				txtAddress.Text = dr[3].ToString();
				txtTel.Text = dr[4].ToString();
			}
			else
			{
				ResetScreen();
			}
			dr.Close();
			con.Close();
		}

		//화면 초기화
		private void ResetScreen()
		{
			txtBizName.Clear();
			txtBizNumber.Clear();
			txtOwner.Clear();
			txtAddress.Clear();
			txtTel.Clear();
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		//사업장 정보 입력(저장)
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("사업자 정보를 입력하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					int count = getStoreInfo();
					if (count > 0)
					{
						//정보가 있음
						con.Open();
						sql = "UPDATE tblStore SET bizName=@bizName, owner=@owner, address=@address, tel=@tel";
						cmd = new SqlCommand(sql, con);
						cmd.Parameters.AddWithValue("@bizName", txtBizName.Text);
						cmd.Parameters.AddWithValue("@bizNumber", txtBizNumber.Text);
						cmd.Parameters.AddWithValue("@owner", txtOwner.Text);
						cmd.Parameters.AddWithValue("@address", txtAddress.Text);
						cmd.Parameters.AddWithValue("@tel", txtTel.Text);
						cmd.ExecuteReader();
						con.Close();
					}
					else
					{
						//정보가 없음
						con.Open();
						sql = "INSERT INTO tblStore(bizName, bizNumber, owner, address, tel) VALUES (@bizName, @bizNumber, @owner, @address, @tel)";
						cmd = new SqlCommand(sql, con);
						cmd.Parameters.AddWithValue("@bizName", txtBizName.Text);
						cmd.Parameters.AddWithValue("@bizNumber", txtBizNumber.Text);
						cmd.Parameters.AddWithValue("@owner", txtOwner.Text);
						cmd.Parameters.AddWithValue("@address", txtAddress.Text);
						cmd.Parameters.AddWithValue("@tel", txtTel.Text);
						cmd.ExecuteReader();
						con.Close();
					}
					MessageBox.Show("사업장 정보가 입력되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "주의!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		//사업장 정보 get
		private int getStoreInfo()
		{
			con.Open();
			sql = "SELECT COUNT(*) FROM tblStore";
			cmd = new SqlCommand(sql, con);
			int count = int.Parse(cmd.ExecuteScalar().ToString());
			con.Close();
			return count;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ResetScreen();
			txtBizName.Focus();
		}
	}
}
