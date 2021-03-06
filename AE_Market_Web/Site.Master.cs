﻿using AE_Market_Entidades;
using Entidades;
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
        public List<CarritoEntidad> listaCarrito { get { return CarritoEntidad.listaCarrito; } }
        private object linkLogin;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                lblNombreUsuario.Visible = true;
                linkLogout.Visible = true;
                lblIniciaSesion.Visible = false;
                lblRegistrarUsuario.Visible = true;
                lblCambioContrasenna.Visible = true;
                lblCupon.Visible = true;
                lblListaCupones.Visible = true;

                UsuarioEntidad user = (UsuarioEntidad)Session["usuario"];
                lblNombreUsuario.Text = user.nombre;
                if (user.tipoUsuario=="Cliente")
                {
                    lblNivel.Text = user.nivelEntidad.descripcion;
                    lblNivel.Visible = true;
                    lblRegistrarUsuario.Visible = false;
                    lblCupon.Visible = false;
                }

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