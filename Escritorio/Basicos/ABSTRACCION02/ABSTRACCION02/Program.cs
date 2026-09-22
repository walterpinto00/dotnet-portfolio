namespace ABSTRACCION02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new ClienteNormal
            {
                Nombre = "Juan Pérez",
                Email = "juan@email.com",
                Telefono = "300-1234567"
            };

            Cliente c2 = new ClienteFrecuente
            {
                Nombre = "María Gómez",
                Email = "maria@email.com",
                Telefono = "301-2345678",
                PuntosAcumulados = 500
            };

            Cliente c3 = new ClienteVIP
            {
                Nombre = "Carlos Rodríguez",
                Email = "carlos@email.com",
                Telefono = "310-3456789",
                AsesorPersonal = "Ana López"
            };

            // Los guardamos en una lista de tipo abstracto
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(c1);
            clientes.Add(c2);
            clientes.Add(c3);

            // El sistema procesa ventas sin saber el tipo de cliente
            SistemaVentas ventas = new SistemaVentas();

            foreach (Cliente cliente in clientes)
            {
                ventas.ProcesarVenta(cliente, 500000, "3 productos");
            }
        }
    }

    // La implementación de SistemaVentas se encuentra en SistemaVentas.cs
}
