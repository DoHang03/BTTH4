using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I8DEODT\SQLEXPRESS;Initial Catalog=DOAN;Integrated Security=True");

    }
}
