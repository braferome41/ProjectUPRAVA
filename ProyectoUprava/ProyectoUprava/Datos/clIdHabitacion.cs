using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoUprava.Datos
{
    class clIdHabitacion
    {
        public DataTable mtdCargarcbxHabitacion()
        {
            clConexion objConexion = new clConexion();

            string consulta = "SELECT IdHabitacion,NumHabitacion FROM Habitacion INNER JOIN Asignacion ON (Habitacion.IdHabiacion=Asignacion.IdHabitacion);";
            DataTable dtcbxHabitacion = objConexion.mtdDesconectdo(consulta);

            return dtcbxHabitacion;
        }
    }
}
