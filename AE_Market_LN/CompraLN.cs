using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CompraLN
    {
        

        public static void AgregarProductoLista(CarritoEntidad producto)
        {
            CarritoEntidad.listaCarrito.Add(producto);
        }

        public static CarritoEntidad encontrarArticuloenCarrito(int Producto)
        {
            CarritoEntidad entidad = CarritoEntidad.listaCarrito.Find(x => x.idProducto == Producto);
            return entidad;
        }

        public static void EliminarProductoLista(int producto)
        {
            CarritoEntidad.listaCarrito.Remove(encontrarArticuloenCarrito(producto));
        }

        public static void actualizarCantidad(int producto, int newCantidad)
        {
            var obj = CarritoEntidad.listaCarrito.FirstOrDefault(x => x.idProducto == producto);
            if (obj != null)
            {
                obj.cantidadProductos = newCantidad;
                obj.total = obj.precio * newCantidad;
            }
        }

    }
}
