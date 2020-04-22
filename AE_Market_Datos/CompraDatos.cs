using Entidades;
using PracticaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE_Market_Datos
{
  public  class CompraDatos
    {

        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_ListarCompras");
            comando.CommandType = CommandType.StoredProcedure;
            DataSet ds = db.ExecuteReader(comando, "compra");
            return ds;
        }

        public static void Insertar(CompraEntidad compra)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_InsertarCompra");
            comando.CommandType = CommandType.StoredProcedure;
            //Parámetros
            comando.Parameters.AddWithValue("@fecha", compra.fecha);
            comando.Parameters.AddWithValue("@idUsuario", compra.idUsuario);
            comando.Parameters.AddWithValue("@idProducto", compra.idProducto);
            comando.Parameters.AddWithValue("@cantidadProductos", compra.cantidadProductos);
            comando.Parameters.AddWithValue("@total", compra.total);
            db.ExecuteNonQuery(comando);
        }

    }
}
