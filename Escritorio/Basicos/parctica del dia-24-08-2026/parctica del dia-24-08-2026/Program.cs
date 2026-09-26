namespace parctica_del_dia_24_08_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos productos de diferentes tipos
            Producto p1 = new ProductoFisico
            {
                Nombre = "Laptop",
                Codigo = "FIS-001",
                PrecioBase = 2000000,
                Peso = 2.5
            };

            Producto p2 = new ProductoDigital
            {
                Nombre = "Antivirus 1 año",
                Codigo = "DIG-001",
                PrecioBase = 150000,
                DiasLicencia = 365
            };

            Producto p3 = new Servicio
            {
                Nombre = "Mantenimiento PC",
                Codigo = "SER-001",
                ValorHora = 50000,
                Horas = 3
            };

            // Los guardamos en una lista de tipo abstracto
            List<Producto> carrito = new List<Producto>();
            carrito.Add(p1);
            carrito.Add(p2);
            carrito.Add(p3);

            // La caja cobra sin saber qué tipo de productos son
            CajaRegistradora caja = new CajaRegistradora();
            caja.Cobrar(carrito);
        }
    }
}
