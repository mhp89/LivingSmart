using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartForms.Classes;

namespace LivingSmartBusinessLogic.DBLayer
{
    internal sealed class DBConnectionMSSQL
    {
        private static volatile DBConnectionMSSQL _instance;
        private static readonly object objectLock = new Object();
        private readonly SqlConnection conn = new SqlConnection(RegistryWrapper.RegKey.GetValue("DatabaseConnection", Properties.Settings.Default.ConnectionString) as string);

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
