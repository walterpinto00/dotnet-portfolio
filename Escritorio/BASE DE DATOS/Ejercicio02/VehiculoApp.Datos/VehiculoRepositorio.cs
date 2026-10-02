namespace VehiculoApp.Datos
{
    public class VehiculoRepositorio
    {
        public List<Vehiculo> ObtenerTodos() { using var c = new VehiculoDbContext(); return c.Vehiculos.ToList(); }
        public void Insertar(Vehiculo v) { using var c = new VehiculoDbContext(); c.Vehiculos.Add(v); c.SaveChanges(); }
        public void Actualizar(Vehiculo v) { using var c = new VehiculoDbContext(); c.Vehiculos.Update(v); c.SaveChanges(); }
        public void Eliminar(int id) { using var c = new VehiculoDbContext(); var v = c.Vehiculos.Find(id); if (v != null) { c.Remove(v); c.SaveChanges(); } }
    }
}
