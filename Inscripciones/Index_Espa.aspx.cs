using Inscripciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inscripciones
{
    public partial class Index_Espa : SecureEspa
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Cambiar Calificación
            Response.Redirect("Califi_Espa.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Buscar por matrícula (español)
            Response.Redirect("Buscar_mat_espa.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["rolusr"] = null;
            Response.Redirect("Ingresar.aspx");
        }
    }
}