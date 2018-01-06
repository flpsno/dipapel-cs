using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Dipapel.Infraestructure.ADO
{
    public class DipapelADODataContext : IDisposable
    {
        public MySqlConnection Connection { get; private set; }
        private readonly string _connectionString = "";

        public DipapelADODataContext()
        {
            Connection = new MySqlConnection(_connectionString);
        }

        public void OpenDB()
        {

            try
            {
                if (Connection.State != ConnectionState.Open)
                    Connection.Open();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void CloseDB()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            CloseDB();
        }
    }
}
