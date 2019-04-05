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

namespace ProyectoUprava.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        clLogin objLogin = new clLogin();

        private void Login_Load(object sender, EventArgs e)
        {
            txtDocumento.Focus();


            if (checkBox1.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<clLogin> lista = new List<clLogin>();
            lista = objLogin.mtdBuscar();
            try
            {
                objLogin.Documento = int.Parse(txtDocumento.Text);
                objLogin.Contraseña = txtContraseña.Text;
                string mensaje = "";

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Documento == objLogin.Documento && lista[i].Contraseña == objLogin.Contraseña && lista[i].Cargo == "Administrador")
                    {

                        mensaje = "Bienvenido Administrador";

                        break;

                    }

                    else if (lista[i].Documento == objLogin.Documento && lista[i].Contraseña == objLogin.Contraseña && lista[i].Cargo == "Recepcion")
                    {
                        mensaje = "Bienvenido Recepcionista";
                        break;

                    }

                    else
                    {
                        mensaje = "Usuario o Contraseña Incorrecta";

                    }

                }

                //MessageBox.Show(mensaje);
                frmMenuEmpleado objAdmin = new frmMenuEmpleado();
                frmMenuRecep objRecepcion = new frmMenuRecep();

                if (mensaje == "Bienvenido Administrador")
                {
                    objAdmin.Show();
                    this.Hide();
                }
                else if (mensaje == "Bienvenido Recepcionista")
                {
                    objRecepcion.Show();
                    this.Hide();
                }
                else
                {
                    txtDocumento.Clear();
                    txtContraseña.Clear();
                    txtDocumento.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe Digitar Datos");
            }
            

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;

            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Digitar solo numeros");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
