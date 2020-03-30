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
    public class ProductoDatos
    {
        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_ListarProductos");
            comando.CommandType = CommandType.StoredProcedure;
            DataSet ds = db.ExecuteReader(comando, "producto");
            return ds;
        }
    }
}
