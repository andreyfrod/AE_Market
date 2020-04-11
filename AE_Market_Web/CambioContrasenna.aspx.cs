using AE_Market_Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AE_Market_Web
{
    public partial class CambioContrasenna : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
        }

       

        protected void btnCambiar_Click(object sender, EventArgs e)
        {
            if (this.txtContrasennaActual.Text!="" && this.txtContrasennaNueva.Text!="")
            {
                UsuarioEntidad user = (UsuarioEntidad)Session["usuario"];

                if (this.txtContrasennaActual.Text==user.password)
                {
                    if (this.txtContrasennaNueva.Text==user.password)
                    {
                        this.lblMensaje.Text = "La contraseña nueva no puede ser igual a la actual";
                    }
                    else
                    {
                        UsuarioLN.cambiarContrasenna(txtContrasennaNueva.Text, user.idUsuario.ToString());
                        this.txtContrasennaActual.Text = "";
                        this.txtContrasennaNueva.Text = "";
                        this.lblMensaje.Text = "Contraseña actualizada con exito";
                    }
                }
                else
                {
                    this.lblMensaje.Text = "La contraseña actual ingresada no coincide con la del usuario";
                }
            }
            

        }
    }
}