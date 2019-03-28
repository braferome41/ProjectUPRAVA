using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoUprava.Datos
{
    class clConexion
    {
        SqlConnection conexion = null;

        public clConexion()
        {
            conexion = new SqlConnection("Data Source=.;Initial Catalog=bdUprava;Integrated Security=True");
        }

        public int mtdConectado(string consulta)
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int validacion = comando.ExecuteNonQuery();
                conexion.Close();

                return validacion;
            }
            catch (Exception err)
            {
                string error = err.Message;
                return 0;
            }
        }

        public DataTable mtdDesconectdo(string consulta)
        {
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dtDatos = new DataTable();
                adaptador.Fill(dtDatos);
                conexion.Close();

                return dtDatos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en la Conexion con la Base de Datos");
                DataTable objretorno = new DataTable();
                return objretorno;
            }

        }
    }
}


