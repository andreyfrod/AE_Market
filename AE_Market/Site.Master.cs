using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AE_Market
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblNombreUsuario.Visible = true;
                linkLogout.Visible = true;

                UserEntidad user = (UserEntidad)Session["user"];
                lblNombreUsuario.Text = user.nombreUser;

            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}