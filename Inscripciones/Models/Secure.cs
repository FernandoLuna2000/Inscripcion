using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inscripciones
{
    public class Secure : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (Session["rolusr"] == null)
            {
                Response.Redirect("Ingresar.aspx");
            }

        }
    }
}