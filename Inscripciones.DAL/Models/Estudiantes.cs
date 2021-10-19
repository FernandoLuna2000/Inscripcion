using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripciones.DAL.Models
{
    public class Estudiantes
    {
        public int idEstudiantes { set; get; }
        public string matriculas { set; get; }
        public string nombre { set; get; }
        public double promedio { set; get; }
        public string Materia1 { set; get; }
        public string Materia2 { set; get; }
        public string Materia3 { set; get; }
        public double Calificacion1 { set; get; }
        public double Calificacion2 { set; get; }
        public double Calificacion3 { set; get; }
        public int idGrado { set; get; }
        public int idGrupo { set; get; }

    }
}
