using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
    public class clsProducto
    {
        private string strSentencia;

        public clsProducto()
        {
            strSentencia = "";
        }

        public SqlDataReader mConsultarCodigo(clsConexionSQL cone, clsEntidadProducto pEntidadProducto)
        {
            strSentencia = "Select * from producto where idProducto ='" + pEntidadProducto.getCodigo() + "'                     ";
            return cone.mSeleccionar(strSentencia, cone);
        }
    }
}
