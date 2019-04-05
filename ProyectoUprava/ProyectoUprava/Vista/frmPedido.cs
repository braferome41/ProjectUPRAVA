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
            cbxProducto.DisplayMember = "Nombre";
            cbxProducto.ValueMember = "IdProducto";

            clIdHabitacion objIdHab = new clIdHabitacion();
            DataTable dtIdHabitacion = objIdHab.mtdCargarcbxHabitacion();
            cbxHabitacion.DataSource = dtIdHabitacion;
            cbxHabitacion.DisplayMember = "IdHabitacion";
            cbxHabitacion.ValueMember = "NumHabitacion";
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                clPedido objPedido = new clPedido();
                int idProduc = int.Parse(cbxProducto.SelectedValue.ToString());
                int IdHab = int.Parse(cbxHabitacion.SelectedValue.ToString());

                DateTime FechaHora = DateTime.Now;
                List<clPedido> ListaPedido = new List<clPedido>();
                List<clPedido> DatosProducto = new List<clPedido>();

                objPedido.NumHabitacion = IdHab;
                objPedido.Producto = cbxProducto.Text;
                objPedido.Cantidad = int.Parse(txtCantidad.Text);
                objPedido.FechaHora = string.Format("{0:yyyy-MM-dd HH:mm:ss}", FechaHora);
                objPedido.idProducto = idProduc;


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

                            cbxHabitacion.Text = "";
                            cbxProducto.Text = "";
                            txtCantidad.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Error en el Pedido");
                        }
                    }

                }
            }
            catch (Exception err)
            {
                string error = err.Message;
                MessageBox.Show("Debe completar todos los datos");
            }
        }
    }
}
