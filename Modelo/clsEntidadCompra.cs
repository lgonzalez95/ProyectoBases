using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadCompra
    {
        #region Atributos
        private string cedula;
        private int total;
        #endregion

        #region Propiedades

        //Set
        public void setCedula(string cedula)
        {
            this.cedula = cedula;
        }
        public void setTotal(int total)
        {
            this.total = total;
        }
        //Get
        public string getCedula()
        {
            return this.cedula;
        }
        public int getTotal()
        {
            return this.total;
        }
        #endregion
    }
}
