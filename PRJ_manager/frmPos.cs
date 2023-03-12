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
	public partial class frmPos : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DBConnection dbcon = new DBConnection();

		string sql;
		int qty; //현 재고 수량

		string _payment; //결제구분
		int _cash;       //받은금액
		double _change;         //거스름돈

		int _taxAmt = 0;    // 과세상품 금액 합계
		double _vatAmt = 0; // 부가세 합계
		int _noAmt = 0;     // 면세상품 금액 합계
		double _totAmt = 0; // 합계


		public frmPos()
		{
			InitializeComponent();
			con = new SqlConnection(dbcon.posDBConnection());

			//KEY 활성
			this.KeyPreview = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDate.Text = DateTime.Now.ToLongDateString();
			lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if (dataCart.Rows.Count > 0)
			{
				MessageBox.Show("장바구니에 정보가 남아 있습니다.! 취소후 로그아웃 하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Dispose();
				frmLogin_M frm = new frmLogin_M();
				frm.ShowDialog();
			}
		}

		//거래시작
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (dataCart.Rows.Count > 0)
			{
				return;
			}

			GetTransNo();

			btnProduct.Enabled = true;
			txtBarcode.Enabled = true;
			txtBarcode.Focus();
		}

		//거래 No. 생성
		private void GetTransNo()
		{
			try
			{
				string _sdate = DateTime.Now.ToString("yyyyMMdd");
				string _transno;
				int count;

				con.Open();
				sql = "Select top 1 transno from tblSales where transno like '" + _sdate + "%' order by id desc";
				cmd = new SqlCommand(sql, con);
				SqlDataReader dr = cmd.ExecuteReader();
				dr.Read();
				if (dr.HasRows)
				{
					_transno = dr[0].ToString();
					count = int.Parse(_transno.Substring(8, 4));

					lblTransno.Text = _sdate + (count + 1);
				}
				else
				{
					_transno = _sdate + "0001";
					lblTransno.Text = _transno;
				}

				lblSdate.Text = DateTime.Now.ToLongDateString();

				dr.Close();
				con.Close();
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		//Function key 선택
		private void frmPos_KeyDown(object sender, KeyEventArgs e)
		{
			//거래 시작
			if (e.KeyCode == Keys.F1)
			{
				btnStart_Click(sender, e);
			}

			//상품 검색
			if (e.KeyCode == Keys.F2)
			{
				btnProduct_Click(sender, e);
			}

			//현금결제
			if (e.KeyCode == Keys.F3)
			{
				btnCash_Click(sender, e);
			}

			//카드 결제
			if (e.KeyCode == Keys.F4)
			{
				btnCard_Click(sender, e);
			}

			//일 판매현황
			if (e.KeyCode == Keys.F8)
			{
				btnSaleReport_Click(sender, e);
			}

			//비밀번호
			if (e.KeyCode == Keys.F9)
			{
				btnPassChange_Click(sender, e);
			}

		}

		//상품 바코드 Scan & Read
		private void txtBarcode_TextChanged(object sender, EventArgs e)
		{
			if (txtBarcode.Text == string.Empty)
			{
				//MessageBox.Show("거래 할 상품을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				//상품코드, 가격, 수량 변수 설정
				string _pcode;
				int _price;
				int _qty;

				con.Open();

				sql = "Select from tblProduct where barcode = '" + txtBarcode.Text + "' ";
				cmd = new SqlCommand(sql, con);
				SqlDataReader dr = cmd.ExecuteReader();
				dr.Read();

				if (dr.HasRows)
				{
					//현재고 수량
					qty = int.Parse(dr["qty"].ToString());

					_pcode = dr["pcode"].ToString();
					_price = int.Parse(dr["price"].ToString());

					//상품 스캔 또는 읽을시 수량 = 1
					_qty = 1;

					dr.Close();
					con.Close();

					//장바구니에 상품 담기
					AddToCart(_pcode, _price, _qty);
				}
				else
				{
					dr.Close();
					con.Close();
				}
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		/*
		 * 판매금액(saleamt)은 Trigger 테이블 이용
		 */
		//장바구니에 상품담기
		private void AddToCart(string _pcode, int _price, int _qty)
		{
			bool found = true;
			string id = "";
			int cart_qty = 0;

			con.Open();

			sql = "select * from tblsales where transno = @transno and pcode = @pcode";
			cmd = new SqlCommand(sql, con);
			cmd.Parameters.AddWithValue("@transno", lblTransno.Text);
			cmd.Parameters.AddWithValue("@pcode", _pcode);
			SqlDataReader dr = cmd.ExecuteReader();
			dr.Read();

			if (dr.HasRows)
			{
				found = true; //장바구니에 같은 상품이 있다면 수량 누적

				id = dr["id"].ToString();
				cart_qty = cart_qty + int.Parse(dr["qty"].ToString()); //거래 상품 수량 누적
			}
			else
			{
				found = false;
			}
			dr.Close();
			con.Close();

			if (found == true) //장바구니에 같은 상품이 있다면 수량 업데이트
			{
				if (qty < 1 + cart_qty)
				{
					MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				con.Open();

				sql = "update tblsales set qty = @qty where id = @id";
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@qty", _qty);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteReader();
				dr.Read();

				con.Close();

				txtBarcode.Clear();
				txtBarcode.SelectionStart = 0;
				txtBarcode.SelectionLength = txtBarcode.Text.Length;
				txtBarcode.Focus();

				//장바구니 정보
				LoadToCart();
			}
			else //장바구니에 같은 상품이 없다면 Table insert
			{
				if (qty < 1)
				{
					MessageBox.Show("현재 거래 할 재고 수량이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				con.Open();

				sql = "Insert into tblSales(transno, pcode, price, qty, sdate, userid) values (@transno, @pcode, @price, @qty, @sdate, @userid)";
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@transno", lblTransno.Text);
				cmd.Parameters.AddWithValue("@pcode", _pcode);
				cmd.Parameters.AddWithValue("@price", _price);
				cmd.Parameters.AddWithValue("@qty", _qty);
				cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
				cmd.Parameters.AddWithValue("@userid", lblUserID.Text);

				cmd.ExecuteNonQuery();
				con.Close();

				txtBarcode.Clear();
				txtBarcode.SelectionStart = 0;
				txtBarcode.SelectionLength = txtBarcode.Text.Length;
				txtBarcode.Focus();

				//장바구니 정보
				LoadToCart();
			}
		}

		//장바구니 정보 Data Loading
		public void LoadToCart()
		{
			try
			{
				Boolean hasdata = false;
				dataCart.Rows.Clear();
				int i = 0;

				_taxAmt = 0;    // 과세상품 금액 합계
				_vatAmt = 0; // 부가세 합계
				_noAmt = 0;     // 면세상품 금액 합계
				_totAmt = 0; // 합계

				con.Open();

				sql = "select S.id, S.pcode, P.pname, P.price, S.qty, S.saleAmt, P.notax from tblSales as S " +
					  "inner join tblProduct As P on S.pcode = P.pcode" +
					  "where transno = '" + lblTransno.Text + "' And status = '보류' ";

				cmd = new SqlCommand(sql, con);
				SqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					i++;

					if (dr["notax"].ToString() == "t") //부가세 상품이면
					{
						_taxAmt += int.Parse(dr["saleAmt"].ToString());
						_vatAmt += int.Parse(dr["saleAmt"].ToString()) * 0.1; //부가세 10%
					}
					else // 면세 "#"
					{
						_noAmt += int.Parse(dr["saleAmt"].ToString());
					}

					dataCart.Rows.Add(i, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
					hasdata = true;
				}

				_totAmt = _taxAmt + _vatAmt + _noAmt;

				dr.Close();
				con.Close();

				lblTaxAmt.Text = _taxAmt.ToString("#,###,##0 ");
				lblVatAmt.Text = _vatAmt.ToString("#,###,##0 ");
				lblNoAmt.Text = _noAmt.ToString("#,###,##0 ");
				lblTotAmt.Text = _totAmt.ToString("#,###,##0 ");

				if (hasdata == true)
				{
					//panel6.Enabled = true;
					btnCancel.Enabled = true;
					txtAmount.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				con.Close();
				MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void dataCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string colName = dataCart.Columns[e.ColumnIndex].Name;
			if (colName == "colDelete")
			{
				if (MessageBox.Show("선택한 상품을 삭제 하시겠습니까?", "정보삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					con.Open();

					sql = "delete from tblSales where id = '" + dataCart.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ";
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("선택한 상품을  삭제 했습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadToCart();
				}
			}
			else if (colName == "colPlus") //거래 상품 수량 증가
			{
				int _qty = 0; // 현재고 수량 변수

				con.Open();

				sql = "select sum(qty) as qty from tblProduct where pcode = '" + dataCart.Rows[e.RowIndex].Cells[2].Value.ToString()
					+ "' group by pcode";
				cmd = new SqlCommand(sql, con);
				_qty = int.Parse(cmd.ExecuteScalar().ToString());

				con.Close();

				if (int.Parse(dataCart.Rows[e.RowIndex].Cells[5].Value.ToString()) < _qty) //현재고 수량이 입력 받은 수량보다 많으면(크면) 수량 1개씩 추가
				{
					con.Open();

					sql = "Update tblSales set qty = qty + 1 where transno = '" + lblTransno.Text + "' and pcode = '" + dataCart.Rows[e.RowIndex].Cells[2].Value.ToString() + "'";
					cmd = new SqlCommand(sql, con);
					cmd.ExecuteNonQuery();

					con.Close();

					LoadToCart();
				}
				else
				{
					MessageBox.Show("현재고 수량이 입력한 수량보다 적습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
			else if (colName == "colMinus") //거래 상품 수량 감소
			{
				int _qty = 0;
				con.Open();

				sql = "select sum(qty) as qty from tblSales where pcode = '" + dataCart.Rows[e.RowIndex].Cells[2].Value.ToString() +
					"' and transno = '" + lblTransno.Text + "' group by trnasno, pcode ";
				cmd = new SqlCommand(sql, con);
				_qty = int.Parse(cmd.ExecuteScalar().ToString());

				con.Close();

				if (_qty > 1) //장바구니 상품 수량이 1보다 크면 수량 1개 감소
				{
					con.Open();

					sql = "update tblSales set qty = qty -1 where transno = '" + lblTransno.Text + "' and pocde = '" + dataCart.Rows[e.RowIndex].Cells[2].Value.ToString() + "'";
					cmd = new SqlCommand(sql, con);
					cmd.ExecuteNonQuery();

					con.Close();

					LoadToCart();
				}
				else
				{
					MessageBox.Show("감소 시킬 상품 수량이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
		}

		//거래 취소 -> 장바구니 클리어
		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("거래를 취소하고 장바구니 정보를 모두 삭제 하시겠습니까?", "거래취소", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				con.Open();
				sql = "delete from tblSales where transno =  '" + lblTransno.Text + "'";
				con.Close();
				MessageBox.Show(lblTransno.Text + "의 거래가 모두 취소 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadToCart();
			}

		}

		//상품 리스트 검색 / 선택[F2] rtn
		private void btnProduct_Click(object sender, EventArgs e)
		{
			frmPosProduct frm = new frmPosProduct(this);
			frm.ShowDialog();

			btnCash.Enabled = true;
			btnCard.Enabled = true;
		}

		//카드[f4] 결제 rtn
		private void btnCard_Click(object sender, EventArgs e)
		{
			if (lblTotAmt.Text == "0")
			{
				//카드 결제 시스템 구축 후 연동.
				MessageBox.Show("카드 결제 시스템 구축이 안되어 있습니다.(현금 결제만 가능)", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				_payment = "카드"; //결제구분
			}

			panel6.Enabled = true;
			txtAmount.Text = _totAmt.ToString("#,###,##0");
			lblChange.Text = "0";
			btnEnter.Focus();
		}

		//현금[F3] 결제 rtn
		private void btnCash_Click(object sender, EventArgs e)
		{
			if (lblTotAmt.Text == "0")
			{
				MessageBox.Show("장바구니에 결제 할 상품이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBarcode.Focus();
			}

			panel6.Enabled = true;
			_payment = "현금"; //결제 구분
			txtAmount.Enabled = true;
			txtAmount.Focus();

		}

		//거스름돈 계산
		private void txtAmount_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_totAmt = double.Parse(lblTotAmt.Text);
				_cash = int.Parse(txtAmount.Text);
				_change = _cash - _totAmt; //받은금액 - 합계금액

				lblChange.Text = _change.ToString("#,###,##0");
			}
			catch
			{
				lblChange.Text = "0";
			}
		}

		//계산기 버튼 1~9 & C, 0, 00 rtn
		private void btn9_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn9.Text;
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn8.Text;
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn7.Text;
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn6.Text;
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn5.Text;
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn4.Text;
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn3.Text;
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn2.Text;
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn1.Text;
		}

		private void btnC_Click(object sender, EventArgs e)
		{
			txtAmount.Clear();
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn0.Text;
		}

		private void btn00_Click(object sender, EventArgs e)
		{
			txtAmount.Text += btn00.Text;
		}

		//결제 & 영수증 출력
		private void btnEnter_Click(object sender, EventArgs e)
		{
			if (_payment == "현금")
			{
				txtAmount.Text = _cash.ToString("#,###,##0");
			}
			txtAmount.Text = _cash.ToString("#,###,##0");
			try
			{
				if (_change < 0 || _totAmt == 0)
				{
					MessageBox.Show("결제할 금액이 없거나 틀렷습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					for (int i = 0; i < dataCart.Rows.Count; i++)
					{
						//상품정보(tblProduct)테이블에 재고수량(qty) - 판매수량(@qty) update
						con.Open();

						string Pcode = dataCart.Rows[i].Cells[1].Value.ToString();
						int Qty = int.Parse(dataCart.Rows[i].Cells[5].Value.ToString());
						string ID = dataCart.Rows[i].Cells[1].Value.ToString();

						sql = "Update tblProduct set qty = qty - @qty where pcode= @pcode";
						cmd = new SqlCommand(sql, con);
						cmd.Parameters.AddWithValue("@qty", Qty);
						cmd.Parameters.AddWithValue("@pcode", Pcode);
						cmd.ExecuteNonQuery();

						con.Close();

						//판매정보(tblSales) 테이블에 Payment(결제구분), status(상태) Update
						con.Open();

						sql = "update tblSales set payment = @payment, status '판매' where id = @id";
						cmd = new SqlCommand(sql, con);
						cmd.Parameters.AddWithValue("@payment", _payment);
						cmd.Parameters.AddWithValue("@id", ID);
						cmd.ExecuteNonQuery();

						con.Close();
					}

					//영수증 출력 rtn
					frmReciept frm = new frmReciept(this);
					frm.LoadReport();
					frm.ShowDialog();

					MessageBox.Show("결제가 정상적으로 완료 되었습니다.", "결제", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
				
					txtAmount.Clear();
					lblChange.Text = "0";

					GetTransNo();
					LoadToCart();
					btnCash.Enabled = false;
					btnCard.Enabled = false;
					panel6.Enabled = false;
					txtAmount.Enabled = false;
					btnCancel.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSaleReport_Click(object sender, EventArgs e)
		{
			frmDailySale frm = new frmDailySale(this);
			//frm.lblUserId.Text = lblUserID.Text;
			//frm.lblUserName.Text = lblUserName.Text;
			frm.ShowDialog();
		}

		private void btnPassChange_Click(object sender, EventArgs e)
		{
			frmPosPassword frm = new frmPosPassword(this);
			frm.ShowDialog();
		}
	}
}
