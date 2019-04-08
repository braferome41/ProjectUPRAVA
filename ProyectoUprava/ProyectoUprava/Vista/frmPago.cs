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
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }
        clPago objpago = new clPago();

        int suma = 0;
        int suma1 = 0;
        int SumaT = 0;
        int Result = 0; string resultado;
        public int IdAsignacion;
        DateTime fecha = DateTime.Now;
        DateTime fechalle;
        DateTime fechasa;

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            clPago objPago = new clPago();
            objPago.Documento = txtBusDoc.Text;
            List<clPago> ListaTotal = new List<clPago>();
            string retorno1 = objPago.mtdVerificarCliente();

            if (txtBusDoc.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion");
            }
            else if (retorno1 != txtBusDoc.Text)
            {
                MessageBox.Show("El cliente no se encuentra registrado");

                dgvLista.Rows.Clear();
                lblNombre.Text = "";
                lblApellido.Text = "";
                lblNumHab.Text = "";
                lblDias.Text = "";
                lblCosto.Text = "";
                lblTotal.Text = "";
                txtBusDoc.Clear();
                txtBusDoc.Focus();
            }
            else
            {

                SumaT = 0;
                objpago.Documento = txtBusDoc.Text;

                ListaTotal = objpago.mtdPago();


                dgvLista.Rows.Clear();
                lblNombre.Text = "";
                lblApellido.Text = "";

                List<clPago> TotalHab = new List<clPago>();
                TotalHab = objpago.mtdValorHabitacion();
                objpago.Documento = txtBusDoc.Text;

                IdAsignacion = 0;
                bool a = false;

                for (int i = 0; i < TotalHab.Count; i++)
                {

                    if (TotalHab[i].Pago == "")
                    {
                        IdAsignacion = TotalHab[i].IdAsignacion;
                        lblNombre.Text = TotalHab[i].Nombre;
                        lblApellido.Text = TotalHab[i].Apellido;
                        lblNumHab.Text = TotalHab[i].NumHabitacion.ToString();
                        lblCosto.Text = "$ " + TotalHab[i].Precio.ToString();
                        suma1 = TotalHab[i].Precio;
                        fechalle = DateTime.Parse(TotalHab[i].FechaLlegada.ToString());
                        fechasa = DateTime.Parse(TotalHab[i].FechaSalida.ToString());
                        a = true;
                    }


                }

                for (int i = 0; i < ListaTotal.Count; i++)
                {
                    if (ListaTotal[i].VerifPago == "")
                    {

                        try
                        {

                            dgvLista.Rows.Add();
                            dgvLista.Rows[i].Cells[0].Value = ListaTotal[i].NombreP;
                            dgvLista.Rows[i].Cells[1].Value = ListaTotal[i].CantidadP;
                            dgvLista.Rows[i].Cells[2].Value = ListaTotal[i].Total;
                            lblNombre.Text = ListaTotal[i].Nombre;
                            lblApellido.Text = ListaTotal[i].Apellido;


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("No Se pudo Cargar Los Productos");

                        }
                    }


                }




                for (int i = 0; i < ListaTotal.Count; i++)
                {
                    if (ListaTotal[i].VerifPago == "")
                    {
                        suma = ListaTotal[i].Total;
                        Result = Result + suma;
                    }

                }
                if (a == false)
                {
                    MessageBox.Show("El Cliente ya Pagó");
                    lblNombre.Text = "";
                    lblApellido.Text = "";
                    lblNumHab.Text = "";
                    lblCosto.Text = " ";
                    lblDias.Text = "";
                    lblTotal.Text = "";
                    txtBusDoc.Clear();
                    txtBusDoc.Focus();
                }
                else
                {
                    try
                    {
                        TimeSpan tiempodiferencia = fechasa - fechalle;
                        SumaT = Result + suma1 * int.Parse(tiempodiferencia.TotalDays.ToString());
                        lblDias.Text = tiempodiferencia.TotalDays.ToString();
                    }
                    catch (Exception)
                    {

                        SumaT = Result + suma1 * 1;
                        lblDias.Text = "1";


                    }
                    resultado = SumaT.ToString();

                    lblTotal.Text = "$ " + resultado;
                    suma = 0;
                    Result = 0;
                    suma1 = 0;
                    resultado = "";

                }

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtBusDoc.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion");
            }
            else
            {
                clCliente objCliente = new clCliente();
                objCliente.Documento = txtBusDoc.Text;
                int IdCliente = objCliente.mtdCargarCliente();



                clPago objpago = new clPago();
                objpago.IdClienteB = IdCliente;
                objpago.IdAsignacion = IdAsignacion;
                objpago.pagar = SumaT;

                int validacion = objpago.ValidarPago();
                if (validacion > 0)
                {
                    MessageBox.Show("Gracias Por Utilizar Nuestro Servicio");
                    txtBusDoc.Clear();
                    txtBusDoc.Focus();
                }
                else
                {
                    MessageBox.Show("El Pago No Se pudo Ejecutar");
                }
                dgvLista.Rows.Clear();
                lblNombre.Text = "";
                lblApellido.Text = "";
                lblNumHab.Text = "";
                lblCosto.Text = " ";
                lblDias.Text = "";
                lblTotal.Text = "";
                txtBusDoc.Clear();
                txtBusDoc.Focus();

            }

           
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            lblfecha.Text = fecha.ToString();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBusDoc_KeyPress(object sender, KeyPressEventArgs e)
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
