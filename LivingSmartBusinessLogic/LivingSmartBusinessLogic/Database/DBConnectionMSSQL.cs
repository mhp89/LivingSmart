using System;
using System.Data;
using System.Data.SqlClient;
using LivingSmartBusinessLogic.Properties;
using LivingSmartForms.Classes;

namespace LivingSmartBusinessLogic.Database
{
    internal sealed class DBConnectionMSSQL
    {
        private static volatile DBConnectionMSSQL _instance;
        private static readonly object objectLock = new Object();
        private readonly SqlConnection conn = new SqlConnection(RegistryWrapper.RegKey.GetValue("DatabaseConnection", Settings.Default.ConnectionString) as string);

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


		public bool IsOpen
		{
			get { return conn.State == ConnectionState.Open; }
		}

	    public void Open()
		{
		    if (!IsOpen)
			    conn.Open();
		}

		public void Close()
		{
			if (IsOpen)
				conn.Close();
		}


		#region Execute methods

		public void ExecuteNonQuery(SqlCommand command, bool autoCloseConnection = true)
		{
			try
			{
				if (!IsOpen)
					Open();

				command.Connection = conn;
				command.ExecuteNonQuery();
			}
			catch (SqlException e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (autoCloseConnection)
					Close();
			}
		}
		public void ExecuteNonQuery(String commandString, bool autoCloseConnection = true)
		{
			ExecuteNonQuery(new SqlCommand(commandString), autoCloseConnection);
		}


		public SqlDataReader ExecuteReader(SqlCommand command)
		{
			if (!IsOpen)
				Open();

			command.Connection = conn;
			return command.ExecuteReader();
		}
		public SqlDataReader ExecuteReader(String commandString)
		{
			return ExecuteReader(new SqlCommand(commandString));
		}


		public object ExecuteScalar(SqlCommand command, object defaultValue=null, bool autoCloseConnection = true)
		{
			object returnValue = defaultValue;
			try
			{
				if (!IsOpen)
					Open();
				
				command.Connection = conn;
				returnValue = command.ExecuteScalar();
			}
			catch (SqlException e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if(autoCloseConnection)
					Close();
			}

			return returnValue;
		}
		public object ExecuteScalar(String commandString, object defaultValue = null, bool autoCloseConnection = true)
		{
			return ExecuteScalar(new SqlCommand(commandString), defaultValue, autoCloseConnection);
		}

		#endregion
    }
}
