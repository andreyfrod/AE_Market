using AE_Market_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class NivelLN
    {
        public static List<NivelEntidad> ObtenerTodos()
        {
            List<NivelEntidad> lista = new List<NivelEntidad>();
            DataSet ds = NivelDatos.SeleccionarTodos();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                NivelEntidad registro = new NivelEntidad();
                registro.monto = Convert.ToDouble(fila["monto"]);
                registro.descripcion = fila["descripcion"].ToString();
                registro.idNivel = Convert.ToInt16(fila["idNivel"]); 
                lista.Add(registro);
            }
            return lista;
        }
        public static NivelEntidad Obtener(int idNivel)
        {
            List<NivelEntidad> lista = new List<NivelEntidad>();
            lista = NivelLN.ObtenerTodos();
            NivelEntidad user = new NivelEntidad();
            user = (lista.Find(elemento => elemento.idNivel == idNivel));
            return user;
        }
    }
}
