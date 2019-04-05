using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoUprava.Datos
{
    class clEmpleado
    {
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Cargo { get; set; }
        public int selecdoc { get; set; }

        public List<clEmpleado> mtdVerificarEliminacionBusqueda()
        {
            clConexion objconexion = new clConexion();
            List<clEmpleado> verificarelimin = new List<clEmpleado>();

            string consulta = "SELECT Documento FROM Empleado";
            DataTable dtEmpleado = objconexion.mtdDesconectdo(consulta);

            for (int i = 0; i < dtEmpleado.Rows.Count; i++)
            {
                clEmpleado objEmpleado = new clEmpleado();

                objEmpleado.Documento = dtEmpleado.Rows[i]["Documento"].ToString();

                verificarelimin.Add(objEmpleado);
            }

            return verificarelimin;
        }

        public int mtdRegistrar()
        {
            clConexion objConexion = new clConexion();

            string consulta = "insert INTO Empleado(Documento,Nombres,Apellidos,Celular,Email,Ciudad,Direccion,Cargo,Contraseña)values('" + Documento + "','" + Nombres + "','" + Apellidos + "','" + Celular + "','" + Email + "','" + Ciudad + "','" + Direccion + "','" + Cargo + "','" + Contraseña + "')";
            int cantidad = objConexion.mtdConectado(consulta);

            return cantidad;

        }

        public int mtdModificar()
        {
            clConexion objConexion = new clConexion();

            string consulta = "update Empleado set Documento='" + Documento + "',Nombres='" + Nombres + "',Apellidos='" + Apellidos + "',Celular='" + Celular + "',Email='" + Email + "',Ciudad='" + Ciudad + "',Direccion='" + Direccion + "',Cargo='" + Cargo + "',Contraseña='" + Contraseña + "' where Documento= " + selecdoc;
            int cantidad = objConexion.mtdConectado(consulta);

            return cantidad;
        }

        public int mtdEliminar()
        {
            clConexion objConexion = new clConexion();

            string consulta = "Delete from Empleado where Documento='" + Documento + "'";
            int borrado = objConexion.mtdConectado(consulta);

            return borrado;
        }

        public DataTable mtdBuscarEmpleado()
        {

            clConexion objConexion = new clConexion();

            string consulta = "SELECT Documento,Nombres,Apellidos,Ciudad,Email,Celular FROM Empleado WHERE Documento='" + Documento + "'";
            DataTable dtEmpleado = objConexion.mtdDesconectdo(consulta);

            return dtEmpleado;

        }

        public DataTable mtdListarEmpleado()
        {
            clConexion objConexion = new clConexion();

            string consulta = "SELECT Documento,Nombres,Apellidos,Ciudad,Email,Celular FROM Empleado";
            DataTable dtEmpleado = objConexion.mtdDesconectdo(consulta);

            return dtEmpleado;
        }

        public int mtdValidar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT Documento FROM Empleado WHERE Documento='" + Documento + "'";
            DataTable dtValidar = objConexion.mtdDesconectdo(consulta);

            int Doc = 0;

            for (int i = 0; i < dtValidar.Rows.Count; i++)
            {
                clEmpleado objEmpleado = new clEmpleado();

                Doc = Convert.ToInt32(dtValidar.Rows[i]["Documento"]);
            }

            return Doc;
        }
    }
}
