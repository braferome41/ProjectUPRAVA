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

        clConexion objConexion = new clConexion();

        public int mtdRegistrar()
        {

            string consulta = "insert into Pedido(Cantidad,Total,FechaHora,IdProducto)" + "values( '" + Cantidad + "' , '" + Total + "','" + FechaHora + "','" + idProducto + "')";
            int RegistrarPedido = objConexion.mtdConectado(consulta);

            return RegistrarPedido;
        }


        public List<clPedido> mtdAsignar()
        {
            clConexion objConexion = new clConexion();
            List<clPedido> ListaPedido = new List<clPedido>();

            string consulta = "SELECT Documento,NumHabitacion FROM Asignacion inner join Cliente on Asignacion.IdCliente=Cliente.IdCliente inner join Habitacion on Asignacion.IdHabitacion=Habitacion.IdHabitacion WHERE NumHabitacion='" + NumHabitacion + "'";
            DataTable dtAsignar = objConexion.mtdDesconectdo(consulta);

            for (int i = 0; i < dtAsignar.Rows.Count; i++)
            {
                clPedido objPedido = new clPedido();

                objPedido.Documento = dtAsignar.Rows[i]["Documento"].ToString();
                objPedido.NumHabitacion = int.Parse(dtAsignar.Rows[i]["NumHabitacion"].ToString());


                ListaPedido.Add(objPedido);
            }

            return ListaPedido;

        }

        public List<clPedido> mtdTraer()
        {
            clConexion objConexion = new clConexion();
            List<clPedido> DatosProducto = new List<clPedido>();

            string consultaP = "SELECT Precio,Cantidad From Producto WHERE Nombre='" + Producto + "'";
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
            string consulta = "update Producto set Cantidad='" + NuevaCantidad + "' where Nombre ='" + Producto + "'";
            int update = objConexion.mtdConectado(consulta);
            return update;
        }

    }
}
