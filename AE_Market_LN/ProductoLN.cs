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
            DataSet ds = BicicletaDatos.SeleccionarTodos();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                ProductoEntidad registro = new ProductoEntidad();
                registro.idBicicleta = Convert.ToInt16(fila["idBicicleta"]);
                registro.nombre = fila["nombre"].ToString();
                registro.descripcion = fila["descripcion"].ToString();
                registro.precioHora = Convert.ToDecimal(fila["precioHora"]);
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
    }
}
