using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACCION02
{
    internal abstract class Cliente
    {
    // Datos que TODOS los clientes tienen
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    
   
    public abstract double CalcularDescuento(double totalCompra);
    
   
    public abstract void RecibirCompra(string detalle);
    
    public void MostrarDatos()
    {
        Console.WriteLine($"Cliente: {Nombre}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Teléfono: {Telefono}");
    }
    }
}
