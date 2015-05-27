using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DBLayer
{
    public sealed class DBConnectionMSSQL
    {
        private static volatile DBConnectionMSSQL _instance;
        private static readonly object objectLock = new Object();
        private readonly SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private DBConnectionMSSQL() { }

        public static DBConnectionMSSQL Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (objectLock)
                    {
                        if (_instance == null)
                            _instance = new DBConnectionMSSQL();
                    }
                }

                return _instance;
            }
        }

        public SqlConnection GetDBConnection()
        {
            return conn;
        }
    }
}
