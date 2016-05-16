using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadCompra
    {
        // Region para los atributos    
        #region Atributos
        private string idCompra;
        private string idCliente;
        private int total;

        #endregion

        #region Propiedades

        //Metodos Set de los atributos
        public void setIdcliente(string idCliente)
        {
            this.idCliente = idCliente;
        }
        public void setTotal(int total)
        {
            this.total = total;
        }
        public void setIdCompra(string idCompra)
        {
            this.idCompra = idCompra;
        }
        //Metodos get para los atributos
        public string getIdcliente()
        {
            return this.idCliente;
        }
        public int getTotal()
        {
            return this.total;
        }
        public string getIdcompra()
        {
            return idCompra;
        }
        #endregion
    }
}
