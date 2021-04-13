using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    internal class Connection
    {
        private string dbName;
        private string serverName;
        private string dbUser;
        private string dbKeyCode;
        private bool dbSecurity;
        private static Connection instance = null;
        
        private Connection()
        {
            this.dbName = "db_role_person";
            this.serverName = "DESKTOP-RLD7QMI";
            this.dbUser = "rancheritos";
            this.dbKeyCode = "t4qu3r1t0s";
            this.dbSecurity = true;
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = "Server=" + this.serverName + "; Database=" + this.dbName + ";";

                connection.ConnectionString += this.dbSecurity ? "Integrated Security=SSPI" : "User Id=" + this.dbUser + "; Password=" + this.dbKeyCode;
            }
            catch (Exception)
            {

                throw;
            }

            return connection;
        }

        public static Connection GetInstance()
        {
            if (instance == null)
                instance = new Connection();

            return instance;
        }
    }
}
