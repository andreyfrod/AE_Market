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
    public class ProductoLN
    {
        public static List<ProductoEntidad> ObtenerTodos()
        {
            List<ProductoEntidad> lista = new List<ProductoEntidad>();
            DataSet ds = ProductoDatos.SeleccionarTodos();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                ProductoEntidad registro = new ProductoEntidad();
                registro.idProducto = Convert.ToInt32(fila["idProducto"]);
                registro.tipoProducto = fila["tipoProducto"].ToString();
                registro.nombre = fila["nombre"].ToString();
                registro.descripcion = fila["descripcion"].ToString();
                registro.precio = Convert.ToDecimal(fila["precio"]);
                lista.Add(registro);
            }
            return lista;
        }
        public static ProductoEntidad Obtener(int idProducto)
        {
            List<ProductoEntidad> lista = ProductoLN.ObtenerTodos();
            ProductoEntidad prod = lista.Find(elemento => elemento.idProducto == idProducto);
            return prod;
        }

        public static List<ProductoEntidad> ObtenerTipo(String tipoProducto)
        {
            List<ProductoEntidad> lista = ProductoLN.ObtenerTodos();
            List<ProductoEntidad> prod = lista.Where(elemento => elemento.tipoProducto == tipoProducto).ToList();
            return prod;
        }
    }
}
