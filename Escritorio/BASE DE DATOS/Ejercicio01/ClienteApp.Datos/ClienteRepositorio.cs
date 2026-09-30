using System.Data.SqlClient;

namespace ClienteApp.Datos
{
    public class ClienteRepositorio
    {
        private readonly string _connectionString;

        public ClienteRepositorio(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Cliente> ObtenerTodos()
        {
            var clientes = new List<Cliente>();
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM Clientes", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clientes.Add(new Cliente
                {
                    Id = (int)reader["Id"],
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Email = reader["Email"].ToString()
                });
            }
            return clientes;
        }

        public void Insertar(Cliente cliente)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand(
                "INSERT INTO Clientes (Nombre, Apellido, Telefono, Email) VALUES (@nom, @ape, @tel, @ema)", conn);
            cmd.Parameters.AddWithValue("@nom", cliente.Nombre);
            cmd.Parameters.AddWithValue("@ape", cliente.Apellido);
            cmd.Parameters.AddWithValue("@tel", cliente.Telefono);
            cmd.Parameters.AddWithValue("@ema", cliente.Email);
            cmd.ExecuteNonQuery();
        }

        public void Actualizar(Cliente cliente)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand(
                "UPDATE Clientes SET Nombre=@nom, Apellido=@ape, Telefono=@tel, Email=@ema WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@nom", cliente.Nombre);
            cmd.Parameters.AddWithValue("@ape", cliente.Apellido);
            cmd.Parameters.AddWithValue("@tel", cliente.Telefono);
            cmd.Parameters.AddWithValue("@ema", cliente.Email);
            cmd.Parameters.AddWithValue("@id", cliente.Id);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand("DELETE FROM Clientes WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
