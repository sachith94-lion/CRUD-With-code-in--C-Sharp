using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_with_code
{
    class connection
    {
        

        public SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sachith\C# projects\CRUD With code\CRUD_with_code\CRUD_with_code\bin\Debug\Pizza.mdf;Integrated Security=True;Connect Timeout=30");
            return con;
        }
    }
}
