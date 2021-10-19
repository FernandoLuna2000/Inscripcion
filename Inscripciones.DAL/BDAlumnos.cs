using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //espacio de nombre para poder hacer uso de comando SQL
using System.Configuration; //para acceder al Web.config con la referncia a system.configuration
using Inscripciones.DAL.Models;
using System.Data;

namespace Inscripciones.DAL
{
    public class BDAlumnos
    {
        string cadena = ConfigurationManager.ConnectionStrings["CadCon"].ConnectionString;

        public List<Grupos> GetGrupos()
        {
            List<Grupos> resul = new List<Grupos>();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    string query = "Select idGrupo,descripciongrupo from Grupos ";
                    comando.CommandText = query;
                    SqlDataReader Lectura = comando.ExecuteReader();
                    if (Lectura.HasRows)
                    {
                        while (Lectura.Read())
                        {
                            Grupos elemento = new Grupos();
                            elemento.idGrupo = (int)Lectura["idGrupo"];
                            elemento.descripciongrupo = (string)Lectura["descripciongrupo"];

                            resul.Add(elemento);
                        }
                    }

                }
                con.Close();
            }
            return resul;
        }
        public List<Grados> GetGrados()
        {
            List<Grados> resul = new List<Grados>();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    string query = "Select idGrado,descripciongrado from Grados ";
                    comando.CommandText = query;
                    SqlDataReader Lectura = comando.ExecuteReader();
                    if (Lectura.HasRows)
                    {
                        while (Lectura.Read())
                        {
                            Grados elemento = new Grados();
                            elemento.idGrado = (int)Lectura["idGrado"];
                            elemento.descripciongrado = (string)Lectura["descripciongrado"];

                            resul.Add(elemento);
                        }
                    }

                }
                con.Close();
            }
            return resul;
        }
        public DataSet GetEstudiantes(string grado,string grupo)
        {

            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Estudiantes.matricula,Estudiantes.nombre, Estudiantes.Calificacion1,Estudiantes.Calificacion2, Estudiantes.Calificacion3, Estudiantes.promedio,Estudiantes.Aprobadas,Estudiantes.Reprobadas ,Grados.descripciongrado, Grupos.descripciongrupo FROM Estudiantes INNER JOIN Grados ON Grados.idGrado = Estudiantes.idGrado INNER JOIN Grupos ON Grupos.idGrupo = Estudiantes.idGrupo where Estudiantes.idGrado= (select idGrado from Grados where descripciongrado = '" + grado + "' and  descripciongrupo = '" + grupo + "');";
                using (SqlDataAdapter Da = new SqlDataAdapter(query, con))
                {
                    Da.Fill(lista);
                }
            }
            return lista;
        }
        public DataSet GetEstudiantesxid(int id)
        {

            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Estudiantes.nombre,Grados.descripciongrado, Grupos.descripciongrupo FROM Estudiantes INNER JOIN Grados ON Grados.idGrado = Estudiantes.idGrado INNER JOIN Grupos ON Grupos.idGrupo = Estudiantes.idGrupo where Estudiantes.idEstudiantes= "+id+"";
                using (SqlDataAdapter Da = new SqlDataAdapter(query, con))
                {
                    Da.Fill(lista);
                }
            }
            return lista;
        }
        public void InsertarAlumno(string mat, string nom,string Mat1,string mat2,string mat3, int grad, int gru)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@matricula",mat);
                    comando.Parameters.AddWithValue("@nombre", nom);
                    comando.Parameters.AddWithValue("@grado", grad);
                    comando.Parameters.AddWithValue("@grupo", gru);
                    comando.Parameters.AddWithValue("@mate1", Mat1);
                    comando.Parameters.AddWithValue("@mate2", mat2);
                    comando.Parameters.AddWithValue("@mate3", mat3);
                    string query = "insert into Estudiantes values (@matricula,@nombre,'0',@mate1,@mate2,@mate3,'0','0','0','0','0',@grado,@grupo)";
                    comando.CommandText = query;
                    comando.ExecuteNonQuery();

                }
                con.Close();
            }
        }

        public DataSet GetEstudiante(string nombre)
        {

            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "select matricula, nombre, Calificacion1, Calificacion2, Calificacion3 from Estudiantes where nombre = '"+nombre+"'";
                using (SqlDataAdapter Da = new SqlDataAdapter(query, con))
                {
                    Da.Fill(lista);
                }
            }
            return lista;
        }

        public List<Estudiantes> GetlistaEstudiantes()
        {
            List<Estudiantes> resul = new List<Estudiantes>();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    string query = "Select nombre, idEstudiantes from Estudiantes ";
                    comando.CommandText = query;
                    SqlDataReader Lectura = comando.ExecuteReader();
                    if (Lectura.HasRows)
                    {
                        while (Lectura.Read())
                        {
                            Estudiantes elemento = new Estudiantes();
                            elemento.nombre = (string)Lectura["nombre"];
                            elemento.idEstudiantes = (int)Lectura["idEstudiantes"];


                            resul.Add(elemento);
                        }
                    }

                }
                con.Close();
            }
            return resul;
        }

        public void Actualizar_Calificacion(double cal1, double cal2, double cal3, string nombre, double promedio, int apobadas, int reprobadas)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@calificacion1", cal1);
                    comando.Parameters.AddWithValue("@calificacion2", cal2);
                    comando.Parameters.AddWithValue("@calificacion3", cal3);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@promedio", promedio);
                    comando.Parameters.AddWithValue("@reprobadas", reprobadas);
                    comando.Parameters.AddWithValue("@aprobadas", apobadas);
                    string query = "UPDATE Estudiantes SET Calificacion1 = @calificacion1, Calificacion2 = @calificacion2, Calificacion3 = @calificacion3, promedio=@promedio, Reprobadas=@reprobadas, Aprobadas = @aprobadas WHERE nombre = @nombre;";
                    comando.CommandText = query;
                    comando.ExecuteNonQuery();

                }
                con.Close();
            }
        }

        public void cambiar_grupo(int idgrupo, int idestudiante)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@idgrupo", idgrupo);
                    comando.Parameters.AddWithValue("@idestudiantes", idestudiante);
                    string query = "UPDATE Estudiantes SET idGrupo = @idgrupo WHERE idEstudiantes = @idestudiantes;";
                    comando.CommandText = query;
                    comando.ExecuteNonQuery();

                }
                con.Close();
            }
        }

        //public void put_total_alumnos(int grado, int grupo)
        //{
        //    int res = 0;
        //    DataSet lista = new DataSet();
        //    using (SqlConnection con = new SqlConnection(cadena))
        //    {
        //        string query = "select count(*) as total from Estudiantes  where idGrado = '"+grado+"' and idGrupo = '"+grupo+"';";
        //        using (SqlDataAdapter Da = new SqlDataAdapter(query, con))
        //        {
        //            Da.Fill(lista);
        //        }
        //    }
        //    //DataSet resul = lista;
        //    foreach (DataRow x in lista.Tables[0].Rows)
        //    {

        //        res = (int)x["total"];
        //    }
        //    using (SqlConnection con = new SqlConnection(cadena))
        //    {
        //        con.Open();
        //        using (SqlCommand x = new SqlCommand())
        //        {
        //            x.Connection = con;
        //            string query = "UPDATE Grupos SET total_alumnos = "+res+" where idGrupo = "+grupo+"";
        //        }
        //        con.Close();
                
        //    }
        //}

        public int get_total_alumnos(int grupo, int grado)
        {
            int res = 0;
            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "select count(*) as total from Estudiantes  where idGrado = '" + grado + "' and idGrupo = '" + grupo + "';";
                using (SqlDataAdapter Da = new SqlDataAdapter(query, con))
                {
                    Da.Fill(lista);
                }
            }
            foreach (DataRow x in lista.Tables[0].Rows)
            {

                res = (int)x["total"];
            }
            return res;
        }

        public double promedio_grupo(int grado, int grupo)
        {
            double res = 0;
            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "select avg(promedio) as total from Estudiantes where idGrado = '"+grado+ "' and idGrupo = '" + grupo + "'";
                using (SqlDataAdapter Da = new SqlDataAdapter(query, con))
                {
                    Da.Fill(lista);
                }
            }
            foreach (DataRow x in lista.Tables[0].Rows)
            {
                try
                {
                    res = Convert.ToDouble(x["total"]);
                }
                catch (Exception )
                {
                    res = 0;
                }
            }
            return res;
        }

        public DataSet getreprobados()
        {
            DataSet list = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Estudiantes.matricula,Estudiantes.nombre,Estudiantes.Reprobadas ,Grados.descripciongrado, Grupos.descripciongrupo FROM Estudiantes INNER JOIN Grados ON Grados.idGrado = Estudiantes.idGrado INNER JOIN Grupos ON Grupos.idGrupo = Estudiantes.idGrupo where Estudiantes.reprobadas>0 ";
                using (SqlDataAdapter Da = new SqlDataAdapter(query, con))
                {
                    Da.Fill(list);
                }
            }
            return list;
        }

        public List<Estudiantes> getmatriculas()
        {
            List<Estudiantes> final = new List<Estudiantes>();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand commando = new SqlCommand())
                {
                    commando.Connection=con;
                    string query = "select matricula from Estudiantes";
                    commando.CommandText = query;
                    SqlDataReader lectura = commando.ExecuteReader();
                    if (lectura.HasRows)
                    {
                        while (lectura.Read())
                        {
                            Estudiantes x = new Estudiantes();
                            x.matriculas = (string)lectura["matricula"];

                            final.Add(x);
                        }
                    }
                }
                con.Close();
            }
            return final;
        }

        public DataSet Getalumnosxmatricula(string matricula)
        {
            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Estudiantes.matricula,Estudiantes.nombre,Estudiantes.Calificacion1,Estudiantes.Calificacion2,Estudiantes.Calificacion3 ,Grados.descripciongrado, Grupos.descripciongrupo FROM Estudiantes INNER JOIN Grados ON Grados.idGrado = Estudiantes.idGrado INNER JOIN Grupos ON Grupos.idGrupo = Estudiantes.idGrupo where Estudiantes.matricula ='"+matricula+"' ";
                using (SqlDataAdapter DA = new SqlDataAdapter(query, con))
                {
                    DA.Fill(lista);
                }
            }
            return lista;
        }

        public DataSet mayor_prom_A()
        {
            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Estudiantes.nombre,Estudiantes.promedio,Grados.descripciongrado, Grupos.descripciongrupo FROM Estudiantes INNER JOIN Grados ON Grados.idGrado = Estudiantes.idGrado INNER JOIN Grupos ON Grupos.idGrupo = Estudiantes.idGrupo where Estudiantes.promedio= (select max(promedio) from Estudiantes where idGrupo = (select idGrupo from Grupos where descripciongrupo = 'A'))";
                using (SqlDataAdapter DA = new SqlDataAdapter(query, con))
                {
                    DA.Fill(lista);
                }
            }
            return lista;
        }

        public DataSet mayor_prom_B()
        {
            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Estudiantes.nombre,Estudiantes.promedio,Grados.descripciongrado, Grupos.descripciongrupo FROM Estudiantes INNER JOIN Grados ON Grados.idGrado = Estudiantes.idGrado INNER JOIN Grupos ON Grupos.idGrupo = Estudiantes.idGrupo where Estudiantes.promedio= (select max(promedio) from Estudiantes where idGrupo = (select idGrupo from Grupos where descripciongrupo = 'B'))";
                using (SqlDataAdapter DA = new SqlDataAdapter(query, con))
                {
                    DA.Fill(lista);
                }
            }
            return lista;
        }

        public DataSet mayor_prom_C()
        {
            DataSet lista = new DataSet();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Estudiantes.nombre,Estudiantes.promedio,Grados.descripciongrado, Grupos.descripciongrupo FROM Estudiantes INNER JOIN Grados ON Grados.idGrado = Estudiantes.idGrado INNER JOIN Grupos ON Grupos.idGrupo = Estudiantes.idGrupo where Estudiantes.promedio= (select max(promedio) from Estudiantes where idGrupo = (select idGrupo from Grupos where descripciongrupo = 'C'))";
                using (SqlDataAdapter DA = new SqlDataAdapter(query, con))
                {
                    DA.Fill(lista);
                }
            }
            return lista;
        }

        //Validar al cliente y devolver si es válido y su Rol

        public string ValidarRol(string usrnm, string pass)
        {
            string res=null;

            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@NU", usrnm);
                    comando.Parameters.AddWithValue("@PS", pass);
                    string query = "Select Descripcion from Roles where idRol = (Select idRol from Usuarios where Username = @NU and password = @PS)";
                    comando.CommandText = query;
                    SqlDataReader Lectura = comando.ExecuteReader();
                    if (Lectura.HasRows)
                    {
                        Lectura.Read();
                        res = (string)Lectura["Descripcion"];

                    }

                }

                con.Close();
            }
            return res;
        }



        //nuevo método
        public void Actualizar_Calificacion_Mate(double cal3, string nombre)
        {
            Estudiantes elemento = new Estudiantes();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    string query = "Select Calificacion1,Calificacion2 from Estudiantes where nombre = @nombre";
                    comando.CommandText = query;
                    SqlDataReader Lectura = comando.ExecuteReader();
                    if (Lectura.HasRows)
                    {
                        while (Lectura.Read())
                        {
                            
                            elemento.Calificacion1 = (double)Lectura["Calificacion1"];
                            elemento.Calificacion2 = (double)Lectura["Calificacion2"];
                        }

                    }

                }
                con.Close();
                int reprobadas = 0;
                int aprobadas = 0;
                if (elemento.Calificacion1 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                if (elemento.Calificacion2 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                if (cal3 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                double promedio = (elemento.Calificacion1 + elemento.Calificacion2 + cal3) / 3;
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@calificacion1", elemento.Calificacion1);
                    comando.Parameters.AddWithValue("@calificacion2", elemento.Calificacion2);
                    comando.Parameters.AddWithValue("@calificacion3", cal3);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@promedio", promedio);
                    comando.Parameters.AddWithValue("@reprobadas", reprobadas);
                    comando.Parameters.AddWithValue("@aprobadas", aprobadas);
                    string query = "UPDATE Estudiantes SET Calificacion1 = @calificacion1, Calificacion2 = @calificacion2, Calificacion3 = @calificacion3, promedio=@promedio, Reprobadas=@reprobadas, Aprobadas = @aprobadas WHERE nombre = @nombre;";
                    comando.CommandText = query;
                    comando.ExecuteNonQuery();

                }
                con.Close();
            }
        }

        public void Actualizar_Calificacion_Espa(double cal1, string nombre)
        {
            Estudiantes elemento = new Estudiantes();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    string query = "Select Calificacion3,Calificacion2 from Estudiantes where nombre = @nombre";
                    comando.CommandText = query;
                    SqlDataReader Lectura = comando.ExecuteReader();
                    if (Lectura.HasRows)
                    {
                        while (Lectura.Read())
                        {

                            elemento.Calificacion3 = (double)Lectura["Calificacion3"];
                            elemento.Calificacion2 = (double)Lectura["Calificacion2"];
                        }

                    }

                }
                con.Close();
                int reprobadas = 0;
                int aprobadas = 0;
                if (elemento.Calificacion3 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                if (elemento.Calificacion2 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                if (cal1 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                double promedio = (elemento.Calificacion3 + elemento.Calificacion2 + cal1) / 3;
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@calificacion1", cal1);
                    comando.Parameters.AddWithValue("@calificacion2", elemento.Calificacion2);
                    comando.Parameters.AddWithValue("@calificacion3", elemento.Calificacion3);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@promedio", promedio);
                    comando.Parameters.AddWithValue("@reprobadas", reprobadas);
                    comando.Parameters.AddWithValue("@aprobadas", aprobadas);
                    string query = "UPDATE Estudiantes SET Calificacion1 = @calificacion1, Calificacion2 = @calificacion2, Calificacion3 = @calificacion3, promedio=@promedio, Reprobadas=@reprobadas, Aprobadas = @aprobadas WHERE nombre = @nombre;";
                    comando.CommandText = query;
                    comando.ExecuteNonQuery();

                }
                con.Close();
            }
        }

        public void Actualizar_Calificacion_Ing(double cal2, string nombre)
        {
            Estudiantes elemento = new Estudiantes();
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    string query = "Select Calificacion1,Calificacion3 from Estudiantes where nombre = @nombre";
                    comando.CommandText = query;
                    SqlDataReader Lectura = comando.ExecuteReader();
                    if (Lectura.HasRows)
                    {
                        while (Lectura.Read())
                        {

                            elemento.Calificacion1 = (double)Lectura["Calificacion1"];
                            elemento.Calificacion3 = (double)Lectura["Calificacion3"];
                        }

                    }

                }
                con.Close();
                int reprobadas = 0;
                int aprobadas = 0;
                if (elemento.Calificacion1 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                if (elemento.Calificacion3 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                if (cal2 < 6)
                {
                    reprobadas++;
                }
                else
                {
                    aprobadas++;
                }
                double promedio = (elemento.Calificacion1 + elemento.Calificacion3 + cal2) / 3;
                con.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = con;
                    comando.Parameters.AddWithValue("@calificacion1", elemento.Calificacion1);
                    comando.Parameters.AddWithValue("@calificacion2", cal2);
                    comando.Parameters.AddWithValue("@calificacion3", elemento.Calificacion3);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@promedio", promedio);
                    comando.Parameters.AddWithValue("@reprobadas", reprobadas);
                    comando.Parameters.AddWithValue("@aprobadas", aprobadas);
                    string query = "UPDATE Estudiantes SET Calificacion1 = @calificacion1, Calificacion2 = @calificacion2, Calificacion3 = @calificacion3, promedio=@promedio, Reprobadas=@reprobadas, Aprobadas = @aprobadas WHERE nombre = @nombre;";
                    comando.CommandText = query;
                    comando.ExecuteNonQuery();

                }
                con.Close();
            }
        }
    }
}