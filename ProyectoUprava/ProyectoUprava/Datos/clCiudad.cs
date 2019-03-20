using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUprava.Datos
{
    class clCiudad
    {
        public DataTable mtdCargarCiudad()
        {
            clConexion objConexion = new clConexion();
            
            string consulta = "SELECT *FROM Ciudad";
            DataTable dtCiudad = objConexion.mtdDesconectdo(consulta);

            return dtCiudad;
        }
    }
}
