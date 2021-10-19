using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inscripciones.Models;

namespace Inscripciones
{
    public partial class Redirec : Secure
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string r = (string)Session["rolusr"];
            switch (r)
            {
                case "Administrador":
                    Response.Redirect("Index_Admin.aspx");
                    break;
                case "Co_Matemáticas":
                    Response.Redirect("Index_Mate.aspx");
                    break;
                case "Co_Español":
                    Response.Redirect("Index_Espa.aspx");
                    break;
                case "Co_Inglés":
                    Response.Redirect("Index_Inglés.aspx");
                    break;
            }
        }
    }
}