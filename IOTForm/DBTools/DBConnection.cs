using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IOTForm.DBTools
{
    public static class DBConnection
    {
        private static readonly String StringConnection = System.Configuration.ConfigurationManager
            .ConnectionStrings["IotDBString"].ConnectionString;

        public static SqlConnection AbrirConn()
        {
            SqlConnection conn = new SqlConnection(StringConnection);
            conn.Open();
            return conn;
        }
    }
}