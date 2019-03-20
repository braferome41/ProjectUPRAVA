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
        public int Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Cargo { get; set; }
        public int selecdoc { get; set; }


        List<clEmpleado> ListaVehiculos = new List<clEmpleado>();

        public List<clEmpleado> mtdListar()
        {
            clConexion objConexion = new clConexion();

            DataTable dtEmpleado = new DataTable();

            string consulta = "select * from Empleado";
            dtEmpleado = objConexion.mtdDesconectdo(consulta);

            for (int i = 0; i < dtEmpleado.Rows.Count; i++)
            {
                clEmpleado objEmpleado = new clEmpleado();

                objEmpleado.Documento = int.Parse(dtEmpleado.Rows[i]["Documento"].ToString());
                objEmpleado.Nombres = dtEmpleado.Rows[i]["Nombres"].ToString();
                objEmpleado.Apellidos = dtEmpleado.Rows[i]["Apellidos"].ToString();
                objEmpleado.Celular = dtEmpleado.Rows[i]["Celular"].ToString();
                objEmpleado.Email = dtEmpleado.Rows[i]["Email"].ToString();
                objEmpleado.Ciudad = dtEmpleado.Rows[i]["Ciudad"].ToString();
                objEmpleado.Direccion = dtEmpleado.Rows[i]["Direccion"].ToString();
                objEmpleado.Cargo = dtEmpleado.Rows[i]["Cargo"].ToString();
                objEmpleado.Contraseña = dtEmpleado.Rows[i]["Contraseña"].ToString();

                ListaVehiculos.Add(objEmpleado);

            }

            return ListaVehiculos;

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

            string consulta = "Delete from Empleado where Documento='" + selecdoc + "'";
            int borrado = objConexion.mtdConectado(consulta);

            return borrado;
        }

    }
}
