using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;

namespace Controlador
{
    public class clsCliente
    {

        private string strSentencia;

        public clsCliente()
        {
            strSentencia = "";
        }
        // Metodo Para Insertar una compra 
        public Boolean mInsertarCliente(clsConexionSQL cone, clsEntidadCliente pEntidadEntidadCliente)
        {
            strSentencia = "insert into cliente(cedula,nombre, apellidos) values('" + pEntidadEntidadCliente.getCedula() +
                            "', '" + pEntidadEntidadCliente.getNombre() + "' , '" + pEntidadEntidadCliente.getApellidos() + "' )";
            return cone.mEjecutar(strSentencia, cone);
        }

        public Boolean mModificarCliente(clsConexionSQL cone, clsEntidadCliente pEntidadEntidadCliente)
        {
            strSentencia = "update cliente set nombre = ('" + pEntidadEntidadCliente.getCedula() + "', apellidos = '" + pEntidadEntidadCliente.getApellidos() + "' )";
            return cone.mEjecutar(strSentencia, cone);
        }

        // Metodo para seleccionar una compra
        public SqlDataReader mSeleccionarCliente(clsConexionSQL cone, clsEntidadCliente pEntidadEntidadCliente)
        {
            strSentencia = "SELECT * FROM cliente where cedula='" + pEntidadEntidadCliente.getCedula() + "' ;";
            return cone.mSeleccionar(strSentencia, cone);
        }

        // Metodo Para eliminar una compra 
        public Boolean mEliminarClientes(clsConexionSQL cone, clsEntidadCliente pEntidadEntidadCliente)
        {
            strSentencia = "DELETE * FROM cliente WHERE cedula='" + pEntidadEntidadCliente.getCedula() + "' ;";
            return cone.mEjecutar(strSentencia, cone);
        }
    }
}
