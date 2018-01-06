using MySql.Data.MySqlClient;
using System;

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

        public void OpenDB() {

            try
            {
                Connection.Open();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void CloseDB() {
            try
            {
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
