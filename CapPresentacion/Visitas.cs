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
    public partial class Visitas : Form
    {
        E_Users objent = new E_Users();
        N_Users objneg = new N_Users();
        public Visitas()
        {
            InitializeComponent();
        }

        private void Visitas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_visitas();
        }

        private void txtEdificio_TextChanged(object sender, EventArgs e)
        {
            if (txtEdificio.Text != "")
            {
                objent.edificio = Convert.ToInt32(txtEdificio.Text);
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_visitas_edificios(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listar_visitas();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

