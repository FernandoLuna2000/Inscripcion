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
    public partial class Califi_Ing : SecureIng
    {
        Operaciones repo = new Operaciones();
        string mat, nom;
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
            Response.Redirect("Index_Inglés.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sn = DropDownList1.SelectedValue.ToString();
            double cali;
            DataSet resul = repo.obtenerEstudiante(sn);
            foreach (DataRow x in resul.Tables[0].Rows)
            {

                mat = x["matricula"].ToString();
                nom = x["nombre"].ToString();
                cali = Convert.ToDouble(x["Calificacion2"]);
                lblnombre.Text = nom;
                lblmatricula.Text = mat;
                lblcaliactualmat.Text = cali.ToString();
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = lblnombre.Text;
                double ncali = Convert.ToDouble(nuevacaliesp.Text);

                repo.Act_Cal_Ing(ncali, nom);

                Response.Write("<script> alert ('Actualizado con éxito')</script>");
                lblnombre.Text = "";
                lblmatricula.Text = "";
            }
            catch (Exception msj)
            {
                Response.Write("<script> alert ('error al actualizar:" + msj.Message + "')</script>");
                lblnombre.Text = "";
                lblmatricula.Text = "";
                lblcaliactualmat.Text = "";
            }

        }
    }
}