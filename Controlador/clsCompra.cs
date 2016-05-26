using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;
namespace Controlador
{
   public class clsCompra
    {
        private string strSentencia;

		public clsCompra()
        {
            strSentencia = "";
        }
        // Metodo Para Insertar una compra 
        public Boolean mInsertar(clsConexionSQL cone, clsEntidadCompra pEntidadCompra)
        {
            strSentencia = "insert into compra(idCliente, total) values( '" + pEntidadCompra.getIdcliente() + "' , '"+pEntidadCompra.getTotal()+"' )";
            return cone.mEjecutar(strSentencia, cone);
        }

        // Metodo para seleccionar una compra
        public SqlDataReader mSeleccionarCompra(clsConexionSQL cone, clsEntidadCompra pEntidadCompra)
        {
            strSentencia = "SELECT * FROM compra where idCompra='"+pEntidadCompra.getIdcliente()+"' ;";
            return cone.mSeleccionar(strSentencia,cone);
        }

        // Metodo Para eliminar una compra 
        public Boolean mEliminarCompra(clsConexionSQL cone, clsEntidadCompra pEntidadCompra)
        {
           // strSentencia = "DELETE * FROM compra WHERE idCompra='"+pEntidadCompra.getIdcompra()+"' ;";
            return cone.mEjecutar(strSentencia, cone);
        }
    }
}
