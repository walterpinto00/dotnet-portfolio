using VehiculoApp.Datos;

namespace VehiculoApp.Negocio
{
    public class VehiculoServicio
    {
        private readonly VehiculoRepositorio _repo = new();
        public List<Vehiculo> Listar() => _repo.ObtenerTodos();
        public bool Registrar(Vehiculo v) { if (string.IsNullOrWhiteSpace(v.Placa)) return false; _repo.Insertar(v); return true; }
        public bool Actualizar(Vehiculo v) { if (v.Id <= 0) return false; _repo.Actualizar(v); return true; }
        public void Eliminar(int id) => _repo.Eliminar(id);
    }
}
