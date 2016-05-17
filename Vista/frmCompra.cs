using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmCompra : Form
    {
        clsConexionSQL conexion;
        clsCliente cliente;
        clsEntidadCliente entidadCliente;
        clsProducto producto;
        clsEntidadProducto entidadProducto;
        SqlDataReader dtrProducto;
        SqlDataReader dtrCliente;
        SqlDataReader dtrCompra;
        clsCompra compra;
        clsEntidadCompra entidadCompra;

        public frmCompra()
        {
            conexion = new clsConexionSQL();
            entidadProducto = new clsEntidadProducto();
            entidadCliente = new clsEntidadCliente();
            entidadCompra = new clsEntidadCompra();
            producto = new clsProducto();
            cliente = new clsCliente();
            compra = new clsCompra();
            InitializeComponent();

        }

        public void llenarSeguridad()
        {
            conexion.setCodigo("Proyectobases");
            conexion.setClave("Server1..");
        }

        public Boolean validarProducto()
        {
            if ((txtCodigo.Text != "") && (txtDescripcion.Text != "") && (txtPrecio.Text != ""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void agregarProductoAlista()
        {
             if (validarProducto() == true)
            {
                int posicion = lvDetalleCompra.Items.Count;

                ListViewItem item = new ListViewItem(txtCodigo.Text);
                item.SubItems.Add(txtDescripcion.Text);
                item.SubItems.Add(txtPrecio.Text);
                item.SubItems.Add(txtCantidad.Text);
                lvDetalleCompra.Items.Add(item);             

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                consultarProducto();
            }
            else
            {
                MessageBox.Show("Favor digite el código del producto", "Datos insuficientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        public void consultarProducto()
        {
            llenarSeguridad();
            entidadProducto.setCodigo(txtCodigo.Text.Trim());
            dtrProducto = producto.mConsultarCodigo(conexion, entidadProducto);

            if (dtrProducto != null)
            {
                if (dtrProducto.Read())//si existe
                {

                    this.txtDescripcion.Text = dtrProducto.GetString(1);
                    this.txtPrecio.Text = Convert.ToString( dtrProducto.GetInt32(2));                    
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el código solicitado", "Producto no encontrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarProductoAlista();
            txtTotal.Text = Convert.ToString(calcularSubTotal());
        }

        public int calcularSubTotal()
        {
            int subTotal=0;
            //subTotal = Convert.ToInt32(lvDetalleCompra.Items[0].SubItems[2].Text);
            foreach (ListViewItem I in lvDetalleCompra.Items)
            {                
                if (txtTotal.Text != "")
                {
                    //subTotal = Convert.ToInt32(txtTotal.Text);
                }
                
                subTotal += Convert.ToInt32(I.SubItems[2].Text)* Convert.ToInt32(I.SubItems[3].Text);
                

            }

            return subTotal;
        }

        private void llenarEntidades()
        {
            entidadCliente.setNombre(txtNombre.Text.Trim());
            entidadCliente.setApellidos(txtApellidos.Text.Trim());
            entidadCliente.setCedula(txtCedula.Text.Trim());

            entidadCompra.setIdcliente(txtCedula.Text.Trim());
            entidadCompra.setTotal(Convert.ToInt32(txtTotal.Text.Trim()));
        }

        private void btnAgregaCompra_Click(object sender, EventArgs e)
        {
           
            if (verificarCampos() == true)
            {
                llenarSeguridad();
                llenarEntidades();
                dtrCliente = cliente.mSeleccionarCliente(conexion, entidadCliente);
                if (dtrCliente!=null)
                {
                    if (dtrCliente.Read())
                    {
                        compra.mInsertar(conexion,entidadCompra);
                        MessageBox.Show("Compra agregada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //El cliente no existe
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor agregar un producto", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Boolean verificarCampos()
        {
            if ((txtCedula.Text.Trim() != "") & (txtNombre.Text.Trim() != "")  & (txtApellidos.Text.Trim()!="")& (Convert.ToInt32(txtTotal.Text.Trim()) > 0))
            {
                return true;
            }
            return false;
        }
    }
}
