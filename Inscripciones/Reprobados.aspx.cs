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
    public partial class Reprobados : SecureAdmin
    {
        Operaciones repo = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet rs = repo.obt_reprobados();
                GVRepro.DataSource = rs.Tables[0];
                GVRepro.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index_Admin.aspx");
        }
    }
}