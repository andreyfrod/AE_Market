using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CarritoEntidad
    {
        public int idProducto { get; set; }
        public String tipoProducto { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public Decimal precio { get; set; }
        public int cantidadProductos { get; set; }
        public Decimal total { get; set; }

        public static List<CarritoEntidad> listaCarrito = new List<CarritoEntidad>();
    }
}
