using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE_Market_Entidades
{
    public class UsuarioEntidad
    {
        public int idUsuario { get; set; }
        public String tipoUsuario { get; set; }
        public String nombre { get; set; }
        public String nivel { get; set; }
        public String email { get; set; }
        public String password { get; set; }
    }
}
