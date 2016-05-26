using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using Modelo;
using Controlador;
namespace Vista
{
    public partial class frmAcceso : Form
    {
        private clsConexionSQL conexion;
        private SqlDataReader dtr;
        
        public frmAcceso()
        {
            InitializeComponent();
            conexion = new clsConexionSQL();
            
            this.btnIngresar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        

      

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                conexion.setCodigo("Proyectobases");
                conexion.setClave("Server1..");
                if (conexion.mConectar(conexion))
                {
                    verificarUsuario();
                }
                else
                {
                    MessageBox.Show("Surgio un Error");
                }
            }
        }

        public void verificarUsuario()
        {
            if(!this.txtContraseña.Text.Trim().Equals("")&& !this.txtUsuario.Text.Trim().Equals(""))
            {
                String usuario = this.txtUsuario.Text;
                String clave = this.txtContraseña.Text;
                Boolean usuarioEncontrado = false;
                String strSentencia = "SELECT * FROM usuario where nombre='" + usuario + "'  and clave='" + clave + "'";
                dtr = conexion.mSeleccionar(strSentencia, conexion);
                if(dtr!=null)
                {
                    if(dtr.Read())
                    {
                        usuarioEncontrado = true;
                    }
                }

                if(usuarioEncontrado)
                {
                    this.btnIngresar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Usuario No Registrado", "Error",
                                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("Debe de Completar Los Campos", "Error",
                                              MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmCompra frmMantenimiento = new frmCompra();
            frmMantenimiento.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
