using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class CuponEntidad
    {
        public int idCupon { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public String tipoCupon { get; set; }
        public int idNivel { get; set; }
        public int idUsuario { get; set; }
        public int idProducto { get; set; }

        public static List<CuponEntidad> listaCupon = new List<CuponEntidad>();
    }
}
