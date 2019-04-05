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
    public partial class frmMenuEmpleado : Form
    {
        public frmMenuEmpleado()
        {
            InitializeComponent();
        }

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Close();
            objLogin.Show();
            
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            frmEmpleado objEmpleado = new frmEmpleado();
            frmMenuEmpleado objMenuEm = new frmMenuEmpleado();
            this.Close();
            objEmpleado.Show();
            
        }
    }
}
