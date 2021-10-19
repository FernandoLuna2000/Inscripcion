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
    public partial class MAEstudiante : System.Web.UI.Page
    {
        Operaciones repo = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> lnom = repo.nombres_estudiantes();
                foreach (var item in lnom)
                {
                    DropDownList1.Items.Add(item);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listado.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mat, nom;
            double cali1, cali2, cali3;

            string sn = DropDownList1.SelectedValue.ToString();
            DataSet resul = repo.obtenerEstudiante(sn);
            foreach (DataRow x in resul.Tables[0].Rows)
            {
                mat = x["matricula"].ToString();
                nom = x["nombre"].ToString();
                cali1 = Convert.ToDouble(x["Calificacion1"]);
                cali2 = Convert.ToDouble(x["Calificacion2"]);
                cali3 = Convert.ToDouble(x["Calificacion3"]);
                lblnombre.Text = nom;
                lblmatricula.Text = mat;
                lblcaliactualesp.Text = cali1.ToString();
                lblcaliactualing.Text = cali2.ToString();
                lblcaliactualmat.Text = cali3.ToString();
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = lblnombre.Text;
                double cali1 = Convert.ToDouble(nuevacaliesp.Text);
                double cali2 = Convert.ToDouble(nuevacaliing.Text);
                double cali3 = Convert.ToDouble(nuevacalimat.Text);
                int reprobadas = 0;
                int aprobadas = 0;
                if (cali1 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                if (cali2 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                if (cali3 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                double promedio = (cali1 + cali2 + cali3) / 3;

                repo.actualizar(cali1, cali2, cali3, nom, promedio, aprobadas, reprobadas);

                Response.Write("<script> alert ('Actualizado con éxito')</script>");
                lblnombre.Text = "";
                lblmatricula.Text = "";
                lblcaliactualesp.Text = "";
                lblcaliactualing.Text = "";
                lblcaliactualmat.Text = "";
            }
            catch(Exception msj)
            {
                Response.Write("<script> alert ('error al actualizar"+ msj.Message+"')</script>");
                lblnombre.Text = "";
                lblmatricula.Text = "";
                lblcaliactualesp.Text = "";
                lblcaliactualing.Text = "";
                lblcaliactualmat.Text = "";
            }

        }
    }
}