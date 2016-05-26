namespace Vista
{
    partial class frmCompra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boxInfcliente = new System.Windows.Forms.GroupBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lvDetalleCompra = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.boxInfProducto = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.boxControles = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarCompra = new System.Windows.Forms.Button();
            this.btnModificarCompra = new System.Windows.Forms.Button();
            this.btnAgregaCompra = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.boxInfcliente.SuspendLayout();
            this.boxInfProducto.SuspendLayout();
            this.boxControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(844, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 21);
            this.textBox1.TabIndex = 2;
            // 
            // boxInfcliente
            // 
            this.boxInfcliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.boxInfcliente.Controls.Add(this.btnBuscarCliente);
            this.boxInfcliente.Controls.Add(this.lblApellidos);
            this.boxInfcliente.Controls.Add(this.btnModificarCompra);
            this.boxInfcliente.Controls.Add(this.txtApellidos);
            this.boxInfcliente.Controls.Add(this.txtNombre);
            this.boxInfcliente.Controls.Add(this.txtCedula);
            this.boxInfcliente.Controls.Add(this.lblCedula);
            this.boxInfcliente.Controls.Add(this.lblNombreCompleto);
            this.boxInfcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInfcliente.Location = new System.Drawing.Point(36, 50);
            this.boxInfcliente.Name = "boxInfcliente";
            this.boxInfcliente.Size = new System.Drawing.Size(312, 260);
            this.boxInfcliente.TabIndex = 0;
            this.boxInfcliente.TabStop = false;
            this.boxInfcliente.Text = "Información del cliente";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(12, 129);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(74, 17);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(139, 128);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 23);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(139, 42);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 23);
            this.txtCedula.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(9, 48);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(56, 15);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(9, 85);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(62, 15);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(9, 128);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 15);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 15);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 40);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lvDetalleCompra
            // 
            this.lvDetalleCompra.BackColor = System.Drawing.Color.YellowGreen;
            this.lvDetalleCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.descripcion,
            this.precio,
            this.cantidad});
            this.lvDetalleCompra.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lvDetalleCompra.FullRowSelect = true;
            this.lvDetalleCompra.GridLines = true;
            this.lvDetalleCompra.HideSelection = false;
            this.lvDetalleCompra.Location = new System.Drawing.Point(25, 357);
            this.lvDetalleCompra.MultiSelect = false;
            this.lvDetalleCompra.Name = "lvDetalleCompra";
            this.lvDetalleCompra.Size = new System.Drawing.Size(661, 179);
            this.lvDetalleCompra.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvDetalleCompra.TabIndex = 4;
            this.lvDetalleCompra.TabStop = false;
            this.lvDetalleCompra.UseCompatibleStateImageBehavior = false;
            this.lvDetalleCompra.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            this.codigo.Width = 109;
            // 
            // descripcion
            // 
            this.descripcion.Text = "Descripción";
            this.descripcion.Width = 233;
            // 
            // precio
            // 
            this.precio.Text = "Precio";
            this.precio.Width = 183;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 131;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(477, 622);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // boxInfProducto
            // 
            this.boxInfProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.boxInfProducto.Controls.Add(this.btnBuscar);
            this.boxInfProducto.Controls.Add(this.btnAgregar);
            this.boxInfProducto.Controls.Add(this.txtCantidad);
            this.boxInfProducto.Controls.Add(this.txtCodigo);
            this.boxInfProducto.Controls.Add(this.txtPrecio);
            this.boxInfProducto.Controls.Add(this.txtDescripcion);
            this.boxInfProducto.Controls.Add(this.lblCantidad);
            this.boxInfProducto.Controls.Add(this.lblPrecio);
            this.boxInfProducto.Controls.Add(this.lblDescripcion);
            this.boxInfProducto.Controls.Add(this.lblCodigo);
            this.boxInfProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInfProducto.Location = new System.Drawing.Point(374, 50);
            this.boxInfProducto.Name = "boxInfProducto";
            this.boxInfProducto.Size = new System.Drawing.Size(312, 260);
            this.boxInfProducto.TabIndex = 101;
            this.boxInfProducto.TabStop = false;
            this.boxInfProducto.Text = "Información del producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(57, 208);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 37);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(208, 208);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 37);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(139, 171);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(139, 128);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 23);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(9, 171);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 15);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // boxControles
            // 
            this.boxControles.Controls.Add(this.btnSalir);
            this.boxControles.Controls.Add(this.btnEliminarCompra);
            this.boxControles.Controls.Add(this.btnAgregaCompra);
            this.boxControles.Location = new System.Drawing.Point(25, 542);
            this.boxControles.Name = "boxControles";
            this.boxControles.Size = new System.Drawing.Size(268, 131);
            this.boxControles.TabIndex = 102;
            this.boxControles.TabStop = false;
            this.boxControles.Text = "Controles ";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(91, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 45);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEliminarCompra
            // 
            this.btnEliminarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCompra.Image")));
            this.btnEliminarCompra.Location = new System.Drawing.Point(175, 20);
            this.btnEliminarCompra.Name = "btnEliminarCompra";
            this.btnEliminarCompra.Size = new System.Drawing.Size(75, 48);
            this.btnEliminarCompra.TabIndex = 2;
            this.btnEliminarCompra.UseVisualStyleBackColor = true;
            this.btnEliminarCompra.Click += new System.EventHandler(this.btnEliminarCompra_Click);
            // 
            // btnModificarCompra
            // 
            this.btnModificarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCompra.Image")));
            this.btnModificarCompra.Location = new System.Drawing.Point(203, 208);
            this.btnModificarCompra.Name = "btnModificarCompra";
            this.btnModificarCompra.Size = new System.Drawing.Size(75, 37);
            this.btnModificarCompra.TabIndex = 1;
            this.btnModificarCompra.UseVisualStyleBackColor = true;
            this.btnModificarCompra.Click += new System.EventHandler(this.btnModificarCompra_Click);
            // 
            // btnAgregaCompra
            // 
            this.btnAgregaCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaCompra.Image")));
            this.btnAgregaCompra.Location = new System.Drawing.Point(11, 20);
            this.btnAgregaCompra.Name = "btnAgregaCompra";
            this.btnAgregaCompra.Size = new System.Drawing.Size(75, 48);
            this.btnAgregaCompra.TabIndex = 0;
            this.btnAgregaCompra.UseVisualStyleBackColor = true;
            this.btnAgregaCompra.Click += new System.EventHandler(this.btnAgregaCompra_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(526, 619);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(72, 21);
            this.txtTotal.TabIndex = 105;
            this.txtTotal.Text = "0";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(15, 208);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(73, 37);
            this.btnBuscarCliente.TabIndex = 12;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(715, 685);
            this.ControlBox = false;
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.boxControles);
            this.Controls.Add(this.boxInfProducto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lvDetalleCompra);
            this.Controls.Add(this.boxInfcliente);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Productos";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.boxInfcliente.ResumeLayout(false);
            this.boxInfcliente.PerformLayout();
            this.boxInfProducto.ResumeLayout(false);
            this.boxInfProducto.PerformLayout();
            this.boxControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox boxInfcliente;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ListView lvDetalleCompra;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader descripcion;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.GroupBox boxInfProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox boxControles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarCompra;
        private System.Windows.Forms.Button btnModificarCompra;
        private System.Windows.Forms.Button btnAgregaCompra;
        private System.Windows.Forms.TextBox txtTotal;
       // private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}

