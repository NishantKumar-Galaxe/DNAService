using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DataAccessLayer
{
    public abstract class BaseRepository
    {
        public SqlConnection SqlOpenConnection()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
