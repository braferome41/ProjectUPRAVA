using ProyectoUprava.Datos;
using ProyectoUprava.Vista.Listados;
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
    public partial class frmDatosReserva : Form
    {
        public frmDatosReserva()
        {
            InitializeComponent();
        }

        List<clReserva> valReser = new List<clReserva>();
        int idHabitacion = 0;
        int Numhab = 0;
        string estado1 = "";

        public frmDatosReserva(int idHab, int NumHab, string estado)
        {
            idHabitacion = idHab;
            Numhab = NumHab;
            estado1 = estado;

            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "" || txtObservaciones.Text == "")
            {
                MessageBox.Show("Debe Completar La Informacion");
            }
            else
            {
                clReserva objReserva = new clReserva();
                objReserva.Documento = txtDocumento.Text;
                int idCliente = 0;
                idCliente = objReserva.mtdIdCliente();

                if (idCliente == 0)
                {
                    MessageBox.Show("El Cliente no se Encuentra Registrado");
                    txtDocumento.Focus();
                }
                else
                {
                    if (rbtOcupar.Checked == true)
                    {
                        if (estado1 == "Ocupada")
                        {
                            MessageBox.Show("La Habitacion se Encuentra Ocupada");
                        }
                        else
                        {
                            string estado = "Ocupada";

                            DateTime dtFechaHoraLlegada = DateTime.Now;
                            string Fechahora = string.Format("{0:yyyy-MM-dd HH:mm:ss}", dtFechaHoraLlegada);

                            objReserva.IdCliente = idCliente;
                            objReserva.FechaLLegada = Fechahora;
                            objReserva.Observaciones = txtObservaciones.Text;
                            objReserva.Estado = estado;
                            objReserva.IdHabitadcion = idHabitacion;
                            objReserva.NumHabitacion = Numhab;

                            int retorno = objReserva.mtdAsignarHab();

                            if (retorno > 0)
                            {
                                MessageBox.Show("Asignacion Exitosa");
                            }
                            else
                            {
                                MessageBox.Show("Error al Asignar");
                            }
                        }
                    }
                    else if (rbtReservar.Checked == true)
                    {
                        objReserva.IdCliente = idCliente;
                        valReser = objReserva.mtdValidarReservas();

                        string fechallegada0 = "";
                        string fechallegada1 = "";

                        fechallegada1 = txtFechaLlegada.Text+ ":00";

                        for (int i = 0; i < valReser.Count; i++)
                        {
                            fechallegada0 = valReser[i].FechaLLegada;
                        }

                        Boolean a = false;

                        for (int i = 0; i < valReser.Count; i++)
                        {
                            if (valReser[i].EstadoReserva=="Reservada ")
                            {
                                if (fechallegada0==fechallegada1)
                                {
                                    a = true;
                                }
                            }
                            else
                            {
                                a = false;
                            }
                        }

                        if (a==true)
                        {
                            MessageBox.Show("Esta Habitacion se Encuentra Reservada para esa Fecha");
                        }
                        else if (a==false)
                        {
                            string estado = "Reservada";

                            objReserva.IdCliente = idCliente;
                            objReserva.FechaLLegada = txtFechaLlegada.Text;
                            objReserva.FechaSalida = txtFechaSalida.Text;
                            objReserva.Observaciones = txtObservaciones.Text;
                            objReserva.Estado = estado;
                            objReserva.IdHabitadcion = idHabitacion;
                            objReserva.NumHabitacion = Numhab;

                            int retorno = objReserva.mtdAsignarReserva();

                            if (retorno > 0)
                            {
                                MessageBox.Show("Reserva Exitosa");
                                frmDatosReserva_Load(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Error al Reservar");
                            }
                        }                       
                    }
                }
            }
        }

        private void frmDatosReserva_Load(object sender, EventArgs e)
        {
            clReserva objReserva = new clReserva();

            objReserva.IdHabitadcion = idHabitacion;
            string estdo = "";
            string estdo1 = "Reservada ";
            estdo = objReserva.mtdSacarEstado();

            if (estdo == estdo1)
            {
                string es1 = "Reservada";
                lblEstado.Text = es1;
                lblEstado.BackColor = Color.Red;
            }
            else if (estdo == "" || estdo == null|| estdo== "Cancelada ")
            {
                string es1 = "Sin Reservar";
                lblEstado.Text = es1;
                lblEstado.BackColor = Color.GreenYellow;
            }

            rbtReservar.Checked = true;
            rbtOcCancel.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReserva objfrmReser = new frmReserva();
            this.Hide();
            objfrmReser.mtdLoad();
            objfrmReser.Show();
        }

        private void rbtOcupar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtOcupar.Checked == true)
            {
                lblFechaLlegada.Hide();
                lblFechaSalida.Hide();
                txtFechaLlegada.Hide();
                txtFechaSalida.Hide();
            }
            else if (rbtReservar.Checked == true)
            {
                lblFechaLlegada.Show();
                lblFechaSalida.Show();
                txtFechaLlegada.Show();
                txtFechaSalida.Show();
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (txtDocSalid.Text == "")
            {
                MessageBox.Show("Debe Completar la Informacion");
                txtDocSalid.Focus();
            }
            else
            {
                DateTime dtFechaHoraLlegada = DateTime.Now;
                string Fechahora = string.Format("{0:yyyy-MM-dd HH:mm:ss}", dtFechaHoraLlegada);
                string estado = "Disponible";

                clReserva objReserva = new clReserva();
                objReserva.Documento = txtDocSalid.Text;
                int idCliente = objReserva.mtdIdCliente();

                objReserva.IdCliente = idCliente;
                int idClienteReser = objReserva.mtdIdClienteAsig();

                if (idClienteReser == 0)
                {
                    MessageBox.Show("Revise el Documento");
                    txtDocSalid.Focus();
                }
                else
                {
                    objReserva.Estado = estado;
                    objReserva.IdCliente = idCliente;
                    objReserva.IdHabitadcion = idHabitacion;
                    objReserva.FechaSalida = Fechahora;

                    int retorno = objReserva.mtdDarSrlida();

                    if (retorno > 0)
                    {
                        MessageBox.Show("Salida Exitosa");
                        txtDocSalid.Clear();
                        txtDocSalid.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al Dar Salida");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtDoCancel.Text == "")
            {
                MessageBox.Show("Debe CompLetar la Informacion");
            }
            else
            {
                if (rbtOcCancel.Checked == true)
                {
                    clReserva objReserva = new clReserva();
                    DateTime dtFechaHoraSalida = DateTime.Now;
                    string Fechahora = string.Format("{0:yyyy-MM-dd HH:mm:ss}", dtFechaHoraSalida);
                    string estado = "Disponible";

                    objReserva.Documento = txtDoCancel.Text;
                    int idCliente = objReserva.mtdIdCliente();
                    objReserva.IdCliente = idCliente;
                    int idClienteReser = objReserva.mtdIdClienteAsig();

                    if (idClienteReser == 0)
                    {
                        MessageBox.Show("Revise el Documento");
                        txtDoCancel.Focus();
                    }

                    else
                    {
                        objReserva.FechaSalida = Fechahora;
                        objReserva.IdCliente = idCliente;
                        objReserva.IdHabitadcion = idHabitacion;
                        objReserva.Estado = estado;

                        int retorno = objReserva.mtdDarSrlida();

                        if (retorno > 0)
                        {
                            MessageBox.Show("Cancelacion Exitosa");
                            txtDoCancel.Clear();
                            txtDoCancel.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error al Cancelar");
                        }
                    }

                }

                else if (rbtResCancel.Checked == true)
                {
                    clReserva objReserva = new clReserva();
                    DateTime dtFechaHoraSalida = DateTime.Now;
                    string Fechahora = string.Format("{0:yyyy-MM-dd HH:mm:ss}", dtFechaHoraSalida);
                    string estado = "Cancelada";

                    objReserva.Documento = txtDoCancel.Text;
                    int idCliente = objReserva.mtdIdCliente();
                    objReserva.IdCliente = idCliente;
                    int idClienteReser = objReserva.mtdIdClienteAsig();

                    if (idClienteReser == 0)
                    {
                        MessageBox.Show("Revise el Documento");
                        txtDoCancel.Focus();
                    }
                    else
                    {
                        objReserva.FechaSalida = Fechahora;
                        objReserva.IdCliente = idCliente;
                        objReserva.IdHabitadcion = idHabitacion;
                        objReserva.Estado = estado;

                        int retorno = objReserva.mtdCancelReser();

                        if (retorno > 0)
                        {
                            MessageBox.Show("Cancelacion Exitosa");
                            txtDoCancel.Clear();
                            txtDoCancel.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Cancelacion Exitosa");
                            txtDoCancel.Focus();
                        }

                    }
                }

            }
        }

        private void frmDatosReserva_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnListarReser_Click(object sender, EventArgs e)
        {
            frmListarDatosReserva objDataReser = new frmListarDatosReserva();
            objDataReser.ShowDialog();
        }
    }
}
