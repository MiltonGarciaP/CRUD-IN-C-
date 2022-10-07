using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Mercancia.Modelo;

namespace Mercancia.Controlador
{
    class CMercancias
    {
        MMercancia cliente = new MMercancia();
        private string Nombre = null;

        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = cliente.MostrarCliente();

            return tabla;
        }

        public void InsertaCliente(string Nombre, string Apellido, string Direccion, string FechaNacimiento, string Telefono )
        {
            cliente.InsertarCliente(Nombre, Apellido, Direccion, FechaNacimiento, Convert.ToInt32(Telefono));

        }

        public void EliminarCliente(string Nombre)
        {
           cliente.EliminarCliente(Nombre);
        }

        public void ActualizarCliente(string Nombre, string Apellido, string Direccion, string FechaNacimiento, string Telefono)
        {
            cliente.ActualizarCliente(Nombre , Apellido , Direccion , FechaNacimiento , Convert.ToInt32(Telefono));
        }

        public void BuscarCliente(string nombre)
        {
            cliente.BuscarCliente(Nombre);
        }

        
    }
}
