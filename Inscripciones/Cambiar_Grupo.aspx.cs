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
    public partial class Cambiar_Grupo : SecureAdmin
    {
        Operaciones repo = new Operaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<int> lid = repo.id_estudiantes();
                foreach (var item in lid)
                {
                    DropDownList1.Items.Add(item.ToString());
                }

                List<string> grupos = repo.ObtenerGrupos();
                foreach (var item in grupos)
                {
                    DropDownList2.Items.Add(item);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom, grado, grupo;

            int id = Convert.ToInt32(DropDownList1.SelectedValue);
            DataSet resul = repo.obtenerEstudiantesxid(id);
            foreach (DataRow x in resul.Tables[0].Rows)
            {
                nom = x["nombre"].ToString();
                grado = x["descripciongrado"].ToString();
                grupo = x["descripciongrupo"].ToString();

                lblnombre.Text = nom;
                lblgrdactual.Text = grado;
                lblgruactual.Text = grupo;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index_Admin.aspx");
        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(DropDownList1.SelectedValue);
                string g = DropDownList2.SelectedValue.ToString();
                repo.c_grupo(g, i);

                Response.Write("<script> alert ('Cambio Exitoso')</script>");
                
                string nom, grado, grupo;

                int id = Convert.ToInt32(DropDownList1.SelectedValue);
                DataSet resul = repo.obtenerEstudiantesxid(id);
                foreach (DataRow x in resul.Tables[0].Rows)
                {
                    nom = x["nombre"].ToString();
                    grado = x["descripciongrado"].ToString();
                    grupo = x["descripciongrupo"].ToString();

                    lblnombre.Text = nom;
                    lblgrdactual.Text = grado;
                    lblgruactual.Text = grupo;
                }
            }
            catch(Exception msj)
            {
                Response.Write("<script> alert ('error "+msj.Message+"')</script>");
                lblgrdactual.Text = "";
                lblgruactual.Text = "";
                lblnombre.Text = "";
            }
        }
    }
}