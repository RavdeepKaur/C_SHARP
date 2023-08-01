using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class DbConnection
    {
        public SqlConnection conn=new SqlConnection();
        public SqlCommand cmd=new SqlCommand();
        public String location = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\day7\day7\Database1.mdf;Integrated Security=True;Connect Timeout=60";
    }
}
