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
        

        public static void AgregarProductoLista(ProductoEntidad producto)
        {
            CompraEntidad.listaCarrito.Add(producto);
        }

        public static void EliminarProductoLista(ProductoEntidad producto)
        {
            CompraEntidad.listaCarrito.Remove(producto);
        }
    }
}
