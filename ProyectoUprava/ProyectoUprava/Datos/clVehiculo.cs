using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUprava.Datos
{
    class clVehiculo
    {
        public string Documento { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public int IdCliente { get; set; }
        public string BuscarId { get; set; }
        
        public DataTable mtdListarVehiculo()
        {
            clConexion objconexion = new clConexion();
            string consulta = "SELECT Tipo,Marca,Placa,Nombre,Apellido,Documento FROM Vehiculo INNER JOIN Cliente ON (Cliente.IdCliente=Vehiculo.IdCliente)";
            DataTable dtVehiculo = objconexion.mtdDesconectdo(consulta);

            return dtVehiculo;
        }

        public int mtdRegistrarVehiculo()
        {
            clConexion objconexion = new clConexion();
            string consulta = "INSERT INTO Vehiculo (Tipo, Marca, Placa, IdCliente) VALUES ('"+ Tipo + "','" + Marca + "','" + Placa + "','" + IdCliente +"')";
            int retorno = objconexion.mtdConectado(consulta);

            return retorno;
        }

        public int mtdEliminarVehiculo()
        {
            clConexion objconexion = new clConexion();
            string consulta = "DELETE FROM Vehiculo WHERE Placa='"+Placa+"'";
            int retorno = objconexion.mtdConectado(consulta);

            return retorno;
        }

        public DataTable mtdBuscarVehiculo()
        {
            clConexion objconexion = new clConexion();
            string consulta = "SELECT Tipo,Marca,Placa FROM Vehiculo WHERE Placa='" + Placa + "'";
            DataTable dtVehiculo = objconexion.mtdDesconectdo(consulta);

            return dtVehiculo;
        }    

        public int mtdBuscarId()
        {
            clConexion objconexion = new clConexion();
            string consulta = "SELECT IdCliente FROM Cliente WHERE Documento='" + Documento + "'";
            DataTable dtBuscarId = objconexion.mtdDesconectdo(consulta);

            int id = 0;

            for (int i = 0; i < dtBuscarId.Rows.Count; i++)
            {
                clVehiculo objVehiculo = new clVehiculo();
                
                 id = Convert.ToInt32(dtBuscarId.Rows[i]["IdCliente"]);               
            }

            return id;
        }
        
        public int mtdActualizarVehiculo()
        {
            clConexion objconexion = new clConexion();
            string consulta = "UPDATE Vehiculo SET Tipo='"+Tipo+"',Marca='"+Marca+"',Placa='"+IdCliente+"' WHERE Placa='"+Placa+"'";
            int retorno = objconexion.mtdConectado(consulta);

            return retorno;
        }

        public int mtdVerificarVehculo()
        {
            clConexion objconexion = new clConexion();
            string consulta = "SELECT IdCliente FROM Vehiculo WHERE IdCliente='"+IdCliente+"'";
            DataTable idClienteVehi = objconexion.mtdDesconectdo(consulta);

            int id = 0;

            for (int i = 0; i < idClienteVehi.Rows.Count; i++)
            {
                clVehiculo objVehiculo = new clVehiculo();

                id = Convert.ToInt32(idClienteVehi.Rows[i]["IdCliente"]);
            }

            return id;
        }
        
    }
}
