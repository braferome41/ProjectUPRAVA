using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoUprava.Datos;

namespace ProyectoUprava.Vista
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdUpravaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.bdUpravaDataSet.Empleado);

            clEmpleado objEmpleado = new clEmpleado();
            List<clEmpleado> ListaDatos = new List<clEmpleado>();
            ListaDatos = objEmpleado.mtdListar();
            dgvNomina.DataSource = ListaDatos;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gbxDatos.Show();
            btnConfirmar.Show();
            btnCancelar.Show();

            btnModificar.Hide();
            btnEliminar.Hide();
            btnRegistrar.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gbxDatos.Show();
            lblDocumento.Show();
            cbxDocumento.Show();
            btnConfirmarM.Show();
            btnCancelar.Show();

            btnModificar.Hide();
            btnEliminar.Hide();
            btnRegistrar.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblDocumento.Show();
            cbxDocumento.Show();
            btnConfirmarE.Show();
            btnCancelar.Show();

            btnModificar.Hide();
            btnEliminar.Hide();
            btnRegistrar.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDocumento.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtContraseña.Clear();
            txtCiudad.Clear();
            txtCelular.Clear();

            btnRegistrar.Show();
            btnModificar.Show();
            btnEliminar.Show();

            btnConfirmar.Hide();
            btnConfirmarM.Hide();
            btnConfirmarE.Hide();
            btnCancelar.Hide();
            gbxDatos.Hide();
            lblDocumento.Hide();
            cbxDocumento.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();

            try
            {

                    objEmpleado.Documento = int.Parse(txtDocumento.Text);
                    objEmpleado.Nombres = txtNombres.Text;
                    objEmpleado.Apellidos = txtApellidos.Text;
                    objEmpleado.Contraseña = txtContraseña.Text;
                    objEmpleado.Ciudad = txtCiudad.Text;
                    objEmpleado.Direccion = txtDireccion.Text;
                    objEmpleado.Celular = txtCelular.Text;
                    objEmpleado.Email = txtEmail.Text;

                    if (cbxCargo.Text == "Administracion")
                    {
                        objEmpleado.Cargo = "Administracion";
                    }
                    else if (cbxCargo.Text == "Recepcion")
                    {
                        objEmpleado.Cargo = "Recepcion";

                    }
                    else if (cbxCargo.Text == "Empleado")
                    {
                        objEmpleado.Cargo = "Empleado";
                    }

                    int cantidad = objEmpleado.mtdRegistrar();

                    if (cantidad > 0)
                    {
                        MessageBox.Show("Registro Exitoso");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                    List<clEmpleado> ListaDatos = new List<clEmpleado>();
                    ListaDatos = objEmpleado.mtdListar();
                    dgvNomina.DataSource = ListaDatos;

                    txtDocumento.Clear();
                    txtNombres.Clear();
                    txtApellidos.Clear();
                    txtEmail.Clear();
                    txtDireccion.Clear();
                    txtContraseña.Clear();
                    txtCiudad.Clear();
                    txtCelular.Clear();

                    btnRegistrar.Show();
                    btnModificar.Show();
                    btnEliminar.Show();

                    btnConfirmar.Hide();
                    gbxDatos.Hide();
                    btnCancelar.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan Datos");

            }

        }

        private void btnConfirmarM_Click(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();

            try
            {   
                objEmpleado.Documento = int.Parse(txtDocumento.Text);
                objEmpleado.Nombres = txtNombres.Text;
                objEmpleado.Apellidos = txtApellidos.Text;
                objEmpleado.Contraseña = txtContraseña.Text;
                objEmpleado.Ciudad = txtCiudad.Text;
                objEmpleado.Direccion = txtDireccion.Text;
                objEmpleado.Celular = txtCelular.Text;
                objEmpleado.Email = txtEmail.Text;
                objEmpleado.selecdoc = int.Parse(cbxDocumento.Text);

                if (cbxCargo.Text == "Administracion")
                {
                    objEmpleado.Cargo = "Administracion";
                }
                else if (cbxCargo.Text == "Recepcion")
                {
                    objEmpleado.Cargo = "Recepcion";

                }
                else if (cbxCargo.Text == "Empleado")
                {
                    objEmpleado.Cargo = "Empleado";
                }

                int cantidad = objEmpleado.mtdModificar();

                if (cantidad > 0)
                {
                    MessageBox.Show("Modificacion Exitosa");

                    List<clEmpleado> ListaDatos = new List<clEmpleado>();
                    ListaDatos = objEmpleado.mtdListar();
                    dgvNomina.DataSource = ListaDatos;

                    txtDocumento.Clear();
                    txtNombres.Clear();
                    txtApellidos.Clear();
                    txtEmail.Clear();
                    txtDireccion.Clear();
                    txtContraseña.Clear();
                    txtCiudad.Clear();
                    txtCelular.Clear();

                    btnRegistrar.Show();
                    btnModificar.Show();
                    btnEliminar.Show();

                    btnConfirmarM.Hide();
                    gbxDatos.Hide();
                    btnCancelar.Hide();
                    cbxDocumento.Hide();
                }
                else
                {
                    MessageBox.Show("Error");
                }

               
            }
            catch (Exception)
            {

                MessageBox.Show("Faltan Datos");
                cbxDocumento.Text = "";
            }

        }

        private void btnConfirmarE_Click(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();

            try
            {
                objEmpleado.selecdoc = int.Parse(cbxDocumento.Text);

                int cantidad = objEmpleado.mtdModificar();

                if (cantidad > 0)
                {
                    MessageBox.Show("Eliminacion Exitosa");
                    cbxDocumento.Text = "";

                    List<clEmpleado> ListaDatos = new List<clEmpleado>();
                    ListaDatos = objEmpleado.mtdListar();
                    dgvNomina.DataSource = ListaDatos;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe Elegir un Nº de Documento");
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
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Digitar solo Numeros");
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Digitar solo Numeros");
            }
        }
    }
    
    
}
 