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
    public partial class frmDatosEmpleado : Form
    {
        public frmDatosEmpleado()
        {
            InitializeComponent();
        }

        private void frmDatosEmpleado_Load(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();
            DataTable ListaEmpleado = objEmpleado.mtdListarEmpleado();
            dgvEmpleado.DataSource = ListaEmpleado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
