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
    public partial class frmListaVehiculo : Form
    {
        public frmListaVehiculo()
        {
            InitializeComponent();
        }

        private void frmListaVehiculo_Load(object sender, EventArgs e)
        {
            clVehiculo objVehiculo = new clVehiculo();
            DataTable Lista = objVehiculo.mtdListarVehiculo();
            dgvVehiculo.DataSource = Lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
