using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_manager
{
	class DBConnection
	{
		SqlConnection dbcon = new SqlConnection();
		public string posDBConnection()
		{
			string dbcon = @"Data Source=127.0.0.1;Initial Catalog=Pos_DB;User ID=sa;Password=senna3700!;Integrated Security=True";
			return dbcon;
		}
	}
}
