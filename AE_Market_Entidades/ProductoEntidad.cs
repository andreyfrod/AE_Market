using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoEntidad
    {
        private int productId;

        public ProductoEntidad()
        {
        }

        public ProductoEntidad(int productId)
        {
            this.productId = productId;
        }

        public int idProducto { get; set; }
        public String tipoProducto { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public Decimal precio { get; set; }
    }
}
