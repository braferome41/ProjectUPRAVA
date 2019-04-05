using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUprava.Vista
{
    public partial class frmMenuRecep : Form
    {
        public frmMenuRecep()
        {
            InitializeComponent();
          
        }       

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente objCliente = new frmCliente();
            objCliente.MdiParent = this;
            objCliente.Show();               

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Login objLogin = new Login();
            objLogin.Show();
        }

        private void frmMenuRecep_Load(object sender, EventArgs e)
        {
            frmCliente objconteni = new frmCliente();
            objconteni.MdiParent = this;
            objconteni.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto objProducto = new frmProducto();
            objProducto.MdiParent = this;
            objProducto.Show();
            
        }
    }
}
