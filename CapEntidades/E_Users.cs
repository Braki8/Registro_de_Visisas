using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapEntidades
{
    public class E_Users
    {
        


        public DataTable N_user(E_Users objeuser)
        {
            throw new NotImplementedException();
        }
        //Objetos del registro
        public String nombre { get; set; }

        public String codigo { get; set; }

        public int edad { get; set; }

        public int telefono { get; set; }

        public string apellido { get; set; }

        public int edificio { get; set; }

        public string entrada { get; set; }

        public string salida { get; set; }

        public string motivo { get; set; }

        public string aula { get; set; }

        public String accion { get; set; }


        //Objetos del usuario



        public string nivel { get; set; }

        public string idUsuario { get; set; }

        public string nombreUsuario { get; set; }

        public string contraseña { get; set; }

        public string usuario { get; set; }

        public string clave { get; set; }

        public string accionUsuario { get; set; }
    }
}
