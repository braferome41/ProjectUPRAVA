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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            clProducto objProducto = new clProducto();
            
            DataTable dtlistar = objProducto.mtdListar();
            dgvProducto.DataSource = dtlistar;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text==""||txtNombre.Text==""||txtPrecio.Text==""||txtCantidad.Text=="")
            {
                MessageBox.Show("Debe completar la Informacion");
            }
            else
            {
                int codigo1 = int.Parse(txtCodigo.Text);
                clProducto objProducto = new clProducto();
                objProducto.Codigo = int.Parse(txtCodigo.Text);
                int codigovalid = objProducto.mtdValidar();

                if (codigovalid==codigo1)
                {
                    int cantidad = objProducto.mtdRegistrarExistent();
                    int suma= cantidad + int.Parse(txtCantidad.Text);

                    objProducto.Codigo = int.Parse(txtCodigo.Text);
                    objProducto.Cantidad2 = suma;

                    int retorno = objProducto.mtdRegsitrarExitentUpdate();

                    if (retorno > 0)
                    {
                        MessageBox.Show("Registro Exitoso");
                        txtCantidad.Clear();
                        txtCodigo.Clear();
                        txtNombre.Clear();
                        txtPrecio.Clear();

                        frmProducto_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error al Registrar");
                    }
                }

                else
                {
                    objProducto.Codigo = int.Parse(txtCodigo.Text);
                    objProducto.Cantidad = int.Parse(txtCantidad.Text);
                    objProducto.Precio = int.Parse(txtPrecio.Text);
                    objProducto.Nombre = txtNombre.Text;

                    int returnregis = objProducto.mtdRegistrar();

                    if (returnregis > 0)
                    {
                        MessageBox.Show("Registro Completado");
                        txtCantidad.Clear();
                        txtCodigo.Clear();
                        txtNombre.Clear();
                        txtPrecio.Clear();

                        frmProducto_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar");
                    }
                }                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                clProducto objProducto = new clProducto();

                int Producto = objProducto.mtdProduccion();

                int Producto1 = 0;
                Producto1 = int.Parse(txtCantidad.Text);
                int suma = Producto + Producto1;

                objProducto.Codigo = int.Parse(txtCodigo.Text);
                objProducto.Nombre = txtNombre.Text;
                objProducto.Precio = int.Parse(txtPrecio.Text);
                objProducto.Cantidad = suma;

                int can = objProducto.mtdActualizar();

                if (can > 0)
                {
                    MessageBox.Show("Datos Registrados");
                    frmProducto_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Errorr");
                }


                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
                txtCodigo.Focus();


            }
            catch (Exception)
            {
                MessageBox.Show("Debe completar todos los datos");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clProducto objProducto = new clProducto();

                objProducto.Codigo = int.Parse(txtCodigo.Text);

                int can = objProducto.mtdEliminar();

                if (can > 0)
                {
                    MessageBox.Show("Datos Eliminados");
                    frmProducto_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Errorr");
                }



                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
                txtCodigo.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe completar los datos");

            }

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Digitar solo numeros");
            }
        }


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Digitar solo numeros");
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Digitar solo numeros");
            }
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
                MessageBox.Show("Digitar solo numeros");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clProducto objProducto = new clProducto();

                objProducto.Codigo = int.Parse(txtCodigo.Text);

                List<clProducto> ListaProducto = new List<clProducto>();

                objProducto.mtdBuscar();

                int permitir = 0;

                for (int i = 0; i < ListaProducto.Count; i++)
                {
                    if (ListaProducto[i].Codigo == int.Parse(txtCodigo.Text))
                    {
                        permitir = 1;
                    }

                }

                if (permitir == 1)
                {
                    MessageBox.Show("Se encontro el producto");

                }
                else if (permitir == 0)
                {
                    MessageBox.Show("No se encuentra el producto");
                }

                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
                txtCodigo.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("Debe completar los datos");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
