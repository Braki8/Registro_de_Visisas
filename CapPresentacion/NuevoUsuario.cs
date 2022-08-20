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
    public partial class NuevoUsuario : Form


    {
        E_Users objent = new E_Users();
        N_Users objneg = new N_Users();
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_usuarios();
        }
        void mantenimiento(String accion)
        {
            objent.idUsuario = txtID.Text;
            objent.nombreUsuario = txtNombre.Text;
            objent.usuario = txtUsuario1.Text;
            objent.contraseña = txtContraseña.Text;
            objent.nivel = txtNivel.Text;
            
            objent.accionUsuario = accion;
            String men = objneg.N_mantenimiento_usuarios(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtUsuario1.Text = "";
            txtContraseña.Text = "";
            txtNivel.Text = "";

            dataGridView1.DataSource = objneg.N_listar_usuarios();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNivel.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }

            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNivel.Text != "")
            {
                if (MessageBox.Show("¿Deseas Modificar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }

            }

        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtNivel.Text != "")
            {
                if (MessageBox.Show("¿Deseas Eliminar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtID.Text = dataGridView1[0, fila].Value.ToString();
            txtNombre.Text = dataGridView1[1, fila].Value.ToString();
            txtNivel.Text = dataGridView1[2, fila].Value.ToString();
            txtUsuario1.Text = dataGridView1[3, fila].Value.ToString();
            txtContraseña.Text = dataGridView1[4, fila].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
