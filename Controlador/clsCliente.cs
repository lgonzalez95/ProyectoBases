using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
    public class clsCliente
    {
        private string strSentencia;

        public clsCliente()
        {
            strSentencia = "";
        }

        public SqlDataReader mConsultarCodigo(clsConexionSQL cone, clsEntidadCliente pEntidadCliente)
        {
            strSentencia = "Select * from cliente where cedula ='" + pEntidadCliente.getCedula() + "'                     ";
            return cone.mSeleccionar(strSentencia, cone);
        }
    }
}
