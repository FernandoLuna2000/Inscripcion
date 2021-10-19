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
    public partial class Buscar_mat_Espa : SecureEspa
    {
        Operaciones repo = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> lmat = repo.matriculas();
                foreach (var i in lmat)
                {
                    DDLmatriculas.Items.Add(i);
                }
            }
        }

        protected void DDLmatriculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matricula = DDLmatriculas.SelectedValue.ToString();
            //int matricula = Convert.ToInt32(DDLmatriculas.SelectedValue);
            DataSet res = repo.obt_estudiante_xmatricula(matricula);
            GVAlumnos.DataSource = res.Tables[0];
            GVAlumnos.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index_Espa.aspx");
        }
    }
}