using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class UsuarioEntidad
    {
        public int idUsuario { get; set; }
        public String tipoUsuario { get; set; }
        public String nombre { get; set; }
        public String nivel { get; set; }
        public String email { get; set; }
        public String password { get; set; }
    }
}
