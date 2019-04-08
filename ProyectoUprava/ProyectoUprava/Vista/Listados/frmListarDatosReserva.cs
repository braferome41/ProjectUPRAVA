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
    public partial class frmListarDatosReserva : Form
    {
        public frmListarDatosReserva()
        {
            InitializeComponent();
        }

        private void frmListarDatosReserva_Load(object sender, EventArgs e)
        {
            clReserva objReserva = new clReserva();
            string estado = "Reservada";
            objReserva.EstadoReserva = estado;
            DataTable dtReservas = objReserva.mtdListarReservas();
            dgvReservas.DataSource = dtReservas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
