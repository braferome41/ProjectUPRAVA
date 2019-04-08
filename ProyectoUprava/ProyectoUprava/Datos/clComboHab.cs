using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUprava.Datos
{
    class clComboHab
    {
        public int IdHabitacion { get; set; }
        public string estado { get; set; }

        public DataTable mtdCargarComboHab()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT NumHabitacion,IdHabiacion FROM Habitacion";
            DataTable dtHab = objConexion.mtdDesconectdo(consulta);

            return dtHab;
        }

        public int mtdAseo()
        {
            clConexion objConexion = new clConexion();
            string consulta = "UPDATE Habitacion SET EstadoDisponibilidad= '" + estado + "' WHERE IdHabiacion = '" + IdHabitacion + "'";
            int retorno = objConexion.mtdConectado(consulta);

            return retorno;
        }

        public string mtdEstadoHabitacion()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT EstadoDisponibilidad FROM Habitacion WHERE IdHabiacion ='" + IdHabitacion + "'";
            DataTable dtEstdos = objConexion.mtdDesconectdo(consulta);

            string estado = "";

            for (int i = 0; i < dtEstdos.Rows.Count; i++)
            {
                clComboHab objComboHab = new clComboHab();

                estado = dtEstdos.Rows[i]["EstadoDisponibilidad"].ToString();
            }

            return estado;
        }
    }
}
