using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inscripciones.DAL;
using System.Data.SqlClient;
using Inscripciones.DAL.Models;

namespace Inscripciones.BLL
{
    public class Operaciones
    {
        BDAlumnos datos = new BDAlumnos();
        public DataSet obtenerEstudiantes(string gra, string gru)
        {
            return datos.GetEstudiantes(gra, gru);
        }
        public DataSet obtenerEstudiantesxid(int i)
        {
            return datos.GetEstudiantesxid(i);
        }

        public DataSet obtenerEstudiante(string nom)
        {
            return datos.GetEstudiante(nom);
        }

        public List<string> nombres_estudiantes()
        {
            List<string> lnombres = new List<string>();
            foreach (Estudiantes cad in datos.GetlistaEstudiantes())
            {
                lnombres.Add(cad.nombre);
            }
            return lnombres;
        }

        public void c_grupo(string grupo, int estu)
        {
            int g = 0;
            switch (grupo)
            {
                case "A":
                    g = 1;
                    break;
                case "B":
                    g = 2;
                    break;
                case "C":
                    g = 3;
                    break;
            }
            datos.cambiar_grupo(g, estu);
        }
        public List<int> id_estudiantes()
        {
            List<int> lid = new List<int>();
            foreach (Estudiantes cad in datos.GetlistaEstudiantes())
            {
                lid.Add(cad.idEstudiantes);
            }
            return lid;
        }

        public List<string> ObtenerGardos()
        {
            List<string> lgrados = new List<string>();
            foreach (Grados cad in datos.GetGrados())
            {
                lgrados.Add(cad.descripciongrado);
            }
            return lgrados;
        }
        public List<string> ObtenerGrupos()
        {
            List<string> lgrupos = new List<string>();
            foreach (Grupos cad in datos.GetGrupos())
            {
                lgrupos.Add(cad.descripciongrupo);
            }
            return lgrupos;
        }

        public void Insertar(string ma, string nm, string gra, string gr)
        {
            string mat1="";
            string mat2 = "";
            string mat3 = "";

            int grado=0;
            int grupo = 0;
            switch (gra)
            {
                case "Primero":
                    grado = 1;
                    mat1 = "Español I";
                    mat2 = "Inglés I";
                    mat3 = "Matemáticas I";
                    break;
                case "Segundo":
                    grado = 2;
                    mat1 = "Español II";
                    mat2 = "Inglés II";
                    mat3 = "Matemáticas II";
                    break;
                case "Tercero":
                    grado = 3;
                    mat1 = "Español III";
                    mat2 = "Inglés III";
                    mat3 = "Matemáticas III";
                    break;
            }
            switch (gr)
            {
                case "A":
                    grupo = 1;
                    break;
                case "B":
                    grupo = 2;
                    break;
                case "C":
                    grupo = 3;
                    break;
            }
            
            datos.InsertarAlumno(ma, nm, mat1,mat2, mat3, grado, grupo);
        }

        public void actualizar(double cal1, double cal2, double cal3, string nombre, double prom, int apro, int repro)
        {
            datos.Actualizar_Calificacion(cal1, cal2, cal3, nombre, prom, apro, repro);
        }

        //public void TAlumnos(string grado, string grupo)
        //{
        //    int p_grado = 0;
        //    int p_grupo = 0;
        //    switch (grado)
        //    {
        //        case "Primero":
        //            p_grado = 1;
        //            break;
        //        case "Segundo":
        //            p_grado = 2;
        //            break;
        //        case "Tercero":
        //            p_grado = 3;
        //            break;
        //    }
        //    switch (grupo)
        //    {
        //        case "A":
        //            p_grupo = 1;
        //            break;
        //        case "B":
        //            p_grupo = 2;
        //            break;
        //        case "C":
        //            p_grupo = 3;
        //            break;
        //    }

        //    datos.put_total_alumnos(p_grado, p_grupo);
        //}

        public int Obtener_tal(string grupo, string grado)
        {
            int p_grado = 0;
            int p_grupo = 0;
            switch (grado)
            {
                case "Primero":
                    p_grado = 1;
                    break;
                case "Segundo":
                    p_grado = 2;
                    break;
                case "Tercero":
                    p_grado = 3;
                    break;
            }
            switch (grupo)
            {
                case "A":
                    p_grupo = 1;
                    break;
                case "B":
                    p_grupo = 2;
                    break;
                case "C":
                    p_grupo = 3;
                    break;
            }
            return datos.get_total_alumnos(p_grupo, p_grado);
        }

        public double obtener_prom(string grado, string grupo)
        {
            int p_grado = 0;
            int p_grupo = 0;
            switch (grado)
            {
                case "Primero":
                    p_grado = 1;
                    break;
                case "Segundo":
                    p_grado = 2;
                    break;
                case "Tercero":
                    p_grado = 3;
                    break;
            }
            switch (grupo)
            {
                case "A":
                    p_grupo = 1;
                    break;
                case "B":
                    p_grupo = 2;
                    break;
                case "C":
                    p_grupo = 3;
                    break;
            }
            return datos.promedio_grupo(p_grado, p_grupo);
        }

        public DataSet obt_reprobados()
        {
            return datos.getreprobados();
        }

        public List<string> matriculas()
        {
            List<string> matriculas = new List<string>();
            foreach (Estudiantes x in datos.getmatriculas())
            {
                matriculas.Add(x.matriculas);
            }
            return matriculas;
        }

        public DataSet obt_estudiante_xmatricula(string matricula)
        {
            return datos.Getalumnosxmatricula(matricula);
        }

        public DataSet obt_prom_A()
        {
            return datos.mayor_prom_A();
        }
        public DataSet obt_prom_B()
        {
            return datos.mayor_prom_B();
        }
        public DataSet obt_prom_C()
        {
            return datos.mayor_prom_C();
        }

        public string obt_rol(string Us, string pass)
        {
            return datos.ValidarRol(Us, pass);
        }

        //nuevo método
        public void Act_Cal_Mat(double cal, string nom)
        {
           datos.Actualizar_Calificacion_Mate(cal, nom);
        }
        public void Act_Cal_Esp(double cal, string nom)
        {
            datos.Actualizar_Calificacion_Espa(cal, nom);
        }
        public void Act_Cal_Ing(double cal, string nom)
        {
            datos.Actualizar_Calificacion_Ing(cal, nom);
        }
    }
}
