using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapEntidades;
using Cap_Negocio;


namespace CapPresentacion
{
    public partial class Login : Form
    {
        //variables 
        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        Principal frm1 = new Principal();

        //variables para que almacene datos del los usuarios
        public static string usuario_nombre;
        public static string area;
        public static string empleado;

        void p_logueo()
        {
            DataTable dt = new DataTable();
            objeuser.usuario= txtUsuario.Text;
            objeuser.clave= txtContraseña.Text;
            

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();


                frm1.ShowDialog();
               
                

                Login login = new Login();
                login.ShowDialog();
                
                

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Principal());

                txtUsuario.Clear();
                txtContraseña.Clear();
                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            p_logueo();
            


            
            
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
