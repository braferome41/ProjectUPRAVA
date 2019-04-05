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
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        public string Documento { get; set; }

        private void frmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();

            objEmpleado.Documento = Documento;

            DataTable dtEmpleado = objEmpleado.mtdBuscarEmpleado();
            dgvEmpleado.DataSource = dtEmpleado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
