using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompraEntidad
    {
        public int idCompra { get; set; }
        public DateTime fecha { get; set; }
        public int idUsuario { get; set; }
        public int idProducto { get; set; }
        public int cantidadProductos { get; set; }
        public Decimal total { get; set; }

        public static List<ProductoEntidad> listaCarrito = new List<ProductoEntidad>();
    }
}
