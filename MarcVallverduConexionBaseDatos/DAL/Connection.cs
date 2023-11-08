using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcVallverduConexionBaseDatos
{
    public class Connection
    {
        private SqlConnection conexion = null;
        private string CONNECTION_STRING = (
                                            @"Data source = 79.143.90.12,54321;
                                            Initial Catalog = MarcVallverduDatabaseEmployees;Persist Security Info=true;
                                            User Id = sa;Password = 123456789");

        public SqlConnection Conexion { get { return conexion; } }

        public void NuevaConexion()
        {
            conexion = new SqlConnection(CONNECTION_STRING);
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }
    }
}
