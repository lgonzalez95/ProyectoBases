using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadCliente
    {
        #region Atributos
        private string cedula;
        private string nombreCompleto;
        private int tipoCliente;
        private string telefono;
        private string email;
        #endregion

        #region Propiedades

        //Set
        public void setCedula(string cedula)
        {
            this.cedula = cedula;
        }
        public void setNombreCompleto(string nombreCompleto)
        {
            this.nombreCompleto = nombreCompleto;
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setTipoCliente(int tipo)
        {
            this.tipoCliente = tipo;
        }

        //Get

        public string getCedula()
        {
            return this.cedula;
        }
        public string getNombreCompleto()
        {
            return this.nombreCompleto;
        }
        public string getTelefono()
        {
            return this.telefono;
        }
        public string getEmail()
        {
            return this.email;
        }
        public int getTipoCliente()
        {
            return this.tipoCliente;
        }
        #endregion
    }
}
