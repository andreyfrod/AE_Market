using AE_Market_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaWeb
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                UsuarioEntidad user = new UsuarioEntidad();
                user.nombre = txtNombreUsuario.Text;
                user.password = txtPassword.Text;
                //user = UserLN.Obtener(user);
                if (user != null)
                {
                    Session["user"] = user;
                    ClientScript.RegisterStartupScript(
                   this.GetType(),
                   "Login",
"mensajeRedirect('Login','Credenciales correctas','success','listado.aspx')",
                   true
                   );
                }
                else
                {
                    ClientScript.RegisterStartupScript(
                   this.GetType(),
                   "Login",
"mensajeRedirect('Login','Verifique las credenciales','error','login.aspx')",
                   true
                   );
                }

            }

        }
    }
}