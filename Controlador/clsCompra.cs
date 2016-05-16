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

        public Boolean mInsertar(clsConexionSQL cone, clsEntidadCompra pEntidadCompra)
        {
            strSentencia = "insert into tbCompra(cedula, total) values('" + pEntidadCompra.getCedula() +
                            "', '" + pEntidadCompra.getTotal() + "')";//Si da error quitar comillas simples
            return cone.mEjecutar(strSentencia, cone);
        }
    }
}
