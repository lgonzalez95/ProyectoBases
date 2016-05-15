using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadProducto
    {
        #region Atributos
        private string codigo;
        private string descripcion;
        private int precio;
        private int cantidad;
        #endregion

        #region Propiedades
        //set
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public void setPrecio(int precio)
        {
            this.precio = precio;
        }
        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        //get

        public string getCodigo()
        {
            return this.codigo;
        }
        public string getDescripcion()
        {
            return this.descripcion;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }
        public int getPrecio()
        {
            return this.precio;
        }

        #endregion
    }
}
