using Inscripciones.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inscripciones
{
    public partial class Ingresar : System.Web.UI.Page
    {
        Operaciones repo = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnac_Click(object sender, EventArgs e)
        {
            string nom = Txbuser.Text;
            string pas = Txpass.Text;

            string r = repo.obt_rol(nom, pas);

            if (r == null)
            {
                Response.Write("<script> alert('Usuario no valido');</script>");
                Txbuser.Text = "";
                Txpass.Text = "";
            }
            else
            {
                Session["rolusr"] = r;
                Response.Redirect("Redirec.aspx");
            }
        }
    }
}