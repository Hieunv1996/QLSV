using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLSV.Data
{
    class clsDataProvider
    {
        private static string connect = "Data Source=(local);Initial Catalog=QLSV;Integrated Security=True";
        private static SqlConnection conn;

        public clsDataProvider()
        {
            if (conn == null)
                conn = new SqlConnection(connect);
        }


    }
}
