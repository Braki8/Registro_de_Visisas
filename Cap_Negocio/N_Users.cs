using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Cap_Datos;
using CapEntidades;

namespace Cap_Negocio
{
    public class N_Users
    {

        D_Users objd = new D_Users();

        public DataTable N_user(E_Users obje)
        {
            return objd.D_user(obje);
        }
        public DataTable N_listar_visitas()
        {
            return objd.D_listar_visitas();
        }
        public DataTable N_buscar_visitas(E_Users obje)
        {
            return objd.D_buscar_visitas(obje);
        }
        public String N_mantenimiento_visitas(E_Users obje)
        {
            return objd.D_mantenimiento_visitas(obje);
        }
        public DataTable N_buscar_visitas_edificios(E_Users obje)
        {
            return objd.D_buscar_visitas_edificios(obje);

        }

        public object N_buscar_visitas_edificios()
        {
            throw new NotImplementedException();
        }

        //Datos de usuario

        public DataTable N_listar_usuarios()
        {
            return objd.D_listar_usuarios();
        }
        public String N_mantenimiento_usuarios(E_Users obje)
        {
            return objd.D_mantenimiento_usuarios(obje);
        }
    }
}
