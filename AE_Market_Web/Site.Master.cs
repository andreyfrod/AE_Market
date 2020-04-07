using AE_Market_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AE_Market_Web
{
    public partial class SiteMaster : MasterPage
    {
        private object linkLogin;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                lblNombreUsuario.Visible = true;
                linkLogout.Visible = true;
                

                UsuarioEntidad user = (UsuarioEntidad)Session["usuario"];
                lblNombreUsuario.Text = user.email;

            }
            //else
            //{
            //    Response.Redirect("credenciales.aspx");
            //}
        }

        protected void linkLogout_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {

                lblNombreUsuario.Visible = false;
                linkLogout.Visible = false;
                
                Session.Clear();
                Session.RemoveAll();
                Session.Abandon();
                Response.Redirect("inicioSesion.aspx");
            }
        }
    }
}