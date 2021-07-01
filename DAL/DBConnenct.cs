using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-U66BGKA\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True");
    }
}
