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
    public class CuponLN
    {
        public static void Nuevo(CuponEntidad cupon)
        {
            CuponDatos.Insertar(cupon);
        }

        public static CuponEntidad ObtenerCuponporId(int idCupon)
        {
            List<CuponEntidad> lista = new List<CuponEntidad>();
            lista = CuponLN.ObtenerTodos();
            CuponEntidad cupon = new CuponEntidad();
            cupon = (lista.Find(elemento => elemento.idCupon == idCupon));
            return cupon;
        }

        public static List<CuponEntidad> ObtenerCuponporUsuario(int idUsuario)
        {
            List<CuponEntidad> lista = new List<CuponEntidad>();
            List<CuponEntidad> listaCupones = new List<CuponEntidad>();
            lista = CuponLN.ObtenerTodos();
            foreach (var item in lista)
            {
                if (item.idUsuario== idUsuario)
                {
                    listaCupones.Add(item);
                }
            }
          
            return listaCupones;
        }


        public static List<CuponEntidad> ObtenerTodos()
        {
            List<CuponEntidad> lista = new List<CuponEntidad>();
            DataSet ds = CuponDatos.SeleccionarTodos();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                CuponEntidad registro = new CuponEntidad();
                registro.idCupon = Convert.ToInt32(fila["idCupon"]);
                registro.nombre = fila["nombre"].ToString();
                registro.descripcion = fila["descripcion"].ToString();
                registro.tipoCupon = fila["tipoCupon"].ToString();
                registro.idNivel = Convert.ToInt16(fila["idNivel"]);
                registro.idUsuario = Convert.ToInt16(fila["idUsuario"]);
                registro.idProducto = Convert.ToInt16(fila["idProducto"]);
                lista.Add(registro);
            }
            return lista;
        }
    }
}
