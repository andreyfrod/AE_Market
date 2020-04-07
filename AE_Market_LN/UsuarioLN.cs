using AE_Market_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using AE_Market_Datos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
   public class UsuarioLN
    {
        public static List<UsuarioEntidad> ObtenerTodos()
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
            DataSet ds = UsuarioDatos.SeleccionarTodos();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                UsuarioEntidad registro = new UsuarioEntidad();
                registro.idUsuario = Convert.ToInt16(fila["idUsuario"]);
                registro.nombre = fila["nombre"].ToString();
                registro.email = fila["email"].ToString();
                registro.password = fila["password"].ToString();
                lista.Add(registro);
            }
            return lista;
        }
        public static UsuarioEntidad Obtener(int idUsuario)
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
            lista = UsuarioLN.ObtenerTodos();
            UsuarioEntidad user = new UsuarioEntidad();
            user = (lista.Find(elemento => elemento.idUsuario == idUsuario));
            return user;
        }
        public static UsuarioEntidad verificarCredenciales(UsuarioEntidad usuario)
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
            lista = UsuarioLN.ObtenerTodos();
            UsuarioEntidad user = new UsuarioEntidad();
            user = (lista.Find(elemento => elemento.email == usuario.email && elemento.password == usuario.password));
            return user;
        }
    }
}
