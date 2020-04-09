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
    public class NivelDatos
    {

        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("select * from [AE_Market].[dbo].[nivel]");
            comando.CommandType = CommandType.Text;
            DataSet ds = db.ExecuteReader(comando, "nivel");
            return ds;
        }
    }
}
