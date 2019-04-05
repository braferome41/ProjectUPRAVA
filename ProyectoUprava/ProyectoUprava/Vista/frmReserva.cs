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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            clReserva objReserva = new clReserva();
            List<clReserva> ListaHabitacion = new List<clReserva>();
            List<clReserva> ListaEstadoReser = new List<clReserva>();
            ListaHabitacion = objReserva.mtdListarHabitacion();
            ListaEstadoReser = objReserva.mtdSacarEstado();

            //codigo sena

            for (int i = 0; i < ListaHabitacion.Count; i++)
            {
                dgHabitacion.Rows.Add();
                dgHabitacion.Rows[i].Cells[0].Value = ListaHabitacion[i].NumHabitacion;
                dgHabitacion.Rows[i].Cells[1].Value = ListaHabitacion[i].TipoHabitacion;
                dgHabitacion.Rows[i].Cells[2].Value = ListaHabitacion[i].Estado;
                dgHabitacion.Rows[i].Cells[3].Value = ListaHabitacion[i].IdHabitadcion;
                //dgHabitacion.Rows[i].Cells[4].Value = ListaEstadoReser[i].EstadoReserva;

                if (ListaHabitacion[i].Estado == "Ocupada")
                {
                    dgHabitacion.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (ListaHabitacion[i].Estado == "Disponible")
                {
                    dgHabitacion.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                }
                else if (ListaHabitacion[i].Estado == "Mantenimiento")
                {
                    dgHabitacion.Rows[i].DefaultCellStyle.BackColor = Color.Aquamarine;
                }
            }

            //hasta aqui    
            //Estado Reserva

            //for (int i = 0; i < ListaEstadoReser.Count; i++)
            //{
            //    if (ListaEstadoReser[i].IdEstadoReser == ListaHabitacion[i].IdHabitadcion)
            //    {
            //        if (ListaEstadoReser[i].EstadoReserva == "Reservada")
            //        {
            //            dgHabitacion.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
            //        }
            //    }
            //    else if (ListaEstadoReser[i].IdEstadoReser != ListaHabitacion[i].IdHabitadcion)
            //    {
            //        if (ListaEstadoReser[i].EstadoReserva == "Cancelada" || ListaEstadoReser[i].IdHabitadcion != ListaHabitacion[i].IdHabitadcion)
            //        {
            //            dgHabitacion.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            //        }
            //    }
            //}
        }

       
        public void mtdLoad()
        {
            frmReserva_Load(null, null);
        }

        private void dgHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idHab = int.Parse(dgHabitacion.Rows[e.RowIndex].Cells[3].Value.ToString());
                int idNumHab = int.Parse(dgHabitacion.Rows[e.RowIndex].Cells[0].Value.ToString());
                string estado = dgHabitacion.Rows[e.RowIndex].Cells[2].Value.ToString();

                frmDatosReserva objDatosReserva = new frmDatosReserva(idHab, idNumHab, estado);
                objDatosReserva.Show();
                this.Hide();

            }
            catch (Exception err)
            {
                string error = err.Message;
            }
        }

        //private void dgHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
