using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //todos los botones
            if (Login.area == "Admin")
            {
               btRegistro.Enabled = true;
               btVisitas.Enabled = true;
               btNuevoUsuario.Enabled = true;

            }
            //menos un boton
            else if (Login.area == "Visita")
            {
                btRegistro.Enabled = true;
                btVisitas.Enabled = false;
                btNuevoUsuario.Enabled = false;
            }

           

        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            

            Registro reg = new Registro();

            reg.Show();
        }

        private void btVisitas_Click(object sender, EventArgs e)
        {
            Visitas vis = new Visitas();
            vis.Show();
        }

        private void btNuevoUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Show();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
