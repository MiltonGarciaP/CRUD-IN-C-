using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Mercancia.Modelo

{
    class MMercancia
    {
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();


        // Para enseñar los datos de la tabla de la base de datos con proc en sql server 
        public DataTable MostrarCliente()
        {
            comando.Connection = conexion.AbriConexion();
            comando.CommandText = "MostrarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            conexion.CerrarConexion();

            return Tabla;
       }
        // creación del metodo de insertar Mercancia 
        public void InsertarCliente(string Nombre , string Apellido , string direccion , string FechaNacimiento , int Telefono )
        {
            comando.Connection = conexion.AbriConexion();
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Dirección", direccion);
            comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
          

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        // Creacion del metodo de Eliminar Mercancia con procedure 
        public void EliminarCliente(string Nombre)
        {
            comando.Connection = conexion.AbriConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        // Creacion para Actualizar o modificar una mercancia 
        public void ActualizarCliente(string Nombre , string Apellido , string direccion , string FechaNacimiento ,int telefono)
        {
            comando.Connection = conexion.AbriConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Dirección", direccion);
            comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void BuscarCliente(string Nombre)
        {

            comando.Connection = conexion.AbriConexion();
            comando.CommandText = "buscarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            conexion.CerrarConexion();

            



        }

        
    }


   
}
