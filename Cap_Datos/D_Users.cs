using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapEntidades;

namespace Cap_Datos
{
    public class D_Users
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_user(E_Users obje)
        {

            SqlCommand cmd = new SqlCommand("sp_logueo_ez", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@clave", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public string D_mantenimiento_visita(E_Users obje)
        {
            throw new NotImplementedException();
        }
        public string D_mantenimiento_usuario(E_Users obje)
        {
            throw new NotImplementedException();
        }

        public DataTable D_listar_visitas()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_visitas", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_listar_usuarios()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_usuarios", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_visitas(E_Users obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_visitas", cn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter (cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_buscar_visitas_edificios(E_Users obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_visitas_edificios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@edificios", obje.edificio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_visitas(E_Users obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_visitas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            cmd.Parameters.AddWithValue("@edad", obje.edad);
            cmd.Parameters.AddWithValue("@telefono", obje.telefono);
            cmd.Parameters.AddWithValue("@apellido", obje.apellido);
            cmd.Parameters.AddWithValue("@edificio", obje.edificio);
            cmd.Parameters.AddWithValue("@entrada", obje.entrada);
            cmd.Parameters.AddWithValue("@salida", obje.salida);
            cmd.Parameters.AddWithValue("@motivo", obje.motivo);
            cmd.Parameters.AddWithValue("@aula", obje.aula);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }
        public string D_mantenimiento_usuarios(E_Users obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_usuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_nivel", obje.nivel);
            cmd.Parameters.AddWithValue("@id_usuario", obje.idUsuario);
            cmd.Parameters.AddWithValue("@nombre", obje.nombreUsuario);
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@contraseña", obje.contraseña);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accionUsuario;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }





    }
}
