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
    public class CompraLN
    {
        

        public static void AgregarProductoLista(CarritoEntidad producto)
        {
            CarritoEntidad.listaCarrito.Add(producto);
        }

        public static void limpiarLista()
        {
            CarritoEntidad.listaCarrito.Clear();
        }

        public static CarritoEntidad encontrarArticuloenCarrito(int Producto)
        {
            CarritoEntidad entidad = CarritoEntidad.listaCarrito.Find(x => x.idProducto == Producto);
            return entidad;
        }

        public static void EliminarProductoLista(int producto)
        {
            CarritoEntidad.listaCarrito.Remove(encontrarArticuloenCarrito(producto));
        }

        public static void actualizarCantidad(int producto, int newCantidad)
        {
            var obj = CarritoEntidad.listaCarrito.FirstOrDefault(x => x.idProducto == producto);
            if (obj != null)
            {
                obj.cantidadProductos = newCantidad;
                obj.total = obj.precio * newCantidad;
            }
        }

        public static void Nuevo(CompraEntidad compra)
        {
            CompraDatos.Insertar(compra);
        }

        public static List<CompraEntidad> ObtenerTodos()
        {
            List<CompraEntidad> lista = new List<CompraEntidad>();
            DataSet ds = CompraDatos.SeleccionarTodos();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                CompraEntidad registro = new CompraEntidad();
                registro.idCompra = Convert.ToInt16(fila["idCompra"]);
                registro.fecha = Convert.ToDateTime(fila["fecha"].ToString());
                registro.idUsuario = Convert.ToInt16(fila["idCompra"]);
                registro.idProducto = Convert.ToInt16(fila["idCompra"]);
                registro.cantidadProductos = Convert.ToInt16(fila["idCompra"]);
                registro.total = Convert.ToDecimal(fila["idCompra"]);

                lista.Add(registro);
            }
            return lista;
        }

        public static List<CompraEntidad> ObtenerComprasporUsuario(int idUsuario)
        {
            List<CompraEntidad> lista = new List<CompraEntidad>();
            lista = CompraLN.ObtenerTodos();
            CompraEntidad compra = new CompraEntidad();
            foreach (var item in lista)
            {
                compra = (lista.Find(elemento => elemento.idUsuario == idUsuario));
                lista.Add(compra);
            }
            
            return lista;
        }

    }
}
