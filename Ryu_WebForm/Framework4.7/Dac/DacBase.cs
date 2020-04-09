using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework4._7.Dac
{
    public class DacBase : IDisposable
    {
        protected SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RyuDB"].ToString());

        public DacBase()
        {
            DBConn();
        }

        public void DBConn()
        {
            if (connection != null)
            {
                connection.Open();
            }
        }

        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
