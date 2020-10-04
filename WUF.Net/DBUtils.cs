using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "wuf_data";
            string username = "root";
            string password = "alpine";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
