using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoUprava.Datos
{
    class clPedido
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public string FechaHora { get; set; }
        public int Total { get; set; }
        public int NumHabitacion { get; set; }
        public string Documento { get; set; }
        public int Precio { get; set; }
        public int NuevaCantidad { get; set; }
        public int idProducto { get; set; }
        public int idHab { get; set; }
        public int IdAsignacion { get; set; }
        public string Estado { get; set; }



        public int mtdRegistrar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "insert into Pedido(Cantidad,Total,FechaHora,IdAsignacion,IdProducto)" + "values( '" + Cantidad + "' , '" + Total + "','" + FechaHora + "','"+IdAsignacion+"','" + idProducto + "')";
            int RegistrarPedido = objConexion.mtdConectado(consulta);

            return RegistrarPedido;
        }


        public int mtdAsignar()
        {
          
            clConexion objConexion = new clConexion();

            string consulta = "SELECT IdHabiacion from Habitacion where NumHabitacion= '" + NumHabitacion + "'";
            DataTable dtAsignar = objConexion.mtdDesconectdo(consulta);

            int idHabitacion = 0;

            for (int i = 0; i < dtAsignar.Rows.Count; i++)
            {
                clPedido objPedido = new clPedido();
               
                idHabitacion = int.Parse(dtAsignar.Rows[i]["IdHabiacion"].ToString());
                               
            }

            return idHabitacion;

        }

        public List<clPedido> mtdTraer()
        {
            clConexion objConexion = new clConexion();
            List<clPedido> DatosProducto = new List<clPedido>();

            string consultaP = "SELECT Precio,Cantidad From Producto WHERE NombreP='" + Producto + "'";
            DataTable dtDatosProducto = objConexion.mtdDesconectdo(consultaP);

            for (int i = 0; i < dtDatosProducto.Rows.Count; i++)
            {
                clPedido objPedido = new clPedido();

                objPedido.Precio = int.Parse(dtDatosProducto.Rows[i]["Precio"].ToString());
                objPedido.Cantidad = int.Parse(dtDatosProducto.Rows[i]["Cantidad"].ToString());


                DatosProducto.Add(objPedido);
            }

            return DatosProducto;
        }

        public int mtdActualizarProducto()
        {
            clConexion objConexion = new clConexion();
            string consulta = "update Producto set Cantidad='" + NuevaCantidad + "' where NombreP ='" + Producto + "'";
            int update = objConexion.mtdConectado(consulta);
            return update;
        }

        public int mtdIdAsignacion()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT IdAsignacion FROM Asignacion WHERE IdHabitacion ='"+idHab+"'";
            DataTable dtIdAsignacion = objConexion.mtdDesconectdo(consulta);

            int IdAsignacion = 0;

            for (int i = 0; i < dtIdAsignacion.Rows.Count; i++)
            {
                clPedido objPedido = new clPedido();

                IdAsignacion = int.Parse(dtIdAsignacion.Rows[i]["IdAsignacion"].ToString());
            }

            return IdAsignacion;
        }

        public string mtdEstado()
        {

            clConexion objConexion = new clConexion();

            string consulta = "SELECT EstadoDisponibilidad from Habitacion where NumHabitacion= '" + NumHabitacion + "'";
            DataTable dtEstado = objConexion.mtdDesconectdo(consulta);

            string Estado = "";

            for (int i = 0; i < dtEstado.Rows.Count; i++)
            {
                clPedido objPedido = new clPedido();

                Estado = dtEstado.Rows[i]["EstadoDisponibilidad"].ToString();

            }

            return Estado;

        }

    }
}
