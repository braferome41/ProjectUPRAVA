using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUprava.Datos
{
    class clReserva
    {
        public int NumHabitacion { get; set; }
        public string TipoHabitacion { get; set; }
        public string Estado { get; set; }
        public int IdEstadoReser { get; set; }
        public string EstadoReserva { get; set; }
        public string Documento { get; set; }
        public string FechaLLegada { get; set; }
        public string FechaSalida { get; set; }
        public string Observaciones { get; set; }
        public int IdHabitadcion { get; set; }
        public int IdCliente { get; set; }

        List<clReserva> ListaEstado = new List<clReserva>();
        List<clReserva> ListaEstadoReser = new List<clReserva>();

        public DataTable mtdListarReservas()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT Documento,Nombre,Apellido,Celular,NumHabitacion,FechaLlegada,FechaSalida,EstadoReserva,Observaciones FROM Cliente INNIER JOIN Asignacion ON (Asignacion.IdCliente=Cliente.IdCliente) INNER JOIN Habitacion ON (Habitacion.IdHabiacion=Asignacion.IdHabitacion)";
            DataTable dtReservas = objConexion.mtdDesconectdo(consulta);

            return dtReservas;
        }

        public DataTable mtdListarOcupaciones()
        {
            clConexion objConexion = new clConexion();
            string consulta = "";
            DataTable dtReservas = objConexion.mtdDesconectdo(consulta);

            return dtReservas;
        }

        public List<clReserva> mtdEstadoHabitacion()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT EstadoDisponibilidad, NumHabitacion FROM Habitacion";
            DataTable dtEstadoHab = objConexion.mtdDesconectdo(consulta);

            for (int i = 0; i < dtEstadoHab.Rows.Count; i++)
            {
                clReserva objReserva = new clReserva();

                objReserva.NumHabitacion = int.Parse(dtEstadoHab.Rows[i]["NumHabitacion"].ToString());
                objReserva.Estado = dtEstadoHab.Rows[i]["EstadoDisponibilidad"].ToString();

                ListaEstado.Add(objReserva);
            }
            return ListaEstado;
        }

        public int mtdIdCliente()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT IdCliente FROM Cliente WHERE Documento='" + Documento + "'";
            DataTable dtIdCliente = objConexion.mtdDesconectdo(consulta);

            int IdCliente = 0;

            for (int i = 0; i < dtIdCliente.Rows.Count; i++)
            {
                clReserva ObjReserva = new clReserva();

                IdCliente = Convert.ToInt32(dtIdCliente.Rows[i]["IdCliente"]);
            }

            return IdCliente;
        }

        public int mtdAsignarHab()
        {
            clConexion objConexion = new clConexion();
            string consulta = "INSERT INTO Asignacion (FechaLlegada,Observaciones,IdCliente,IdHabitacion)" +
                "VALUES ('" + FechaLLegada + "','" + Observaciones + "','" + IdCliente + "','" + IdHabitadcion + "')";
            int retorno = objConexion.mtdConectado(consulta);

            if (retorno > 0)
            {
                string consulta1 = "UPDATE Habitacion SET EstadoDisponibilidad='" + Estado + "' WHERE IdHabiacion='" + IdHabitadcion + "'";
                objConexion.mtdConectado(consulta1);
            }

            return retorno;
        }

        public int mtdAsignarReserva()
        {
            clConexion objConexion = new clConexion();
            string consulta = "INSERT INTO Asignacion (FechaLlegada,FechaSalida,Observaciones,EstadoReserva,IdCliente,IdHabitacion)" +
                "VALUES ('" + FechaLLegada + "','" + FechaSalida + "','" + Observaciones + "','" + Estado + "','" + IdCliente + "','" + IdHabitadcion + "')";
            int retorno = objConexion.mtdConectado(consulta);

            return retorno;
        }


        public List<clReserva> mtdListarHabitacion()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT * FROM Habitacion";
            DataTable dtEstadoHab = objConexion.mtdDesconectdo(consulta);
            List<clReserva> ListaHabitacion = new List<clReserva>();
            for (int i = 0; i < dtEstadoHab.Rows.Count; i++)
            {
                clReserva objReserva = new clReserva();

                objReserva.NumHabitacion = int.Parse(dtEstadoHab.Rows[i]["NumHabitacion"].ToString());
                objReserva.IdHabitadcion = int.Parse(dtEstadoHab.Rows[i]["IdHabiacion"].ToString());
                objReserva.TipoHabitacion = dtEstadoHab.Rows[i]["Tipo"].ToString();
                objReserva.Estado = dtEstadoHab.Rows[i]["EstadoDisponibilidad"].ToString();

                ListaHabitacion.Add(objReserva);
            }
            return ListaHabitacion;
        }

        public List<clReserva> mtdSacarEstado()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT IdHabitacion,EstadoReserva FROM Asignacion";
            DataTable dtEstados = objConexion.mtdDesconectdo(consulta);

            //string estado = "";

            for (int i = 0; i < dtEstados.Rows.Count; i++)
            {
                clReserva objReserva = new clReserva();

                objReserva.IdEstadoReser = int.Parse(dtEstados.Rows[i]["IdHabitacion"].ToString());
                objReserva.EstadoReserva = dtEstados.Rows[i]["EstadoReserva"].ToString();

                ListaEstadoReser.Add(objReserva);
            }

            return ListaEstadoReser;

        }

        public int mtdDarSrlida()
        {
            clConexion objConexion = new clConexion();
            string consulta = "UPDATE Asignacion SET FechaSalida ='" + FechaSalida + "' WHERE IdHabitacion = '" + IdHabitadcion + "'";
            int retorno = objConexion.mtdConectado(consulta);

            if (retorno > 0)
            {
                string consulta1 = "UPDATE Habitacion SET EstadoDisponibilidad = '" + Estado + "' WHERE IdHabiacion = '" + IdHabitadcion + "'";
                int retorno1 = objConexion.mtdConectado(consulta1);
            }

            return retorno;
        }

        public int mtdCancelReser()
        {
            clConexion objConexion = new clConexion();
            string consulta = "UPDATE Asignacion SET FechaSalida='" + FechaSalida + "', EstadoReserva='" + Estado + "' WHERE IdCliente ='" + IdCliente + "'";
            int retorno = objConexion.mtdConectado(consulta);

            return retorno;
        }

        public int mtdIdClienteAsig()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT IdCliente FROM Asignacion WHERE IdCliente='" + IdCliente + "'";
            DataTable dtIdCliente = objConexion.mtdDesconectdo(consulta);

            int IdCliente1 = 0;

            for (int i = 0; i < dtIdCliente.Rows.Count; i++)
            {
                clReserva ObjReserva = new clReserva();

                IdCliente1 = Convert.ToInt32(dtIdCliente.Rows[i]["IdCliente"]);
            }

            return IdCliente1;
        }
    }
}
