using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//se llama las capas relacionadas
using CapEntidades;
using Cap_Negocio;

namespace CapPresentacion
{
    public partial class Registro : Form
    {

        //Se crea las variables que representaran a cada clase
        E_Users objent = new E_Users();
        N_Users objneg = new N_Users();

        public Registro()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objent.codigo = txtCodigo.Text;
            objent.nombre = txtNombre.Text;
            objent.edad = Convert.ToInt32(txtEdad.Text);
            objent.telefono = Convert.ToInt32(txtTelefono.Text);
            objent.apellido = txtApellido.Text;
            objent.edificio = Convert.ToInt32(txtEdificio.Text);
            objent.entrada = txtFechaEntrada.Text;
            objent.salida = txtFechaSalida.Text;
            objent.motivo = txtMotivo.Text;
            objent.aula = txtAula.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_visitas(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtApellido.Text = "";
            txtEdificio.Text = "";
            txtFechaEntrada.Text = "";
            txtFechaSalida.Text = "";
            txtMotivo.Text = "";
            txtAula.Text = "";
            txtBuscar.Text = "";

            dataGridView1.DataSource = objneg.N_listar_visitas();

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_visitas();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }

            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas Modificar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }

            }

        }

        private void modicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas Eliminar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }

            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                objent.nombre = txtBuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_visitas(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listar_visitas();
            }

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtCodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtNombre.Text = dataGridView1[1, fila].Value.ToString();
            txtEdad.Text = dataGridView1[2, fila].Value.ToString();
            txtTelefono.Text = dataGridView1[3, fila].Value.ToString();
            txtApellido.Text = dataGridView1[4, fila].Value.ToString();
            txtEdificio.Text = dataGridView1[5, fila].Value.ToString();
            txtFechaEntrada.Text = dataGridView1[6, fila].Value.ToString();
            txtFechaSalida.Text = dataGridView1[7, fila].Value.ToString();
            txtMotivo.Text = dataGridView1[8, fila].Value.ToString();
            txtAula.Text = dataGridView1[9, fila].Value.ToString();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

   