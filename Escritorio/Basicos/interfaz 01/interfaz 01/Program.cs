namespace interfaz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
                CarritoCompras carrito = new CarritoCompras();

                // El mismo método funciona con diferentes implementaciones
                carrito.Pagar(new TarjetaCredito("1234567890123456", "123"), 150000);
                carrito.Pagar(new PayPal("usuario@email.com"), 250000);
                carrito.Pagar(new Transferencia("123-456", "789-012"), 500000);
            }

        }
    }
