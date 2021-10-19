using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Inscripciones.BLL;
using Inscripciones.Models;

namespace Inscripciones
{
    public partial class Index_Admin : SecureAdmin
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Inscribir un Alumno
            Response.Redirect("Agregar.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //cambiar de Grupo
            Response.Redirect("Cambiar_Grupo.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //listar alumno
            Response.Redirect("Listado.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //reprobados
            Response.Redirect("Reprobados.aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //buscar por matrícuals (ALL)
            Response.Redirect("Alm_matriculas.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Cuadro de Honor
            Response.Redirect("Mejores_Promedios.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Session["rolusr"] = null;
            Response.Redirect("Ingresar.aspx");
        }
    }
}