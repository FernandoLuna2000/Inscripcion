using Inscripciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inscripciones
{
    public partial class Index_Inglés : SecureIng
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            //cerrar sesión
            Session["rolusr"] = null;
            Response.Redirect("Ingresar.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //cambiar calificación
            Response.Redirect("Califi_Ing.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            //Buscar por Matrícula (Inglés)
            Response.Redirect("Buscar_mat_Ing.aspx");
        }
    }
}