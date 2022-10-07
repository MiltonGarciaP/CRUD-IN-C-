using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mercancia.Modelo
{

    // Clase para la conexion para la base de datos 
  public   class Conexion
    {
        SqlConnection con = new SqlConnection("Server=.;Database =Francisco;Integrated Security = true");



        public SqlConnection AbriConexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;

        }

        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
