using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inscripciones.Models
{
    public class SecureMate: System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            string r = (string)Session["rolusr"];
            if (r != "Co_Matemáticas")
            {
                Response.Redirect("Ingresar.aspx");
            }

        }
    }
}