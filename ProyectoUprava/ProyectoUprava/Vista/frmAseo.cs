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
    public partial class frmAseo : Form
    {
        public frmAseo()
        {
            InitializeComponent();
        }

        private void frmAseo_Load(object sender, EventArgs e)
        {
            clComboHab objComHab = new clComboHab();
            DataTable dtComboHab = objComHab.mtdCargarComboHab();
            cbxHabitacion.DataSource = dtComboHab;
            cbxHabitacion.DisplayMember = "NumHabitacion";
            cbxHabitacion.ValueMember = "IdHabiacion";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            clComboHab objComHab = new clComboHab();

            if (rbtIniciar.Checked == false && rbtFinalizar.Checked == false)
            {
                MessageBox.Show("Debe Seleccionar una Opcion");
            }
            else
            {
                int idHab = int.Parse(cbxHabitacion.SelectedValue.ToString());
                objComHab.IdHabitacion = idHab;

                if (rbtIniciar.Checked == true)
                {
                    string disponibilidad = objComHab.mtdEstadoHabitacion();

                    if (disponibilidad == "Disponible")
                    {
                        string estado = "Mantenimiento";
                        objComHab.estado = estado;
                        int retorno = objComHab.mtdAseo();

                        if (retorno > 0)
                        {
                            MessageBox.Show("Aseo Iniciado");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La Habitacion esta Ocupada o y se Encuntra en Mantenimiento");
                    }

                }

                else if (rbtFinalizar.Checked == true)
                {
                    string disponibilidad = objComHab.mtdEstadoHabitacion();

                    if (disponibilidad == "Mantenimiento")
                    {
                        string estado = "Disponible";
                        objComHab.estado = estado;
                        int retorno1 = objComHab.mtdAseo();

                        if (retorno1 > 0)
                        {
                            MessageBox.Show("Aseo Finalizado");
                        }
                        else
                        {
                            MessageBox.Show("Error 1");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se Puede Finalizar si no esta en Mantenimiento");
                    }
                }
            }
        }
    }
}
