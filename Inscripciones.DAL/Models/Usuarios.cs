using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripciones.DAL.Models
{
    public class Usuarios
    {
        public int idUsuario { set; get; }
        public string Nombre { set; get; }
        public string Username { set; get; }
        public string password { set; get; }
        public int idRol { set; get; }
    }
}
