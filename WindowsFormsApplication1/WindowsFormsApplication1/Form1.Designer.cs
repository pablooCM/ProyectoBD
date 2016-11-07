namespace WindowsFormsApplication1
{
    partial class formSistemaVentas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCxC = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnActualizarDatosCliente = new System.Windows.Forms.Button();
            this.btnGenerarReporteCliente = new System.Windows.Forms.Button();
            this.btnCrearNuevoCliente = new System.Windows.Forms.Button();
            this.txtNombreClienteClientes = new System.Windows.Forms.TextBox();
            this.txtPaisClientes = new System.Windows.Forms.TextBox();
            this.txtDireccionFisicaClientes = new System.Windows.Forms.TextBox();
            this.txtCodigoPostalClientes = new System.Windows.Forms.TextBox();
            this.txtTelefono1Clientes = new System.Windows.Forms.TextBox();
            this.txtTelefono2Clientes = new System.Windows.Forms.TextBox();
            this.txtLimiteCreditoClientes = new System.Windows.Forms.TextBox();
            this.txtDireccionEntregaClientes = new System.Windows.Forms.TextBox();
            this.txtEmailClientes = new System.Windows.Forms.TextBox();
            this.txtCondicionesPagoClientes = new System.Windows.Forms.TextBox();
            this.dateFechaInicioRelacionesClientes = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoClienteClientes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCatalogoProductos = new System.Windows.Forms.TabPage();
            this.btnGenerarReporteProducto = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCrearNuevoProducto = new System.Windows.Forms.Button();
            this.txtDescripcionProductoCatalogo = new System.Windows.Forms.TextBox();
            this.txtCostoUnitarioCatalogo = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaUnitarioCatalogo = new System.Windows.Forms.TextBox();
            this.txtExistenciasProductoCatalogo = new System.Windows.Forms.TextBox();
            this.txtSKUCatalogo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.btnRevisarPedidoPedidos = new System.Windows.Forms.Button();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.btnRegistrarPedidoPedidos = new System.Windows.Forms.Button();
            this.btnEliminarProductoPedidos = new System.Windows.Forms.Button();
            this.btnAgregarProductoPedidos = new System.Windows.Forms.Button();
            this.txtCantidadProductoPedidos = new System.Windows.Forms.TextBox();
            this.txtSKUPedidos = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridViewDetallePedidoPedidos = new System.Windows.Forms.DataGridView();
            this.txtCondicionPagoPedidos = new System.Windows.Forms.TextBox();
            this.txtCodigoEjecutivoVentasPedidos = new System.Windows.Forms.TextBox();
            this.txtNombreClientePedidos = new System.Windows.Forms.TextBox();
            this.dateFechaEstimadaEntregaPedidos = new System.Windows.Forms.DateTimePicker();
            this.dateFechaPedidoPedidos = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabFacturacion = new System.Windows.Forms.TabPage();
            this.btnFacturarAlgunasUnidadesFacturacion = new System.Windows.Forms.Button();
            this.btnFacturarTodosPedidosFacturacion = new System.Windows.Forms.Button();
            this.txtCodigoClienteFacturacion = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRealizarPago = new System.Windows.Forms.Button();
            this.btnMontoCancelarCxC = new System.Windows.Forms.TextBox();
            this.txtNumeroFacturaCxC = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnNumeroFacturaCxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaFacturaCxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCondicionPagoCxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaVencimientoCxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumeroClienteCxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalFacturaCxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalImpuestoCxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalPagarCxC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarCxC = new System.Windows.Forms.Button();
            this.txtNumeroClienteCxC = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.columnSKUPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcionPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidadPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescuentoPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnImpuestoPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubtotalPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabCxC.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabCatalogoProductos.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePedidoPedidos)).BeginInit();
            this.tabFacturacion.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // tabCxC
            // 
            this.tabCxC.Controls.Add(this.tabClientes);
            this.tabCxC.Controls.Add(this.tabCatalogoProductos);
            this.tabCxC.Controls.Add(this.tabPedidos);
            this.tabCxC.Controls.Add(this.tabFacturacion);
            this.tabCxC.Controls.Add(this.tabPage4);
            this.tabCxC.Location = new System.Drawing.Point(1, 28);
            this.tabCxC.Name = "tabCxC";
            this.tabCxC.SelectedIndex = 0;
            this.tabCxC.Size = new System.Drawing.Size(825, 611);
            this.tabCxC.TabIndex = 1;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.btnEliminarCliente);
            this.tabClientes.Controls.Add(this.btnActualizarDatosCliente);
            this.tabClientes.Controls.Add(this.btnGenerarReporteCliente);
            this.tabClientes.Controls.Add(this.btnCrearNuevoCliente);
            this.tabClientes.Controls.Add(this.txtNombreClienteClientes);
            this.tabClientes.Controls.Add(this.txtPaisClientes);
            this.tabClientes.Controls.Add(this.txtDireccionFisicaClientes);
            this.tabClientes.Controls.Add(this.txtCodigoPostalClientes);
            this.tabClientes.Controls.Add(this.txtTelefono1Clientes);
            this.tabClientes.Controls.Add(this.txtTelefono2Clientes);
            this.tabClientes.Controls.Add(this.txtLimiteCreditoClientes);
            this.tabClientes.Controls.Add(this.txtDireccionEntregaClientes);
            this.tabClientes.Controls.Add(this.txtEmailClientes);
            this.tabClientes.Controls.Add(this.txtCondicionesPagoClientes);
            this.tabClientes.Controls.Add(this.dateFechaInicioRelacionesClientes);
            this.tabClientes.Controls.Add(this.txtCodigoClienteClientes);
            this.tabClientes.Controls.Add(this.label12);
            this.tabClientes.Controls.Add(this.label11);
            this.tabClientes.Controls.Add(this.label10);
            this.tabClientes.Controls.Add(this.label9);
            this.tabClientes.Controls.Add(this.label8);
            this.tabClientes.Controls.Add(this.label7);
            this.tabClientes.Controls.Add(this.label6);
            this.tabClientes.Controls.Add(this.label5);
            this.tabClientes.Controls.Add(this.label4);
            this.tabClientes.Controls.Add(this.label3);
            this.tabClientes.Controls.Add(this.label2);
            this.tabClientes.Controls.Add(this.label1);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(817, 585);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(592, 215);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(140, 23);
            this.btnEliminarCliente.TabIndex = 29;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnActualizarDatosCliente
            // 
            this.btnActualizarDatosCliente.Location = new System.Drawing.Point(592, 168);
            this.btnActualizarDatosCliente.Name = "btnActualizarDatosCliente";
            this.btnActualizarDatosCliente.Size = new System.Drawing.Size(140, 23);
            this.btnActualizarDatosCliente.TabIndex = 28;
            this.btnActualizarDatosCliente.Text = "Actualizar Datos Cliente";
            this.btnActualizarDatosCliente.UseVisualStyleBackColor = true;
            this.btnActualizarDatosCliente.Click += new System.EventHandler(this.btnActualizarDatosCliente_Click);
            // 
            // btnGenerarReporteCliente
            // 
            this.btnGenerarReporteCliente.Location = new System.Drawing.Point(592, 121);
            this.btnGenerarReporteCliente.Name = "btnGenerarReporteCliente";
            this.btnGenerarReporteCliente.Size = new System.Drawing.Size(140, 23);
            this.btnGenerarReporteCliente.TabIndex = 27;
            this.btnGenerarReporteCliente.Text = "Generar Reporte Cliente";
            this.btnGenerarReporteCliente.UseVisualStyleBackColor = true;
            // 
            // btnCrearNuevoCliente
            // 
            this.btnCrearNuevoCliente.Location = new System.Drawing.Point(592, 75);
            this.btnCrearNuevoCliente.Name = "btnCrearNuevoCliente";
            this.btnCrearNuevoCliente.Size = new System.Drawing.Size(140, 23);
            this.btnCrearNuevoCliente.TabIndex = 26;
            this.btnCrearNuevoCliente.Text = "Crear Nuevo Cliente";
            this.btnCrearNuevoCliente.UseVisualStyleBackColor = true;
            this.btnCrearNuevoCliente.Click += new System.EventHandler(this.btnCrearNuevoCliente_Click);
            // 
            // txtNombreClienteClientes
            // 
            this.txtNombreClienteClientes.Location = new System.Drawing.Point(192, 51);
            this.txtNombreClienteClientes.Name = "txtNombreClienteClientes";
            this.txtNombreClienteClientes.Size = new System.Drawing.Size(200, 20);
            this.txtNombreClienteClientes.TabIndex = 25;
            // 
            // txtPaisClientes
            // 
            this.txtPaisClientes.Location = new System.Drawing.Point(192, 75);
            this.txtPaisClientes.Name = "txtPaisClientes";
            this.txtPaisClientes.Size = new System.Drawing.Size(200, 20);
            this.txtPaisClientes.TabIndex = 24;
            // 
            // txtDireccionFisicaClientes
            // 
            this.txtDireccionFisicaClientes.Location = new System.Drawing.Point(192, 98);
            this.txtDireccionFisicaClientes.Name = "txtDireccionFisicaClientes";
            this.txtDireccionFisicaClientes.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionFisicaClientes.TabIndex = 23;
            // 
            // txtCodigoPostalClientes
            // 
            this.txtCodigoPostalClientes.Location = new System.Drawing.Point(192, 124);
            this.txtCodigoPostalClientes.Name = "txtCodigoPostalClientes";
            this.txtCodigoPostalClientes.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoPostalClientes.TabIndex = 22;
            // 
            // txtTelefono1Clientes
            // 
            this.txtTelefono1Clientes.Location = new System.Drawing.Point(192, 148);
            this.txtTelefono1Clientes.Name = "txtTelefono1Clientes";
            this.txtTelefono1Clientes.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono1Clientes.TabIndex = 21;
            // 
            // txtTelefono2Clientes
            // 
            this.txtTelefono2Clientes.Location = new System.Drawing.Point(192, 175);
            this.txtTelefono2Clientes.Name = "txtTelefono2Clientes";
            this.txtTelefono2Clientes.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono2Clientes.TabIndex = 20;
            // 
            // txtLimiteCreditoClientes
            // 
            this.txtLimiteCreditoClientes.Location = new System.Drawing.Point(192, 198);
            this.txtLimiteCreditoClientes.Name = "txtLimiteCreditoClientes";
            this.txtLimiteCreditoClientes.Size = new System.Drawing.Size(200, 20);
            this.txtLimiteCreditoClientes.TabIndex = 19;
            // 
            // txtDireccionEntregaClientes
            // 
            this.txtDireccionEntregaClientes.Location = new System.Drawing.Point(192, 221);
            this.txtDireccionEntregaClientes.Name = "txtDireccionEntregaClientes";
            this.txtDireccionEntregaClientes.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionEntregaClientes.TabIndex = 18;
            // 
            // txtEmailClientes
            // 
            this.txtEmailClientes.Location = new System.Drawing.Point(192, 246);
            this.txtEmailClientes.Name = "txtEmailClientes";
            this.txtEmailClientes.Size = new System.Drawing.Size(200, 20);
            this.txtEmailClientes.TabIndex = 17;
            // 
            // txtCondicionesPagoClientes
            // 
            this.txtCondicionesPagoClientes.Location = new System.Drawing.Point(192, 293);
            this.txtCondicionesPagoClientes.Name = "txtCondicionesPagoClientes";
            this.txtCondicionesPagoClientes.Size = new System.Drawing.Size(200, 20);
            this.txtCondicionesPagoClientes.TabIndex = 16;
            // 
            // dateFechaInicioRelacionesClientes
            // 
            this.dateFechaInicioRelacionesClientes.Location = new System.Drawing.Point(192, 268);
            this.dateFechaInicioRelacionesClientes.Name = "dateFechaInicioRelacionesClientes";
            this.dateFechaInicioRelacionesClientes.Size = new System.Drawing.Size(200, 20);
            this.dateFechaInicioRelacionesClientes.TabIndex = 13;
            // 
            // txtCodigoClienteClientes
            // 
            this.txtCodigoClienteClientes.Location = new System.Drawing.Point(192, 28);
            this.txtCodigoClienteClientes.Name = "txtCodigoClienteClientes";
            this.txtCodigoClienteClientes.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoClienteClientes.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Condiciones de Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fecha de Inicio de Relaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Direccion de Entrega";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Limite de Credito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefono 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion Fisica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cliente";
            // 
            // tabCatalogoProductos
            // 
            this.tabCatalogoProductos.Controls.Add(this.btnGenerarReporteProducto);
            this.tabCatalogoProductos.Controls.Add(this.btnActualizarProducto);
            this.tabCatalogoProductos.Controls.Add(this.btnEliminarProducto);
            this.tabCatalogoProductos.Controls.Add(this.btnCrearNuevoProducto);
            this.tabCatalogoProductos.Controls.Add(this.txtDescripcionProductoCatalogo);
            this.tabCatalogoProductos.Controls.Add(this.txtCostoUnitarioCatalogo);
            this.tabCatalogoProductos.Controls.Add(this.txtPrecioVentaUnitarioCatalogo);
            this.tabCatalogoProductos.Controls.Add(this.txtExistenciasProductoCatalogo);
            this.tabCatalogoProductos.Controls.Add(this.txtSKUCatalogo);
            this.tabCatalogoProductos.Controls.Add(this.label17);
            this.tabCatalogoProductos.Controls.Add(this.label16);
            this.tabCatalogoProductos.Controls.Add(this.label15);
            this.tabCatalogoProductos.Controls.Add(this.label14);
            this.tabCatalogoProductos.Controls.Add(this.label13);
            this.tabCatalogoProductos.Location = new System.Drawing.Point(4, 22);
            this.tabCatalogoProductos.Name = "tabCatalogoProductos";
            this.tabCatalogoProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCatalogoProductos.Size = new System.Drawing.Size(817, 585);
            this.tabCatalogoProductos.TabIndex = 1;
            this.tabCatalogoProductos.Text = "Catalogo de Productos";
            this.tabCatalogoProductos.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporteProducto
            // 
            this.btnGenerarReporteProducto.Location = new System.Drawing.Point(517, 125);
            this.btnGenerarReporteProducto.Name = "btnGenerarReporteProducto";
            this.btnGenerarReporteProducto.Size = new System.Drawing.Size(138, 23);
            this.btnGenerarReporteProducto.TabIndex = 13;
            this.btnGenerarReporteProducto.Text = "Generar Reporte";
            this.btnGenerarReporteProducto.UseVisualStyleBackColor = true;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(517, 169);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(138, 23);
            this.btnActualizarProducto.TabIndex = 12;
            this.btnActualizarProducto.Text = "Actualizar Producto";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(517, 216);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(138, 23);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnCrearNuevoProducto
            // 
            this.btnCrearNuevoProducto.Location = new System.Drawing.Point(517, 85);
            this.btnCrearNuevoProducto.Name = "btnCrearNuevoProducto";
            this.btnCrearNuevoProducto.Size = new System.Drawing.Size(138, 23);
            this.btnCrearNuevoProducto.TabIndex = 10;
            this.btnCrearNuevoProducto.Text = "Crear Nuevo Producto";
            this.btnCrearNuevoProducto.UseVisualStyleBackColor = true;
            this.btnCrearNuevoProducto.Click += new System.EventHandler(this.btnCrearNuevoProducto_Click);
            // 
            // txtDescripcionProductoCatalogo
            // 
            this.txtDescripcionProductoCatalogo.Location = new System.Drawing.Point(184, 99);
            this.txtDescripcionProductoCatalogo.Name = "txtDescripcionProductoCatalogo";
            this.txtDescripcionProductoCatalogo.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionProductoCatalogo.TabIndex = 9;
            // 
            // txtCostoUnitarioCatalogo
            // 
            this.txtCostoUnitarioCatalogo.Location = new System.Drawing.Point(184, 137);
            this.txtCostoUnitarioCatalogo.Name = "txtCostoUnitarioCatalogo";
            this.txtCostoUnitarioCatalogo.Size = new System.Drawing.Size(100, 20);
            this.txtCostoUnitarioCatalogo.TabIndex = 8;
            // 
            // txtPrecioVentaUnitarioCatalogo
            // 
            this.txtPrecioVentaUnitarioCatalogo.Location = new System.Drawing.Point(184, 177);
            this.txtPrecioVentaUnitarioCatalogo.Name = "txtPrecioVentaUnitarioCatalogo";
            this.txtPrecioVentaUnitarioCatalogo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaUnitarioCatalogo.TabIndex = 7;
            // 
            // txtExistenciasProductoCatalogo
            // 
            this.txtExistenciasProductoCatalogo.Location = new System.Drawing.Point(184, 219);
            this.txtExistenciasProductoCatalogo.Name = "txtExistenciasProductoCatalogo";
            this.txtExistenciasProductoCatalogo.Size = new System.Drawing.Size(100, 20);
            this.txtExistenciasProductoCatalogo.TabIndex = 6;
            // 
            // txtSKUCatalogo
            // 
            this.txtSKUCatalogo.Location = new System.Drawing.Point(184, 52);
            this.txtSKUCatalogo.Name = "txtSKUCatalogo";
            this.txtSKUCatalogo.Size = new System.Drawing.Size(100, 20);
            this.txtSKUCatalogo.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Existencias del Producto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Precio de Venta Unitario";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Costo Unitario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Descripcion del Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "SKU";
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.btnRevisarPedidoPedidos);
            this.tabPedidos.Controls.Add(this.btnConfirmarPedido);
            this.tabPedidos.Controls.Add(this.btnRegistrarPedidoPedidos);
            this.tabPedidos.Controls.Add(this.btnEliminarProductoPedidos);
            this.tabPedidos.Controls.Add(this.btnAgregarProductoPedidos);
            this.tabPedidos.Controls.Add(this.txtCantidadProductoPedidos);
            this.tabPedidos.Controls.Add(this.txtSKUPedidos);
            this.tabPedidos.Controls.Add(this.label26);
            this.tabPedidos.Controls.Add(this.label25);
            this.tabPedidos.Controls.Add(this.lblPrecioTotal);
            this.tabPedidos.Controls.Add(this.label24);
            this.tabPedidos.Controls.Add(this.dataGridViewDetallePedidoPedidos);
            this.tabPedidos.Controls.Add(this.txtCondicionPagoPedidos);
            this.tabPedidos.Controls.Add(this.txtCodigoEjecutivoVentasPedidos);
            this.tabPedidos.Controls.Add(this.txtNombreClientePedidos);
            this.tabPedidos.Controls.Add(this.dateFechaEstimadaEntregaPedidos);
            this.tabPedidos.Controls.Add(this.dateFechaPedidoPedidos);
            this.tabPedidos.Controls.Add(this.label23);
            this.tabPedidos.Controls.Add(this.label22);
            this.tabPedidos.Controls.Add(this.label21);
            this.tabPedidos.Controls.Add(this.label20);
            this.tabPedidos.Controls.Add(this.label19);
            this.tabPedidos.Controls.Add(this.label18);
            this.tabPedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(817, 585);
            this.tabPedidos.TabIndex = 2;
            this.tabPedidos.Text = "Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // btnRevisarPedidoPedidos
            // 
            this.btnRevisarPedidoPedidos.Location = new System.Drawing.Point(538, 537);
            this.btnRevisarPedidoPedidos.Name = "btnRevisarPedidoPedidos";
            this.btnRevisarPedidoPedidos.Size = new System.Drawing.Size(104, 23);
            this.btnRevisarPedidoPedidos.TabIndex = 22;
            this.btnRevisarPedidoPedidos.Text = "Revisar Pedido";
            this.btnRevisarPedidoPedidos.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Location = new System.Drawing.Point(675, 537);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(104, 23);
            this.btnConfirmarPedido.TabIndex = 21;
            this.btnConfirmarPedido.Text = "Confirmar Pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPedidoPedidos
            // 
            this.btnRegistrarPedidoPedidos.Location = new System.Drawing.Point(399, 537);
            this.btnRegistrarPedidoPedidos.Name = "btnRegistrarPedidoPedidos";
            this.btnRegistrarPedidoPedidos.Size = new System.Drawing.Size(104, 23);
            this.btnRegistrarPedidoPedidos.TabIndex = 20;
            this.btnRegistrarPedidoPedidos.Text = "Registrar Pedido";
            this.btnRegistrarPedidoPedidos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProductoPedidos
            // 
            this.btnEliminarProductoPedidos.Location = new System.Drawing.Point(644, 150);
            this.btnEliminarProductoPedidos.Name = "btnEliminarProductoPedidos";
            this.btnEliminarProductoPedidos.Size = new System.Drawing.Size(101, 23);
            this.btnEliminarProductoPedidos.TabIndex = 19;
            this.btnEliminarProductoPedidos.Text = "Eliminar Producto";
            this.btnEliminarProductoPedidos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProductoPedidos
            // 
            this.btnAgregarProductoPedidos.Location = new System.Drawing.Point(516, 150);
            this.btnAgregarProductoPedidos.Name = "btnAgregarProductoPedidos";
            this.btnAgregarProductoPedidos.Size = new System.Drawing.Size(101, 23);
            this.btnAgregarProductoPedidos.TabIndex = 18;
            this.btnAgregarProductoPedidos.Text = "Agregar Producto";
            this.btnAgregarProductoPedidos.UseVisualStyleBackColor = true;
            this.btnAgregarProductoPedidos.Click += new System.EventHandler(this.btnAgregarProductoPedidos_Click);
            // 
            // txtCantidadProductoPedidos
            // 
            this.txtCantidadProductoPedidos.Location = new System.Drawing.Point(645, 93);
            this.txtCantidadProductoPedidos.Name = "txtCantidadProductoPedidos";
            this.txtCantidadProductoPedidos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadProductoPedidos.TabIndex = 17;
            // 
            // txtSKUPedidos
            // 
            this.txtSKUPedidos.Location = new System.Drawing.Point(645, 50);
            this.txtSKUPedidos.Name = "txtSKUPedidos";
            this.txtSKUPedidos.Size = new System.Drawing.Size(100, 20);
            this.txtSKUPedidos.TabIndex = 16;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(513, 101);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Cantidad de Producto:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(513, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "SKU:";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(119, 467);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(0, 25);
            this.lblPrecioTotal.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 479);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "Precio Total:";
            // 
            // dataGridViewDetallePedidoPedidos
            // 
            this.dataGridViewDetallePedidoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallePedidoPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSKUPedidos,
            this.columnDescripcionPedidos,
            this.columnCantidadPedidos,
            this.columnPrecioPedidos,
            this.columnDescuentoPedidos,
            this.columnImpuestoPedidos,
            this.columnSubtotalPedidos});
            this.dataGridViewDetallePedidoPedidos.Location = new System.Drawing.Point(14, 194);
            this.dataGridViewDetallePedidoPedidos.Name = "dataGridViewDetallePedidoPedidos";
            this.dataGridViewDetallePedidoPedidos.Size = new System.Drawing.Size(746, 242);
            this.dataGridViewDetallePedidoPedidos.TabIndex = 11;
            // 
            // txtCondicionPagoPedidos
            // 
            this.txtCondicionPagoPedidos.Location = new System.Drawing.Point(175, 70);
            this.txtCondicionPagoPedidos.Name = "txtCondicionPagoPedidos";
            this.txtCondicionPagoPedidos.Size = new System.Drawing.Size(200, 20);
            this.txtCondicionPagoPedidos.TabIndex = 10;
            // 
            // txtCodigoEjecutivoVentasPedidos
            // 
            this.txtCodigoEjecutivoVentasPedidos.Location = new System.Drawing.Point(175, 101);
            this.txtCodigoEjecutivoVentasPedidos.Name = "txtCodigoEjecutivoVentasPedidos";
            this.txtCodigoEjecutivoVentasPedidos.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoEjecutivoVentasPedidos.TabIndex = 9;
            // 
            // txtNombreClientePedidos
            // 
            this.txtNombreClientePedidos.Location = new System.Drawing.Point(175, 38);
            this.txtNombreClientePedidos.Name = "txtNombreClientePedidos";
            this.txtNombreClientePedidos.Size = new System.Drawing.Size(200, 20);
            this.txtNombreClientePedidos.TabIndex = 8;
            // 
            // dateFechaEstimadaEntregaPedidos
            // 
            this.dateFechaEstimadaEntregaPedidos.Location = new System.Drawing.Point(175, 132);
            this.dateFechaEstimadaEntregaPedidos.Name = "dateFechaEstimadaEntregaPedidos";
            this.dateFechaEstimadaEntregaPedidos.Size = new System.Drawing.Size(200, 20);
            this.dateFechaEstimadaEntregaPedidos.TabIndex = 7;
            // 
            // dateFechaPedidoPedidos
            // 
            this.dateFechaPedidoPedidos.Location = new System.Drawing.Point(175, 8);
            this.dateFechaPedidoPedidos.Name = "dateFechaPedidoPedidos";
            this.dateFechaPedidoPedidos.Size = new System.Drawing.Size(200, 20);
            this.dateFechaPedidoPedidos.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 171);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Detalle de Pedido:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Fecha Estimada de Entrega:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Codigo Ejecutivo de Ventas:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Condicion de Pago:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Nombre del Cliente:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Fecha Pedido:";
            // 
            // tabFacturacion
            // 
            this.tabFacturacion.Controls.Add(this.btnFacturarAlgunasUnidadesFacturacion);
            this.tabFacturacion.Controls.Add(this.btnFacturarTodosPedidosFacturacion);
            this.tabFacturacion.Controls.Add(this.txtCodigoClienteFacturacion);
            this.tabFacturacion.Controls.Add(this.label27);
            this.tabFacturacion.Location = new System.Drawing.Point(4, 22);
            this.tabFacturacion.Name = "tabFacturacion";
            this.tabFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacturacion.Size = new System.Drawing.Size(817, 585);
            this.tabFacturacion.TabIndex = 3;
            this.tabFacturacion.Text = "Facturacion";
            this.tabFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnFacturarAlgunasUnidadesFacturacion
            // 
            this.btnFacturarAlgunasUnidadesFacturacion.Location = new System.Drawing.Point(366, 178);
            this.btnFacturarAlgunasUnidadesFacturacion.Name = "btnFacturarAlgunasUnidadesFacturacion";
            this.btnFacturarAlgunasUnidadesFacturacion.Size = new System.Drawing.Size(168, 23);
            this.btnFacturarAlgunasUnidadesFacturacion.TabIndex = 3;
            this.btnFacturarAlgunasUnidadesFacturacion.Text = "Facturar Algunas Unidades";
            this.btnFacturarAlgunasUnidadesFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnFacturarTodosPedidosFacturacion
            // 
            this.btnFacturarTodosPedidosFacturacion.Location = new System.Drawing.Point(157, 178);
            this.btnFacturarTodosPedidosFacturacion.Name = "btnFacturarTodosPedidosFacturacion";
            this.btnFacturarTodosPedidosFacturacion.Size = new System.Drawing.Size(168, 23);
            this.btnFacturarTodosPedidosFacturacion.TabIndex = 2;
            this.btnFacturarTodosPedidosFacturacion.Text = "Facturar Todos los Productos";
            this.btnFacturarTodosPedidosFacturacion.UseVisualStyleBackColor = true;
            // 
            // txtCodigoClienteFacturacion
            // 
            this.txtCodigoClienteFacturacion.Location = new System.Drawing.Point(289, 86);
            this.txtCodigoClienteFacturacion.Name = "txtCodigoClienteFacturacion";
            this.txtCodigoClienteFacturacion.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoClienteFacturacion.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(170, 93);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Codigo de Cliente:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRealizarPago);
            this.tabPage4.Controls.Add(this.btnMontoCancelarCxC);
            this.tabPage4.Controls.Add(this.txtNumeroFacturaCxC);
            this.tabPage4.Controls.Add(this.label30);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.btnConsultarCxC);
            this.tabPage4.Controls.Add(this.txtNumeroClienteCxC);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(817, 585);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Cuentas por Cobrar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRealizarPago
            // 
            this.btnRealizarPago.Location = new System.Drawing.Point(158, 435);
            this.btnRealizarPago.Name = "btnRealizarPago";
            this.btnRealizarPago.Size = new System.Drawing.Size(136, 23);
            this.btnRealizarPago.TabIndex = 8;
            this.btnRealizarPago.Text = "Realizar Pago";
            this.btnRealizarPago.UseVisualStyleBackColor = true;
            // 
            // btnMontoCancelarCxC
            // 
            this.btnMontoCancelarCxC.Location = new System.Drawing.Point(194, 386);
            this.btnMontoCancelarCxC.Name = "btnMontoCancelarCxC";
            this.btnMontoCancelarCxC.Size = new System.Drawing.Size(100, 20);
            this.btnMontoCancelarCxC.TabIndex = 7;
            // 
            // txtNumeroFacturaCxC
            // 
            this.txtNumeroFacturaCxC.Location = new System.Drawing.Point(194, 342);
            this.txtNumeroFacturaCxC.Name = "txtNumeroFacturaCxC";
            this.txtNumeroFacturaCxC.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroFacturaCxC.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(53, 389);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(94, 13);
            this.label30.TabIndex = 5;
            this.label30.Text = "Monto a Cancelar:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(53, 349);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Numero de Factura:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumeroFacturaCxC,
            this.columnFechaFacturaCxC,
            this.columnCondicionPagoCxC,
            this.columnFechaVencimientoCxC,
            this.columnNumeroClienteCxC,
            this.columnTotalFacturaCxC,
            this.columnTotalImpuestoCxC,
            this.columnTotalPagarCxC});
            this.dataGridView1.Location = new System.Drawing.Point(-5, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // columnNumeroFacturaCxC
            // 
            this.columnNumeroFacturaCxC.HeaderText = "Numero de Factura";
            this.columnNumeroFacturaCxC.Name = "columnNumeroFacturaCxC";
            // 
            // columnFechaFacturaCxC
            // 
            this.columnFechaFacturaCxC.HeaderText = "Fecha de Factura";
            this.columnFechaFacturaCxC.Name = "columnFechaFacturaCxC";
            // 
            // columnCondicionPagoCxC
            // 
            this.columnCondicionPagoCxC.HeaderText = "Condicion de Pago";
            this.columnCondicionPagoCxC.Name = "columnCondicionPagoCxC";
            // 
            // columnFechaVencimientoCxC
            // 
            this.columnFechaVencimientoCxC.HeaderText = "Fecha de Vencimiento";
            this.columnFechaVencimientoCxC.Name = "columnFechaVencimientoCxC";
            // 
            // columnNumeroClienteCxC
            // 
            this.columnNumeroClienteCxC.HeaderText = "Numero de Cliente";
            this.columnNumeroClienteCxC.Name = "columnNumeroClienteCxC";
            // 
            // columnTotalFacturaCxC
            // 
            this.columnTotalFacturaCxC.HeaderText = "Total Factura";
            this.columnTotalFacturaCxC.Name = "columnTotalFacturaCxC";
            // 
            // columnTotalImpuestoCxC
            // 
            this.columnTotalImpuestoCxC.HeaderText = "Total Impuesto";
            this.columnTotalImpuestoCxC.Name = "columnTotalImpuestoCxC";
            // 
            // columnTotalPagarCxC
            // 
            this.columnTotalPagarCxC.HeaderText = "Total por Pagar";
            this.columnTotalPagarCxC.Name = "columnTotalPagarCxC";
            // 
            // btnConsultarCxC
            // 
            this.btnConsultarCxC.Location = new System.Drawing.Point(194, 80);
            this.btnConsultarCxC.Name = "btnConsultarCxC";
            this.btnConsultarCxC.Size = new System.Drawing.Size(198, 23);
            this.btnConsultarCxC.TabIndex = 2;
            this.btnConsultarCxC.Text = "Consultar Cuentas por Cobrar";
            this.btnConsultarCxC.UseVisualStyleBackColor = true;
            // 
            // txtNumeroClienteCxC
            // 
            this.txtNumeroClienteCxC.Location = new System.Drawing.Point(259, 28);
            this.txtNumeroClienteCxC.Name = "txtNumeroClienteCxC";
            this.txtNumeroClienteCxC.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroClienteCxC.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(149, 36);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Numero Cliente:";
            // 
            // columnSKUPedidos
            // 
            this.columnSKUPedidos.HeaderText = "SKU";
            this.columnSKUPedidos.Name = "columnSKUPedidos";
            // 
            // columnDescripcionPedidos
            // 
            this.columnDescripcionPedidos.HeaderText = "Descripcion";
            this.columnDescripcionPedidos.Name = "columnDescripcionPedidos";
            // 
            // columnCantidadPedidos
            // 
            this.columnCantidadPedidos.HeaderText = "Cantidad";
            this.columnCantidadPedidos.Name = "columnCantidadPedidos";
            // 
            // columnPrecioPedidos
            // 
            this.columnPrecioPedidos.HeaderText = "Precio";
            this.columnPrecioPedidos.Name = "columnPrecioPedidos";
            // 
            // columnDescuentoPedidos
            // 
            this.columnDescuentoPedidos.HeaderText = "Descuento";
            this.columnDescuentoPedidos.Name = "columnDescuentoPedidos";
            // 
            // columnImpuestoPedidos
            // 
            this.columnImpuestoPedidos.HeaderText = "Impuesto";
            this.columnImpuestoPedidos.Name = "columnImpuestoPedidos";
            // 
            // columnSubtotalPedidos
            // 
            this.columnSubtotalPedidos.HeaderText = "Subtotal";
            this.columnSubtotalPedidos.Name = "columnSubtotalPedidos";
            // 
            // formSistemaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 641);
            this.Controls.Add(this.tabCxC);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formSistemaVentas";
            this.Text = "Sistema de Ventas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCxC.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.tabCatalogoProductos.ResumeLayout(false);
            this.tabCatalogoProductos.PerformLayout();
            this.tabPedidos.ResumeLayout(false);
            this.tabPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePedidoPedidos)).EndInit();
            this.tabFacturacion.ResumeLayout(false);
            this.tabFacturacion.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCxC;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabCatalogoProductos;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TextBox txtNombreClienteClientes;
        private System.Windows.Forms.TextBox txtPaisClientes;
        private System.Windows.Forms.TextBox txtDireccionFisicaClientes;
        private System.Windows.Forms.TextBox txtCodigoPostalClientes;
        private System.Windows.Forms.TextBox txtTelefono1Clientes;
        private System.Windows.Forms.TextBox txtTelefono2Clientes;
        private System.Windows.Forms.TextBox txtLimiteCreditoClientes;
        private System.Windows.Forms.TextBox txtDireccionEntregaClientes;
        private System.Windows.Forms.TextBox txtEmailClientes;
        private System.Windows.Forms.TextBox txtCondicionesPagoClientes;
        private System.Windows.Forms.DateTimePicker dateFechaInicioRelacionesClientes;
        private System.Windows.Forms.TextBox txtCodigoClienteClientes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabFacturacion;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnActualizarDatosCliente;
        private System.Windows.Forms.Button btnGenerarReporteCliente;
        private System.Windows.Forms.Button btnCrearNuevoCliente;
        private System.Windows.Forms.TextBox txtDescripcionProductoCatalogo;
        private System.Windows.Forms.TextBox txtCostoUnitarioCatalogo;
        private System.Windows.Forms.TextBox txtPrecioVentaUnitarioCatalogo;
        private System.Windows.Forms.TextBox txtExistenciasProductoCatalogo;
        private System.Windows.Forms.TextBox txtSKUCatalogo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGenerarReporteProducto;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnCrearNuevoProducto;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dataGridViewDetallePedidoPedidos;
        private System.Windows.Forms.TextBox txtCondicionPagoPedidos;
        private System.Windows.Forms.TextBox txtCodigoEjecutivoVentasPedidos;
        private System.Windows.Forms.TextBox txtNombreClientePedidos;
        private System.Windows.Forms.DateTimePicker dateFechaEstimadaEntregaPedidos;
        private System.Windows.Forms.DateTimePicker dateFechaPedidoPedidos;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRevisarPedidoPedidos;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.Button btnRegistrarPedidoPedidos;
        private System.Windows.Forms.Button btnEliminarProductoPedidos;
        private System.Windows.Forms.Button btnAgregarProductoPedidos;
        private System.Windows.Forms.TextBox txtCantidadProductoPedidos;
        private System.Windows.Forms.TextBox txtSKUPedidos;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnFacturarAlgunasUnidadesFacturacion;
        private System.Windows.Forms.Button btnFacturarTodosPedidosFacturacion;
        private System.Windows.Forms.TextBox txtCodigoClienteFacturacion;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumeroFacturaCxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaFacturaCxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCondicionPagoCxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaVencimientoCxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumeroClienteCxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalFacturaCxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalImpuestoCxC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalPagarCxC;
        private System.Windows.Forms.Button btnConsultarCxC;
        private System.Windows.Forms.TextBox txtNumeroClienteCxC;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnRealizarPago;
        private System.Windows.Forms.TextBox btnMontoCancelarCxC;
        private System.Windows.Forms.TextBox txtNumeroFacturaCxC;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSKUPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcionPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidadPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescuentoPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnImpuestoPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubtotalPedidos;
    }
}

