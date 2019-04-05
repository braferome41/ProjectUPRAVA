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
using System.Data.SqlClient;
using ProyectoUprava.Vista;
using ProyectoUprava.Vista.Listados;

namespace ProyectoUprava
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        bool retorno1;
       

        public void mtdLimpiar()
        {
            txtDocumento.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            cbxCiudad.SelectedItem = ("Seleccione...");
            txtEmail.Clear();
            txtCelular.Clear();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtDocumento.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtEmail.Text == "" || txtCelular.Text == "" || cbxCiudad.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion");
            }
            else
            {
                clCliente objCliente = new clCliente();
                objCliente.Documento = txtDocumento.Text;
                string retorno1 = objCliente.mtdVerificarCliente();

                if (retorno1 == txtDocumento.Text)
                {
                    MessageBox.Show("El Cliente ya se Encuentra Registrado");
                    mtdLimpiar();
                    txtDocumento.Focus();
                }

                else
                {
                    objCliente.Documento = txtDocumento.Text;
                    objCliente.Nombres = txtNombres.Text;
                    objCliente.Apellidos = txtApellidos.Text;
                    objCliente.Ciudad = cbxCiudad.Text;
                    objCliente.Email = txtEmail.Text;
                    objCliente.Celular = txtCelular.Text;

                    int retorno = objCliente.mtdRegistrarCliente();

                    if (retorno > 0)
                    {
                        MessageBox.Show("Registro Exitoso");
                        mtdLimpiar();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al Registrar");
                    }
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //clCliente objCliente = new clCliente();
            //DataTable Cliente = objCliente.mtdListarClinte();
            //dgvCliente.DataSource = Cliente;
             

            //Cargar Combos

            try
            {
                //clCiudad objCiudad = new clCiudad();
                //DataTable dtCuidad = objCiudad.mtdCargarCiudad();
                //cbxCiudad.DataSource = dtCuidad;
                //cbxCiudad.DisplayMember = "Ciudad";
                //cbxCiudad.ValueMember = "IdCiudad";
            }
            catch (Exception err)
            {
                string error = err.Message;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtEmail.Text == "" || txtCelular.Text == "" || cbxCiudad.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion para Realizar la Actualizacion");
            }
            else
            {
                clCliente objCliente = new clCliente();

                objCliente.Documento = txtDocumento.Text;
                objCliente.Nombres = txtNombres.Text;
                objCliente.Apellidos = txtApellidos.Text;
                objCliente.Ciudad = cbxCiudad.Text;
                objCliente.Email = txtEmail.Text;
                objCliente.Celular = txtCelular.Text;

                int retorno = objCliente.mtdActualizarCliente();

                if (retorno > 0)
                {
                    MessageBox.Show("Actualizacion Exitosa");
                    mtdLimpiar();
                                        
                }
                else
                {
                    MessageBox.Show("Error al Actualizar");
                }
            }
        }

        private void btnRegistrarVeh_Click(object sender, EventArgs e)
        {
            frmVehiculo objVehiculo = new frmVehiculo();
            objVehiculo.Show();
        }

        private void btnElimClient_Click(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();

            List<clCliente> ListaDatos = new List<clCliente>();
            ListaDatos = objCliente.mtdVerificarEliminacionBusqueda();

            if (txtDocElim.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion");
                txtDocElim.Focus();
            }

            else
            {
                for (int i = 0; i < ListaDatos.Count; i++)
                {
                    retorno1 = false;

                    if (ListaDatos[i].Documento == txtDocElim.Text)
                    {
                        objCliente.Documento = txtDocElim.Text;
                        int retorno = objCliente.mtdEliminarCliente();

                        if (retorno > 0)
                        {
                            MessageBox.Show("Eliminacion Completada");
                            txtDocElim.Clear();
                            txtDocElim.Focus();
                                                       
                            retorno1 = true;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un Error al Eliminar");
                        }
                    }
                }

                if (retorno1 != true)
                {
                    MessageBox.Show("El Cliente no se Encuentra Registrado en la Base de Datos");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();

            List<clCliente> ListaDatos = new List<clCliente>();
            ListaDatos = objCliente.mtdVerificarEliminacionBusqueda();
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
                        
                        //txtBusDoc.Clear();
                        //txtBusDoc.Focus();
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

                frmBuscarCliente objDatos = new frmBuscarCliente();
                objDatos.Documento = txtBusDoc.Text;


                if (Buscar==true)
                {                  
                                        
                    objDatos.Show();
                    txtBusDoc.Clear();

                }               
            }

        }

        private void btnListarAll_Click(object sender, EventArgs e)
        {
            
            frmDatosCliente objDatosCliente = new frmDatosCliente();
            objDatosCliente.Show();
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Digitar solo numeros");
            }
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongTimeString();
            lblHora.Text = DateTime.Now.ToLongDateString();
        }       

        private void button1_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void btnAsignarHab_Click(object sender, EventArgs e)
        {
            frmReserva objReserva = new frmReserva();
            objReserva.Show();
        }
    }
}
 