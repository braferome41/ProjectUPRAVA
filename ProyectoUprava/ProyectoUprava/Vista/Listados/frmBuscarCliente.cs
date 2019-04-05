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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        public string Documento { get; set; }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            clCliente objCLiente = new clCliente();

            objCLiente.Documento = Documento;

            DataTable dtCliente = objCLiente.mtdBuscarCliente();
            dgvCliente.DataSource = dtCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
