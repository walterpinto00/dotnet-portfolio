using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Productos
    {
        CD_Conexion conexion = new CD_Conexion();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("MostrarProductos", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        tabla.Load(leer);
                    }
                }
            }
            return tabla;
        }
    }
}