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
using ProyectoUprava.Vista.Listados;

namespace ProyectoUprava.Vista
{
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            //clVehiculo objVehiculo = new clVehiculo();
            //DataTable vehiculos = objVehiculo.mtdListarVehiculo();
            //dgvVehiculo.DataSource = vehiculos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtElimPlac.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion");
            }
            else
            {
                clVehiculo objvehiculo = new clVehiculo();
                objvehiculo.Placa = txtElimPlac.Text;

                string placa = objvehiculo.mtdVerBuscPlaca();

                if (placa==txtElimPlac.Text)
                {
                    int retorno = objvehiculo.mtdEliminarVehiculo();

                    if (retorno > 0)
                    {
                        MessageBox.Show("Eliminacion Completada");
                        txtElimPlac.Clear();
                        txtElimPlac.Focus();

                        frmVehiculo_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error al Eliminar");
                    }
                }
                else
                {
                    MessageBox.Show("Revise que la Placa este Escrita Correctamente");
                }                
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtElimPlac.Text=="")
            {
                MessageBox.Show("Debe Completar la Informacion");
            }
            else
            {
                clVehiculo objvehiculo = new clVehiculo();
                objvehiculo.Placa = txtElimPlac.Text;

                string placa = objvehiculo.mtdVerBuscPlaca();

                if (placa==txtElimPlac.Text)
                {
                    //DataTable dtBuscVehiculo = objvehiculo.mtdBuscarVehiculo();
                    //dgvVehiculo.DataSource = dtBuscVehiculo;

                    txtElimPlac.Clear();
                    txtElimPlac.Focus();
                }
                else
                {
                    MessageBox.Show("Revise que la Placa este Escrita Correctamente");
                }               
            }            
        }

        private void btnRegisVehi_Click(object sender, EventArgs e)
        {
            if (txtDocRegis.Text == "" || txtTipo.Text == "" || txtMarca.Text == "" || txtPlaca.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion");
            }
            else
            {
                clVehiculo objVehiculo = new clVehiculo();
                objVehiculo.Documento = txtDocRegis.Text;
                int id = objVehiculo.mtdBuscarId();
                objVehiculo.IdCliente = id;
                int retornoid = objVehiculo.mtdVerificarVehculo();

                if (id==0)
                {
                    MessageBox.Show("El Cliente no se Encuentra Registrado");
                }
                else
                {

                    if (retornoid == id)
                    {
                        MessageBox.Show("El Cliente ya tiene Registrado un Vehiculo");
                    }
                    else
                    {
                        objVehiculo.IdCliente = id;
                        objVehiculo.Marca = txtMarca.Text;
                        objVehiculo.Tipo = txtTipo.Text;
                        objVehiculo.Placa = txtPlaca.Text;

                        int retorno = objVehiculo.mtdRegistrarVehiculo();

                        if (retorno > 0)
                        {
                            MessageBox.Show("Registro Completado");
                            txtTipo.Clear();
                            txtMarca.Clear();
                            txtPlaca.Clear();
                            txtDocRegis.Clear();
                            txtDocRegis.Focus();

                            frmVehiculo_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Error al Registrar");
                        }
                    }
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDocRegis.Text==""||txtTipo.Text==""||txtMarca.Text==""||txtTipo.Text=="")
            {
                MessageBox.Show("Debe Completar la Informacion");
            }
            else
            {
                clVehiculo objVehiculo = new clVehiculo();
                objVehiculo.Documento = txtDocRegis.Text;
                int id = objVehiculo.mtdBuscarId();               
                objVehiculo.IdCliente = id;
                int retornoid = objVehiculo.mtdVerificarVehculo();

                if (retornoid!=id || retornoid==0 || id==0)
                {
                    MessageBox.Show("Verifique el Documento");
                }
                else
                {
                    objVehiculo.Placa = txtPlaca.Text;
                    string Placa = objVehiculo.mtdVerificarPlaca();

                    if (Placa==txtPlaca.Text)
                    {
                        objVehiculo.IdCliente = id;
                        objVehiculo.Marca = txtMarca.Text;
                        objVehiculo.Tipo = txtTipo.Text;
                        objVehiculo.Placa = txtPlaca.Text;

                        int retorno = objVehiculo.mtdActualizarVehiculo();

                        if (retorno > 0)
                        {
                            MessageBox.Show("Actualizacion Completada");
                            txtTipo.Clear();
                            txtMarca.Clear();
                            txtPlaca.Clear();
                            txtDocRegis.Clear();
                            txtDocRegis.Focus();

                            frmVehiculo_Load(null, null);
                        }

                        else
                        {
                            MessageBox.Show("Error al Actualizar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Revise que la Placa sea Correcta");
                    }
                    
                }
                
            }            
        }

        private void btnListarVehiculos_Click(object sender, EventArgs e)
        {
            frmListaVehiculo objListaVeh = new frmListaVehiculo();
            objListaVeh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDocRegis_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
