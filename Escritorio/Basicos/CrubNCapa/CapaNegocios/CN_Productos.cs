using System;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Productos
    {
        CD_Productos oCD_Productos = new CD_Productos();

        public DataTable Mostrar()
        {
            return oCD_Productos.Mostrar();
        }

        public void Insertar(string nombre, string descripcion, string marca, string precio, string stock)
        {
            oCD_Productos.Insertar(nombre, descripcion, marca, Convert.ToSingle(precio), Convert.ToInt32(stock));
        }

        public void Actualizar(string id, string nombre, string descripcion, string marca, string precio, string stock)
        {
            oCD_Productos.Actualizar(Convert.ToInt32(id), nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void Eliminar(string id)
        {
            oCD_Productos.Eliminar(Convert.ToInt32(id));
        }
    }
}