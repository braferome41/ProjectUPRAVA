using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoUprava.Datos
{
    class clProducto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int Cantidad2 { get; set; }

                
        public DataTable mtdListar()
        {
            clConexion objConexion = new clConexion();

            DataTable dtProducto = new DataTable();

            string consulta = "select Codigo,Cantidad,Precio,Nombre from Producto";
            dtProducto = objConexion.mtdDesconectdo(consulta);
            
            return dtProducto;
        }


        public DataTable mtdBuscar()
        {
            clConexion objConexion = new clConexion();

            string consulta = "SELECT Codigo FROM Producto WHERE Codigo='" + Codigo + "'";
            DataTable dtValidar = objConexion.mtdDesconectdo(consulta);

            int codigo = 0;

            for (int i = 0; i < dtValidar.Rows.Count; i++)
            {
                clProducto objProducto = new clProducto();
                codigo = Convert.ToInt32(dtValidar.Rows.Count);
            }

            return dtValidar;
        }


        public int mtdRegistrar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "insert into Producto(Codigo,Nombre,Precio,Cantidad)" +
                              "values( '" + Codigo + "' , '" + Nombre + "','" + Precio + "','" + Cantidad + "')";
            int canreg = objConexion.mtdConectado(consulta);
            return canreg;
        }

        public int mtdActualizar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "update Producto set Codigo='" + Codigo + "',Nombre='" + Nombre + "',Precio='" + Precio + "',Cantidad='" + Cantidad + "' where Codigo =" + Codigo;
            int canact = objConexion.mtdConectado(consulta);
            return canact;
        }

        public int mtdEliminar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "Delete from Producto where Codigo='" + Codigo + "'";
            int caneli = objConexion.mtdConectado(consulta);
            return caneli;

        }

        public int mtdValidar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT Codigo FROM Producto WHERE Codigo='" + Codigo + "'";
            DataTable dtValidar = objConexion.mtdDesconectdo(consulta);

            int codigo = 0;

            for (int i = 0; i < dtValidar.Rows.Count; i++)
            {
                clProducto objProducto = new clProducto();

                codigo = Convert.ToInt32(dtValidar.Rows[i]["Codigo"]);
            }

            return codigo;
        }

        public int mtdProduccion()
        {
            clConexion objConexion = new clConexion();
            string consulta = "Select Cantidad from Producto";
            DataTable dtProducto = objConexion.mtdDesconectdo(consulta);

            int producto = 0;

            for (int i = 0; i < dtProducto.Rows.Count; i++)
            {
                clProducto objProducto = new clProducto();

                producto = Convert.ToInt32(dtProducto.Rows[i]["Cantidad"]);
            }

            return producto;
        }

        public int mtdRegistrarExistent()
        {
            clConexion objConexion = new clConexion();
            string consulta = "Select Cantidad from Producto Where Codigo='"+Codigo+"'";
            DataTable dtCantidad = objConexion.mtdDesconectdo(consulta);

            int cantidad = 0;

            for (int i = 0; i < dtCantidad.Rows.Count; i++)
            {
                clProducto objProducto = new clProducto();

                cantidad = Convert.ToInt32((dtCantidad.Rows[i]["Cantidad"]));
            }

            return cantidad;
        }

        public int mtdRegsitrarExitentUpdate()
        {
            clConexion objConexion = new clConexion();
            string consulta = "UPDATE Producto SET Cantidad='" + Cantidad2 + "' WHERE Codigo='" + Codigo + "'";
            int cantidad = objConexion.mtdConectado(consulta);

            return cantidad;
        }

    }
}
