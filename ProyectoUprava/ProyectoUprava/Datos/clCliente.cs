using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUprava.Datos
{
    class clCliente
    {
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        List<clCliente> verificarelimin = new List<clCliente>();

        public DataTable mtdListarClinte()
        {
            clConexion objConexion = new clConexion();

            string consulta = "SELECT Documento,Nombre,Apellido,Ciudad,Email,Celular FROM Cliente";
            DataTable dtCliente = objConexion.mtdDesconectdo(consulta);

            return dtCliente;
        }

        public int mtdRegistrarCliente()
        {
            clConexion objConexion = new clConexion();

            string consulta = "INSERT INTO Cliente (Documento, Nombre, Apellido, Ciudad, Email, Celular) VALUES ('"+Documento+ "','" + Nombres + "','" + Apellidos + "'," +
                "'" + Ciudad + "','" + Email + "','" + Celular +"')";
            int retorno = objConexion.mtdConectado(consulta);

            return retorno;
        }

        public int mtdActualizarCliente()
        {
            clConexion objConexion = new clConexion();

            string consulta = "UPDATE Cliente SET Nombre='" + Nombres + "',Apellido='" + Apellidos + "',Ciudad='" + Ciudad + "',Email='" + Email + "',Celular='" + Celular + "' WHERE Documento='"+Documento+"'";
            int retorno = objConexion.mtdConectado(consulta);

            return retorno;
        }

        public int mtdEliminarCliente()
        {
            clConexion objConexion = new clConexion();
            
            string consulta = "DELETE FROM Cliente WHERE Documento='"+Documento+"'";
            int retorno = objConexion.mtdConectado(consulta);

            return retorno;
        }

        public DataTable mtdBuscarCliente()
        {
            clConexion objConexion = new clConexion();

            string consulta = "SELECT Documento,Nombre,Apellido,Ciudad,Email,Celular FROM Cliente WHERE Documento='" + Documento + "'";
            DataTable dtBusClient = objConexion.mtdDesconectdo(consulta);

            return dtBusClient;
        }

        public string mtdVerificarCliente()
        {
            clConexion objConexion = new clConexion();

            string consulta = "SELECT Documento FROM Cliente WHERE Documento='" + Documento + "'";
            DataTable dtCliente = objConexion.mtdDesconectdo(consulta);

            string documento = "";

            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                clCliente objCliente = new clCliente();

                documento = dtCliente.Rows[i]["Documento"].ToString();                
            }

            return documento;
        }

        public List<clCliente> mtdVerificarEliminacionBusqueda()
        {
            clConexion objconexion = new clConexion();
            string consulta = "SELECT Documento FROM Cliente";
            DataTable dtCliente = objconexion.mtdDesconectdo(consulta);

            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                clCliente objCliente = new clCliente();

                objCliente.Documento = dtCliente.Rows[i]["Documento"].ToString();
                verificarelimin.Add(objCliente);
            }

            return verificarelimin;
        }
        public int mtdCargarCliente()
        {
            clConexion objConexion = new clConexion();

            string consulta = "SELECT IdCliente FROM Cliente where Documento='" + Documento + "'";
            DataTable dtCliente = objConexion.mtdDesconectdo(consulta);

            int IdCliente=0;

            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {

                clCliente objCliente = new clCliente();
                IdCliente = Convert.ToInt32(dtCliente.Rows[i]["IdCliente"]);
            }
            return IdCliente;
        }

    }
}
