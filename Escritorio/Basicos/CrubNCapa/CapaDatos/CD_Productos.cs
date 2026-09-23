using System;
using System.Data;
using System.Data.SqlClient;

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

        public void Insertar(string nombre, string descripcion, string marca, float precio, int stock)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("Sp_InsetarProductos", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.Parameters.AddWithValue("@Marca", marca);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@Stock", stock);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(int id, string nombre, string descripcion, string marca, double precio, int stock)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand consulta = new SqlCommand("Sp_EditarProductos", con))
                {
                    consulta.CommandType = CommandType.StoredProcedure;
                    consulta.Parameters.AddWithValue("@Id", id);
                    consulta.Parameters.AddWithValue("@Nombre", nombre);
                    consulta.Parameters.AddWithValue("@Descripcion", descripcion);
                    consulta.Parameters.AddWithValue("@Marca", marca);
                    consulta.Parameters.AddWithValue("@Precio", precio);
                    consulta.Parameters.AddWithValue("@Stock", stock);
                    consulta.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand eliminado = new SqlCommand("Sp_EliminarProductos", con))
                {
                    eliminado.CommandType = CommandType.StoredProcedure;
                    eliminado.Parameters.AddWithValue("@Id", id);
                    eliminado.ExecuteNonQuery();
                }
            }
        }
    }
}