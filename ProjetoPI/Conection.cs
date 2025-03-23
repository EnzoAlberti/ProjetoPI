using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    class Conection
    {
        private SqlConnection _connection;
        private bool _disposed = false;
        public String connectionString = Properties.Settings.Default.dbServicoConnectionString;
        public Conection()
        {
            _connection = new SqlConnection(connectionString);
        }
        public void Open()
        {
            if(_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }
        public void Close()
        {
            if(_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
        public SqlConnection Connection => _connection;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Close();
                    _connection.Dispose();
                }
                _disposed = true;
            }
        }
    }
}
