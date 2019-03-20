using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUprava.Datos
{
    class clLogin
    {
        public int Documento { get; set; }
        public string Contraseña { get; set; }
        public string Cargo { get; set; }

        clConexion objConexion = new clConexion();
        List<clLogin> Empleados = new List<clLogin>();

        public List<clLogin> mtdBuscar()
        {
            DataTable Login = new DataTable();
            string Consulta = "Select Documento,Contraseña,Cargo From Empleado";
            Login = objConexion.mtdDesconectdo(Consulta);
            for (int i = 0; i < Login.Rows.Count; i++)
            {
                clLogin objLogin = new clLogin();
                objLogin.Documento = int.Parse(Login.Rows[i]["Documento"].ToString());
                objLogin.Contraseña = Login.Rows[i]["Contraseña"].ToString();
                objLogin.Cargo = Login.Rows[i]["Cargo"].ToString();

                Empleados.Add(objLogin);


            }

            return Empleados;

        }
    }
}
