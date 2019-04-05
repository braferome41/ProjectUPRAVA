using ProyectoUprava.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUprava.Vista.Listados
{
    public partial class frmDatosCliente : Form
    {
        public frmDatosCliente()
        {
            InitializeComponent();
        }

        private void frmDatosCliente_Load(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            DataTable Lista = objCliente.mtdListarClinte();
            dgvCliente.DataSource = Lista;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
