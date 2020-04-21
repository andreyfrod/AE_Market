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
   public class CuponDatos
    {
        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("select * from [AE_Market].[dbo].[cupon]");
            comando.CommandType = CommandType.Text;
            DataSet ds = db.ExecuteReader(comando, "cupon");
            return ds;

        }

        public static void Insertar(CuponEntidad cupon)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_InsertarCupon");
            comando.CommandType = CommandType.StoredProcedure;
            //Parámetros
            comando.Parameters.AddWithValue("@nombre", cupon.nombre);
            comando.Parameters.AddWithValue("@descripcion", cupon.descripcion);
            comando.Parameters.AddWithValue("@tipoCupon", cupon.tipoCupon);
            comando.Parameters.AddWithValue("@idNivel", cupon.idNivel);
            comando.Parameters.AddWithValue("@idUsuario", cupon.idUsuario);
            comando.Parameters.AddWithValue("@idProducto", cupon.idProducto);
            db.ExecuteNonQuery(comando);
        }
    }
}
