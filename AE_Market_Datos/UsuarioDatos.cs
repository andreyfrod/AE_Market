
using AE_Market_Entidades;
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
    public class UsuarioDatos
    {

        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_ListarUsuarios");
            comando.CommandType = CommandType.StoredProcedure;
            DataSet ds = db.ExecuteReader(comando, "usuario");
            return ds;
        }

        public static void Insertar(UsuarioEntidad usuario)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_InsertarUsuario");
            comando.CommandType = CommandType.StoredProcedure;
            //Parámetros
            comando.Parameters.AddWithValue("@tipoUsuario", usuario.tipoUsuario);
            comando.Parameters.AddWithValue("@nombre", usuario.nombre);
            comando.Parameters.AddWithValue("@idNivel", usuario.nivelEntidad.idNivel);
            comando.Parameters.AddWithValue("@direccion", usuario.direccion);
            comando.Parameters.AddWithValue("@telefono", usuario.telefono);
            comando.Parameters.AddWithValue("@email", usuario.email);
            comando.Parameters.AddWithValue("@password", usuario.password);
            db.ExecuteNonQuery(comando);
        }
        //Modificar un usuario
        public static void CambiarContrasenna(String contrasenna, String idUsuario)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("UPDATE [AE_Market].[dbo].[usuario] SET password = "+contrasenna +" WHERE idUsuario ="+idUsuario);
            comando.CommandType = CommandType.Text;
            //Parámetros
   
            db.ExecuteNonQuery(comando);
        }
    }
}
