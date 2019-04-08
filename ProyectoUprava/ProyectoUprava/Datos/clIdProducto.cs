using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoUprava.Datos
{
    class clIdProducto
    {
        public DataTable mtdCarcarCombos()
        {
            clConexion objConexion = new clConexion();
            string consulta = "SELECT IdProducto,NombreP FROM Producto";
            DataTable dtcombos = objConexion.mtdDesconectdo(consulta);

            return dtcombos;
        }
    }
}
