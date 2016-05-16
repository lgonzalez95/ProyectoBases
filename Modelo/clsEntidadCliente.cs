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
        private string nombre;        
        private string apellidos;        
        #endregion

        #region Propiedades

        //Set
        public void setCedula(string cedula)
        {
            this.cedula = cedula;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
             
        

        //Get

        public string getCedula()
        {
            return this.cedula;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellidos()
        {
            return this.apellidos;
        }
        
        #endregion
    }
}
