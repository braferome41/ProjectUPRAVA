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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            clIdProducto objIdPro = new clIdProducto();
            DataTable dtIdProducto = objIdPro.mtdCarcarCombos();
            cbxProducto.DataSource = dtIdProducto;
            cbxProducto.DisplayMember = "NombreP";
            cbxProducto.ValueMember = "IdProducto";

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                clPedido objPedido = new clPedido();

                objPedido.NumHabitacion = int.Parse(txtHabitacion.Text);

                int idHab = objPedido.mtdAsignar();
                objPedido.idHab = idHab;

                int IdAsignacion = objPedido.mtdIdAsignacion();
                objPedido.IdAsignacion = IdAsignacion;

                string Estado = objPedido.mtdEstado();
                objPedido.Estado = Estado;

                int idProduc = int.Parse(cbxProducto.SelectedValue.ToString());

                DateTime FechaHora = DateTime.Now;
                List<clPedido> ListaPedido = new List<clPedido>();
                List<clPedido> DatosProducto = new List<clPedido>();

                objPedido.NumHabitacion = int.Parse(txtHabitacion.Text);
                objPedido.Producto = cbxProducto.Text;
                objPedido.Cantidad = int.Parse(txtCantidad.Text);
                objPedido.FechaHora = string.Format("{0:yyyy-MM-dd HH:mm:ss}", FechaHora);
                objPedido.idProducto = idProduc;

                if (Estado == "Ocupada") 
                {
                    DatosProducto = objPedido.mtdTraer();                

                    for (int i = 0; i < DatosProducto.Count; i++)
                    {
                        if (DatosProducto[i].Cantidad < objPedido.Cantidad)
                        {
                            MessageBox.Show("Producto Insuficiente");
                        }
                        else if (DatosProducto[i].Cantidad >= objPedido.Cantidad)
                        {
                            objPedido.NuevaCantidad = DatosProducto[i].Cantidad - objPedido.Cantidad;

                            objPedido.Total = DatosProducto[i].Precio * objPedido.Cantidad;

                            int update = objPedido.mtdActualizarProducto();
                            int RegistrarPedido = objPedido.mtdRegistrar();


                            if (update > 0 && RegistrarPedido > 0)
                            {
                                MessageBox.Show("Pedido Realizado");

                                cbxProducto.Text = "";
                                txtCantidad.Clear();
                                txtHabitacion.Clear();

                            }
                            else
                            {
                                MessageBox.Show("Error en el Pedido");
                            }
                        }

                    }

                } 
                else
                {
                    MessageBox.Show("Debe Ocupar la Habitacion");

                }
 
            }
            catch (Exception err)
            {
                string error = err.Message;
                MessageBox.Show("Debe completar todos los datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHabitacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
