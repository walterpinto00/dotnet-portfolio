using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        // 1. Guardamos solo el texto de la cadena de conexión
        private string cadenaConexion = @"Server=(localdb)\mssqllocaldb;Database=Practica;Integrated Security=true";

        // 2. Generamos un objeto nuevo cada vez que una operación CRUD lo pida
        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}