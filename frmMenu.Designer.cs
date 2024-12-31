namespace pryAccesoGym
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            dgvClientes = new DataGridView();
            btnAbrirPuerta = new Button();
            btnAbrirPuerta1min = new Button();
            btnSalir = new Button();
            grbClientes = new GroupBox();
            btnGestionarClientes = new Button();
            btnIngresos = new Button();
            grbClientesPago = new GroupBox();
            dtpFechaPago = new DateTimePicker();
            lblFechaPago = new Label();
            rbtEfectivo = new RadioButton();
            rbtTransferencia = new RadioButton();
            lblMontoPago = new Label();
            lblDniClienteAbono = new Label();
            txtMonto = new TextBox();
            txtDniAbono = new TextBox();
            btnCargarPago = new Button();
            txtBusqueda = new TextBox();
            grbListaClientes = new GroupBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            cmbFiltrado = new ComboBox();
            btnBuscar = new Button();
            btnCartelIngreso = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbClientes.SuspendLayout();
            grbClientesPago.SuspendLayout();
            grbListaClientes.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(9, 70);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(1280, 451);
            dgvClientes.TabIndex = 7;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellClick;
            // 
            // btnAbrirPuerta
            // 
            btnAbrirPuerta.FlatAppearance.BorderColor = Color.Red;
            btnAbrirPuerta.FlatAppearance.BorderSize = 2;
            btnAbrirPuerta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirPuerta.Location = new Point(26, 12);
            btnAbrirPuerta.Name = "btnAbrirPuerta";
            btnAbrirPuerta.Size = new Size(158, 36);
            btnAbrirPuerta.TabIndex = 0;
            btnAbrirPuerta.Text = "Abrir Puerta";
            btnAbrirPuerta.UseVisualStyleBackColor = true;
            btnAbrirPuerta.Click += btnAbrirPuerta_Click;
            // 
            // btnAbrirPuerta1min
            // 
            btnAbrirPuerta1min.FlatAppearance.BorderColor = Color.Red;
            btnAbrirPuerta1min.FlatAppearance.BorderSize = 2;
            btnAbrirPuerta1min.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirPuerta1min.Location = new Point(218, 12);
            btnAbrirPuerta1min.Name = "btnAbrirPuerta1min";
            btnAbrirPuerta1min.Size = new Size(191, 36);
            btnAbrirPuerta1min.TabIndex = 1;
            btnAbrirPuerta1min.Text = "Abrir Puerta 1min";
            btnAbrirPuerta1min.UseVisualStyleBackColor = true;
            btnAbrirPuerta1min.Click += btnAbrirPuerta1min_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gold;
            btnSalir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(1203, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 36);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // grbClientes
            // 
            grbClientes.BackColor = Color.Transparent;
            grbClientes.Controls.Add(btnGestionarClientes);
            grbClientes.Controls.Add(btnIngresos);
            grbClientes.FlatStyle = FlatStyle.Popup;
            grbClientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbClientes.Location = new Point(12, 47);
            grbClientes.Name = "grbClientes";
            grbClientes.Size = new Size(185, 134);
            grbClientes.TabIndex = 3;
            grbClientes.TabStop = false;
            grbClientes.Text = "Clientes";
            // 
            // btnGestionarClientes
            // 
            btnGestionarClientes.Location = new Point(14, 61);
            btnGestionarClientes.Name = "btnGestionarClientes";
            btnGestionarClientes.Size = new Size(158, 73);
            btnGestionarClientes.TabIndex = 4;
            btnGestionarClientes.Text = "Gestionar Clientes";
            btnGestionarClientes.UseVisualStyleBackColor = true;
            btnGestionarClientes.Click += button1_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.Location = new Point(14, 22);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(158, 33);
            btnIngresos.TabIndex = 5;
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseVisualStyleBackColor = true;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // grbClientesPago
            // 
            grbClientesPago.BackColor = SystemColors.Control;
            grbClientesPago.Controls.Add(dtpFechaPago);
            grbClientesPago.Controls.Add(lblFechaPago);
            grbClientesPago.Controls.Add(rbtEfectivo);
            grbClientesPago.Controls.Add(rbtTransferencia);
            grbClientesPago.Controls.Add(lblMontoPago);
            grbClientesPago.Controls.Add(lblDniClienteAbono);
            grbClientesPago.Controls.Add(txtMonto);
            grbClientesPago.Controls.Add(txtDniAbono);
            grbClientesPago.Controls.Add(btnCargarPago);
            grbClientesPago.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbClientesPago.Location = new Point(218, 47);
            grbClientesPago.Name = "grbClientesPago";
            grbClientesPago.Size = new Size(1088, 129);
            grbClientesPago.TabIndex = 6;
            grbClientesPago.TabStop = false;
            grbClientesPago.Text = "Pagos";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(498, 75);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(333, 31);
            dtpFechaPago.TabIndex = 21;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(498, 41);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(135, 25);
            lblFechaPago.TabIndex = 20;
            lblFechaPago.Text = "Fecha de Pago";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(301, 70);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(102, 29);
            rbtEfectivo.TabIndex = 11;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            rbtEfectivo.CheckedChanged += rbtEfectivo_CheckedChanged;
            // 
            // rbtTransferencia
            // 
            rbtTransferencia.AutoSize = true;
            rbtTransferencia.Location = new Point(301, 34);
            rbtTransferencia.Name = "rbtTransferencia";
            rbtTransferencia.Size = new Size(148, 29);
            rbtTransferencia.TabIndex = 10;
            rbtTransferencia.TabStop = true;
            rbtTransferencia.Text = "Transferencia";
            rbtTransferencia.UseVisualStyleBackColor = true;
            rbtTransferencia.CheckedChanged += rbtTransferencia_CheckedChanged;
            // 
            // lblMontoPago
            // 
            lblMontoPago.AutoSize = true;
            lblMontoPago.Location = new Point(17, 74);
            lblMontoPago.Name = "lblMontoPago";
            lblMontoPago.Size = new Size(69, 25);
            lblMontoPago.TabIndex = 9;
            lblMontoPago.Text = "Monto";
            // 
            // lblDniClienteAbono
            // 
            lblDniClienteAbono.AutoSize = true;
            lblDniClienteAbono.Location = new Point(17, 41);
            lblDniClienteAbono.Name = "lblDniClienteAbono";
            lblDniClienteAbono.Size = new Size(45, 25);
            lblDniClienteAbono.TabIndex = 8;
            lblDniClienteAbono.Text = "DNI";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(91, 75);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(204, 31);
            txtMonto.TabIndex = 7;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // txtDniAbono
            // 
            txtDniAbono.Location = new Point(91, 38);
            txtDniAbono.Name = "txtDniAbono";
            txtDniAbono.Size = new Size(204, 31);
            txtDniAbono.TabIndex = 6;
            txtDniAbono.TextChanged += txtDniAbono_TextChanged;
            // 
            // btnCargarPago
            // 
            btnCargarPago.BackColor = Color.PaleGreen;
            btnCargarPago.Location = new Point(863, 30);
            btnCargarPago.Name = "btnCargarPago";
            btnCargarPago.Size = new Size(113, 89);
            btnCargarPago.TabIndex = 5;
            btnCargarPago.Text = "Cargar Pago";
            btnCargarPago.UseVisualStyleBackColor = false;
            btnCargarPago.Click += btnCargarPago_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(177, 30);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(206, 31);
            txtBusqueda.TabIndex = 12;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(btnModificar);
            grbListaClientes.Controls.Add(btnEliminar);
            grbListaClientes.Controls.Add(cmbFiltrado);
            grbListaClientes.Controls.Add(btnBuscar);
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Controls.Add(txtBusqueda);
            grbListaClientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbListaClientes.Location = new Point(3, 182);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(1303, 527);
            grbListaClientes.TabIndex = 14;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Pagos";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Khaki;
            btnModificar.Location = new Point(1057, 23);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(113, 41);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Location = new Point(1176, 23);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 41);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbFiltrado
            // 
            cmbFiltrado.FormattingEnabled = true;
            cmbFiltrado.Location = new Point(9, 27);
            cmbFiltrado.Name = "cmbFiltrado";
            cmbFiltrado.Size = new Size(162, 33);
            cmbFiltrado.TabIndex = 14;
            cmbFiltrado.Text = "Buscar por..";
            cmbFiltrado.SelectedIndexChanged += cmbFiltrado_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(389, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 34);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCartelIngreso
            // 
            btnCartelIngreso.FlatAppearance.BorderColor = Color.Red;
            btnCartelIngreso.FlatAppearance.BorderSize = 2;
            btnCartelIngreso.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCartelIngreso.Location = new Point(696, 12);
            btnCartelIngreso.Name = "btnCartelIngreso";
            btnCartelIngreso.Size = new Size(191, 36);
            btnCartelIngreso.TabIndex = 15;
            btnCartelIngreso.Text = "Cartel Ingreso";
            btnCartelIngreso.UseVisualStyleBackColor = true;
            btnCartelIngreso.Click += btnCartelIngreso_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 721);
            Controls.Add(btnCartelIngreso);
            Controls.Add(grbListaClientes);
            Controls.Add(grbClientesPago);
            Controls.Add(grbClientes);
            Controls.Add(btnSalir);
            Controls.Add(btnAbrirPuerta1min);
            Controls.Add(btnAbrirPuerta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += frmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grbClientes.ResumeLayout(false);
            grbClientesPago.ResumeLayout(false);
            grbClientesPago.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            grbListaClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirPuerta;
        private Button btnAbrirPuerta1min;
        private Button btnSalir;
        private GroupBox grbClientes;
        private Button btnGestionarClientes;
        private Button btnIngresos;
        private GroupBox grbClientesPago;
        private Button btnCargarPago;
        private Label lblMontoPago;
        private Label lblDniClienteAbono;
        private TextBox txtMonto;
        private TextBox txtDniAbono;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTransferencia;
        private DataGridView dgvClientes;
        private TextBox txtBusqueda;
        private GroupBox grbListaClientes;
        private Button btnBuscar;
        private ComboBox cmbFiltrado;
        private Button btnEliminar;
        private Button btnModificar;
        private DateTimePicker dtpFechaPago;
        private Label lblFechaPago;
        private Button btnCartelIngreso;
    }
}