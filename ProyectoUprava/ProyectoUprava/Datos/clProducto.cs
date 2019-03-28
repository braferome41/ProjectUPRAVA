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

        clConexion objConexion = new clConexion();

        List<clProducto> ListaProducto = new List<clProducto>();
        
        public List<clProducto> mtdListar()
        {
            DataTable dtProducto = new DataTable();

            string consulta = "select * from Producto";
            dtProducto = objConexion.mtdDesconectdo(consulta);

            for (int i = 0; i < dtProducto.Rows.Count; i++)
            {
                clProducto objProducto = new clProducto();

                objProducto.Codigo = int.Parse(dtProducto.Rows[i]["Codigo"].ToString());
                objProducto.Nombre = dtProducto.Rows[i]["Nombre"].ToString();
                objProducto.Precio = int.Parse(dtProducto.Rows[i]["Precio"].ToString());
                objProducto.Cantidad = int.Parse(dtProducto.Rows[i]["Cantidad"].ToString());

                ListaProducto.Add(objProducto);

            }
            return ListaProducto;
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
            string consulta = "insert into Producto(Codigo,Nombre,Precio,Cantidad)" +
                              "values( '" + Codigo + "' , '" + Nombre + "','" + Precio + "','" + Cantidad + "')";
            int canreg = objConexion.mtdConectado(consulta);
            return canreg;
        }
        public int mtdActualizar()
        {
            string consulta = "update Producto set Codigo='" + Codigo + "',Nombre='" + Nombre + "',Precio='" + Precio + "',Cantidad='" + Cantidad + "' where Codigo =" + Codigo;
            int canact = objConexion.mtdConectado(consulta);
            return canact;
        }
        public int mtdEliminar()
        {
            string consulta = "Delete from Producto where Codigo='" + Codigo + "'";
            int caneli = objConexion.mtdConectado(consulta);
            return caneli;

        }
        public DataTable mtdValidar()
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

    }
}
