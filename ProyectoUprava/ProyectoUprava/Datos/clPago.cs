using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUprava.Datos
{
    class clPago
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CantidadP { get; set; }
        public int Total { get; set; }
        public string NombreP { get; set; }
        public string VerifPago { get; set; }

        public int NumHabitacion { get; set; }
        public int Precio { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }

        public int pagar { get; set; }
        public int IdClienteB { get; set; }
        public int IdAsignacion { get; set; }

        public string Pago { get; set; }

        List<clPago> TotalPago = new List<clPago>();
        List<clPago> TotalHabitacion = new List<clPago>();
        List<clPago> Verificacion = new List<clPago>();
        List<clPago> VerificacionPago = new List<clPago>();

        public string mtdVerificarCliente()
        {
            clConexion objConexion = new clConexion();

            string consulta = "SELECT Documento FROM Cliente WHERE Documento='" + Documento + "'";
            DataTable dtCliente = objConexion.mtdDesconectdo(consulta);

            string documento = "";

            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                clPago objCliente = new clPago();

                documento = dtCliente.Rows[i]["Documento"].ToString();
            }

            return documento;
        }


        public List<clPago> mtdPago()
        {
            clConexion objConexion = new clConexion();
            string consulta = "Select Cliente.Nombre,Cliente.Apellido,Pedido.Cantidad,Pedido.Total,Producto.NombreP,Asignacion.Pago from Asignacion inner join Cliente on (Cliente.IdCliente= Asignacion.IdCliente)" +
            "inner join Pedido on(Pedido.IdAsignacion = Asignacion.IdAsignacion) inner join Producto on(Producto.IdProducto= Pedido.IdProducto) where Documento= '" + Documento + "' ";

            DataTable datos = objConexion.mtdDesconectdo(consulta);
            TotalPago.Clear();
          
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    clPago objPago = new clPago();

                    objPago.Nombre = datos.Rows[i]["Nombre"].ToString();
                    objPago.Apellido = datos.Rows[i]["Apellido"].ToString();
                    objPago.CantidadP = int.Parse(datos.Rows[i]["Cantidad"].ToString());
                    objPago.Total = int.Parse(datos.Rows[i]["Total"].ToString());
                    objPago.NombreP = datos.Rows[i]["NombreP"].ToString();
                    objPago.VerifPago = datos.Rows[i]["Pago"].ToString();


                    TotalPago.Add(objPago);
                }

                return TotalPago;
            
          
            
        }

        public List<clPago> mtdValorHabitacion()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT Cliente.Nombre,Cliente.Apellido,Habitacion.NumHabitacion,Habitacion.Precio,Asignacion.FechaLlegada,Asignacion.FechaSalida,Asignacion.IdAsignacion,Asignacion.Pago  FROM Habitacion" +
                " INNER JOIN Asignacion ON(Asignacion.IdHabitacion= Habitacion.IdHabiacion) " +
                "INNER JOIN Cliente ON(Cliente.IdCliente= Asignacion.IdCliente)" +
                "inner join Pedido on(Pedido.IdAsignacion = Asignacion.IdAsignacion) WHERE Documento = '" + Documento + "' ";
            DataTable datos = objConexion.mtdDesconectdo(consulta);
            TotalHabitacion.Clear();
           
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                try
                {
                    clPago objPago = new clPago();

                    objPago.Nombre = datos.Rows[i]["Nombre"].ToString();
                    objPago.Apellido = datos.Rows[i]["Apellido"].ToString();
                    objPago.NumHabitacion = int.Parse(datos.Rows[i]["NumHabitacion"].ToString());
                    objPago.Precio = int.Parse(datos.Rows[i]["Precio"].ToString());
                    objPago.FechaLlegada = DateTime.Parse(datos.Rows[i]["FechaLlegada"].ToString());
                    objPago.FechaSalida = DateTime.Parse(datos.Rows[i]["FechaSalida"].ToString());
                    objPago.IdAsignacion = int.Parse(datos.Rows[i]["IdAsignacion"].ToString());
                    objPago.Pago = datos.Rows[i]["Pago"].ToString();

                    TotalHabitacion.Add(objPago);

                }
                catch (Exception)
                {
                    MessageBox.Show("Debe Dar La Fecha de Salida");

                }
               
            }
            
            return TotalHabitacion;
        }
        public int ValidarPago()
        {
         
                clConexion objConexion = new clConexion();
                string consulta = "insert into Pago (Total,IdAsignacion) values('" + pagar + "','" + IdAsignacion + "')";
                int resultado = objConexion.mtdConectado(consulta);

                if (resultado > 0)
                {
                    string consulta2 = "update Asignacion set Pago = 'Si' where IdCliente = '" + IdClienteB + "'";
                    int resultado1 = objConexion.mtdConectado(consulta2);

                }

                return resultado;
          

        }

        public List<clPago> mtdValidarPagar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT Pago FROM Asignacion WHERE IdCliente ='" + IdClienteB + "'";
            DataTable dtPago = objConexion.mtdDesconectdo(consulta);
            VerificacionPago.Clear();

            for (int i = 0; i < dtPago.Rows.Count; i++)
            {
                clPago objPago = new clPago();

                objPago.Pago = dtPago.Rows[i]["Pago"].ToString();

                VerificacionPago.Add(objPago);
            }

            return VerificacionPago;
        }
    }
}
