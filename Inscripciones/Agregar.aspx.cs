using Inscripciones.BLL;
using Inscripciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inscripciones
{
    public partial class Agregar : SecureAdmin
    {
        Operaciones repo = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> lgrad = repo.ObtenerGardos();
                foreach (var item in lgrad)
                {
                    Ddlgrado.Items.Add(item);
                }
                List<string> lgrup = repo.ObtenerGrupos();
                foreach (var item in lgrup)
                {
                    Ddlgrupo.Items.Add(item);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre, matricula, grado, grupo;
            matricula = Txbmatricula.Text;
            nombre = Txbnombre.Text;
            grado = Ddlgrado.SelectedValue.ToString();
            grupo = Ddlgrupo.SelectedValue.ToString();
            repo.Insertar(matricula, nombre, grado, grupo);
            //repo.TAlumnos(grado, grupo);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index_Admin.aspx");
        }
    }
}