﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

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

                UsuarioEntidad user = (UsuarioEntidad)Session["user"];
                lblNombreUsuario.Text = user.nombre;
            }
        }

        protected void linkLogout_Click(object sender, EventArgs e)
        {

        }
    }
}