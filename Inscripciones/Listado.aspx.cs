using Inscripciones.BLL;
using Inscripciones.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inscripciones
{
    public partial class LIstado : SecureAdmin
    {
        Operaciones repo = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> lcat = repo.ObtenerGardos();
                foreach (var item in lcat)
                {
                    DropDownList1.Items.Add(item);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index_Admin.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gr = DropDownList1.SelectedValue.ToString();
            string gru = RadioButtonList1.SelectedValue.ToString();
            DataSet ds = repo.obtenerEstudiantes(gr, gru);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            //lbltalum.Text = repo.TAlumnos(gr, gru).ToString();
            lbltalum.Text = repo.Obtener_tal(gru, gr).ToString();
            lblprogru.Text = repo.obtener_prom(gr, gru).ToString();
        }

        
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gr = DropDownList1.SelectedValue.ToString();
            string gru = RadioButtonList1.SelectedValue.ToString();
            DataSet ds = repo.obtenerEstudiantes(gr, gru);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            lbltalum.Text = repo.Obtener_tal(gru, gr).ToString();
            lblprogru.Text = repo.obtener_prom(gr, gru).ToString();
        }


    }
}