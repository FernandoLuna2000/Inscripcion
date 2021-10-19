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
    
    public partial class Mejores_Promedios : SecureAdmin
    {
        Operaciones repo = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = repo.obt_prom_A();
                GridView1.DataBind();
                GridView2.DataSource = repo.obt_prom_B();
                GridView2.DataBind();
                GridView3.DataSource = repo.obt_prom_C();
                GridView3.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index_Admin.aspx");
        }
    }
}