using ClienteApp.Datos;

namespace ClienteApp.Negocio
{
    public class ClienteServicio
    {
        private readonly ClienteRepositorio _repositorio;

        public ClienteServicio(ClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Cliente> ObtenerClientes() => _repositorio.ObtenerTodos();

        public bool RegistrarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Email))
                return false;
            _repositorio.Insertar(cliente);
            return true;
        }

        public bool ActualizarCliente(Cliente cliente) 
        {
            if (cliente.Id <= 0) return false;
            _repositorio.Actualizar(cliente);
            return true;
        }

        public void EliminarCliente(int id) => _repositorio.Eliminar(id);
    }
}
