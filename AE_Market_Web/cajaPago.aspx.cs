using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AE_Market_Web
{
    public partial class cajaPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                Int32 totalCompra;
                //Obtener una variable Query String
                if (!String.IsNullOrEmpty(Request.QueryString["total"]))
                {
                    if (Int32.TryParse(Request.QueryString["total"], out totalCompra))
                    {
                        this.lblTotal.Text = totalCompra.ToString();
                    }
                }
               
            }
        }
    }
}