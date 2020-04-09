using Entidades;
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
        public NivelEntidad nivelEntidad { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public String password { get; set; }
    }
}
