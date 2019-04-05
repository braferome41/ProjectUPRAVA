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
using ProyectoUprava.Vista.Listados;

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
            clCiudad objCiudad = new clCiudad();
            DataTable dtCuidad = objCiudad.mtdCargarCiudad();
            cbxCiudad.DataSource = dtCuidad;
            cbxCiudad.DisplayMember = "Ciudad";
            cbxCiudad.ValueMember = "IdCiudad";

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();

            List<clEmpleado> DatosEmpleado = new List<clEmpleado>();

            try
            {
                if (txtDocumento.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtContraseña.Text == "" || txtDireccion.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Debe Ingresarlos Datos");
                }
                else
                {

                    int codigo1 = int.Parse(txtDocumento.Text);
                    clProducto objProducto = new clProducto();

                    objProducto.Codigo = int.Parse(txtDocumento.Text);
                    int codigovalid = objProducto.mtdValidar();

                    if (codigovalid == codigo1)
                    {
                        MessageBox.Show("Usuario ya Registrado");
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtEmail.Clear();
                        txtDireccion.Clear();
                        txtContraseña.Clear();
                        txtCelular.Clear();
                        txtEliminar.Clear();
                        txtBusDoc.Clear();
                    }
                    else
                    {
                        objEmpleado.Documento = txtDocumento.Text;
                        objEmpleado.Nombres = txtNombres.Text;
                        objEmpleado.Apellidos = txtApellidos.Text;
                        objEmpleado.Contraseña = txtContraseña.Text;
                        objEmpleado.Direccion = txtDireccion.Text;
                        objEmpleado.Celular = txtCelular.Text;
                        objEmpleado.Email = txtEmail.Text;

                        if (cbxCargo.Text == "Administrador")
                        {
                            objEmpleado.Cargo = "Administrador";
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

                        txtDocumento.Clear();
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtEmail.Clear();
                        txtDireccion.Clear();
                        txtContraseña.Clear();
                        txtCelular.Clear();
                        txtEliminar.Clear();
                        txtBusDoc.Clear();
                    }

                   
                }

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

                if (txtDocumento.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtContraseña.Text == "" || txtDireccion.Text == "" || txtCelular.Text == "" || txtEmail.Text == "") 
                {
                    MessageBox.Show("Debe Completar la Informacion");
                }
                else
                {
                    objEmpleado.Documento = txtDocumento.Text;
                    objEmpleado.Nombres = txtNombres.Text;
                    objEmpleado.Apellidos = txtApellidos.Text;
                    objEmpleado.Contraseña = txtContraseña.Text;
                    objEmpleado.Direccion = txtDireccion.Text;
                    objEmpleado.Celular = txtCelular.Text;
                    objEmpleado.Email = txtEmail.Text;


                    if (cbxCargo.Text == "Administrador")
                    {
                        objEmpleado.Cargo = "Administrador";
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

                        txtDocumento.Clear();
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtEmail.Clear();
                        txtDireccion.Clear();
                        txtContraseña.Clear();
                        txtCelular.Clear();
                        txtEliminar.Clear();
                        txtBusDoc.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            
            }
            catch (Exception)
            {

                MessageBox.Show("Faltan Datos");
                
            }

        }

        private void btnConfirmarE_Click(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();

            try
            {
                objEmpleado.Documento = txtEliminar.Text;
 
                int cantidad = objEmpleado.mtdEliminar();

                if (cantidad > 0)
                {
                    MessageBox.Show("Eliminacion Exitosa");
                    txtEliminar.Clear();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe Ingresar un Nº de Documento");
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

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            frmEmpleado objEmpleado = new frmEmpleado();
            frmMenuEmpleado objMenuEmpleado = new frmMenuEmpleado();
            this.Close();
            objMenuEmpleado.Show();                               
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmDatosEmpleado objDatosEmpleado = new frmDatosEmpleado();
            objDatosEmpleado.Show();
        }

        private void txtEliminar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBusDoc_KeyPress(object sender, KeyPressEventArgs e)
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

        bool retorno1;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();

            List<clEmpleado> ListaDatos = new List<clEmpleado>();
            ListaDatos = objEmpleado.mtdVerificarEliminacionBusqueda();

            bool Buscar = false;

            if (txtBusDoc.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion");
            }
            else
            {               

                for (int i = 0; i < ListaDatos.Count; i++)
                {
                    if (ListaDatos[i].Documento == txtBusDoc.Text)
                    {
                        retorno1 = false;

                        Buscar = true;
                        
                        retorno1 = true;
                        break;
                    }
                }

                if (retorno1 != true)
                {
                    MessageBox.Show("El Cliente no se Encuentra Registrado en la Base de Datos");
                    txtBusDoc.Clear();
                    txtBusDoc.Focus();
                }

                frmBuscarEmpleado objDatos = new frmBuscarEmpleado();
                objDatos.Documento = txtBusDoc.Text;
                

                if (Buscar == true)
                {
                    objDatos.Show();
                    txtBusDoc.Clear();
                }
            }

        }

        private void txtCelular_KeyPress_1(object sender, KeyPressEventArgs e)
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
 