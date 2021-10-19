using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inscripciones.Models
{
    public class SecureEspa: System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            string r = (string)Session["rolusr"];
            if (r != "Co_Español")
            {
                Response.Redirect("Ingresar.aspx");
            }

        }
    }
}