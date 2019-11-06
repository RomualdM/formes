using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace ClassLibrairie
{
    public abstract class BddGlobal
    {
        private SqlConnection conn;
        public BddGlobal()
        {
            string myConnectionString;
            //myConnectionString = "server=193.252.48.172;port=20433;uid=golfede;pwd=golfede;database=golfbdd;";
            myConnectionString = "server=localhost;port=3306;uid=root;pwd=;database=golf;";
           // Conn = new MySql.Data.MySqlClient.MySqlConnection();
            //Conn.ConnectionString = myConnectionString;
           // Conn.Open();
        }

       // public MySqlConnection Conn { get => conn; set => conn = value; }
    }
}
