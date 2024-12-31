namespace pryAccesoGym
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            lblSexo = new Label();
            cmbSexo = new ComboBox();
            lblFechaNac = new Label();
            dtpFechaNac = new DateTimePicker();
            grbDatosPersonales = new GroupBox();
            button1 = new Button();
            gpbEstado = new GroupBox();
            rbtActivo = new RadioButton();
            rbtInactivo = new RadioButton();
            btnSalir = new Button();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtMail = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            lblFechaIngreso = new Label();
            btnCrearUsuario = new Button();
            btnModificarUsuario = new Button();
            grbListaClientes = new GroupBox();
            rbtActivoFiltro = new RadioButton();
            rbtInactivoFiltro = new RadioButton();
            dgvClientes = new DataGridView();
            btnBuscarDni = new Button();
            txtBuscarClientes = new TextBox();
            grbDatosPersonales.SuspendLayout();
            gpbEstado.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(283, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(119, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(283, 31);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(22, 86);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(119, 129);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(283, 31);
            txtDni.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(22, 132);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(45, 25);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(61, 179);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(53, 25);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(120, 176);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(67, 33);
            cmbSexo.TabIndex = 17;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(445, 83);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(130, 25);
            lblFechaNac.TabIndex = 18;
            lblFechaNac.Text = "Fecha de Nac.";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(581, 80);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(268, 31);
            dtpFechaNac.TabIndex = 19;
            // 
            // grbDatosPersonales
            // 
            grbDatosPersonales.BackColor = SystemColors.Control;
            grbDatosPersonales.Controls.Add(button1);
            grbDatosPersonales.Controls.Add(gpbEstado);
            grbDatosPersonales.Controls.Add(btnSalir);
            grbDatosPersonales.Controls.Add(lblTelefono);
            grbDatosPersonales.Controls.Add(txtTelefono);
            grbDatosPersonales.Controls.Add(lblEmail);
            grbDatosPersonales.Controls.Add(txtMail);
            grbDatosPersonales.Controls.Add(dtpFechaIngreso);
            grbDatosPersonales.Controls.Add(lblFechaIngreso);
            grbDatosPersonales.Controls.Add(lblNombre);
            grbDatosPersonales.Controls.Add(txtNombre);
            grbDatosPersonales.Controls.Add(dtpFechaNac);
            grbDatosPersonales.Controls.Add(lblApellido);
            grbDatosPersonales.Controls.Add(lblFechaNac);
            grbDatosPersonales.Controls.Add(txtApellido);
            grbDatosPersonales.Controls.Add(cmbSexo);
            grbDatosPersonales.Controls.Add(lblDni);
            grbDatosPersonales.Controls.Add(txtDni);
            grbDatosPersonales.Controls.Add(lblSexo);
            grbDatosPersonales.FlatStyle = FlatStyle.System;
            grbDatosPersonales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbDatosPersonales.Location = new Point(12, 12);
            grbDatosPersonales.Name = "grbDatosPersonales";
            grbDatosPersonales.Size = new Size(1294, 238);
            grbDatosPersonales.TabIndex = 21;
            grbDatosPersonales.TabStop = false;
            grbDatosPersonales.Text = "Datos Personales";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1183, 0);
            button1.Name = "button1";
            button1.Size = new Size(103, 35);
            button1.TabIndex = 28;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gpbEstado
            // 
            gpbEstado.Controls.Add(rbtActivo);
            gpbEstado.Controls.Add(rbtInactivo);
            gpbEstado.Location = new Point(924, 41);
            gpbEstado.Name = "gpbEstado";
            gpbEstado.Size = new Size(169, 125);
            gpbEstado.TabIndex = 27;
            gpbEstado.TabStop = false;
            gpbEstado.Text = "Estado";
            // 
            // rbtActivo
            // 
            rbtActivo.AutoSize = true;
            rbtActivo.Location = new Point(23, 38);
            rbtActivo.Name = "rbtActivo";
            rbtActivo.Size = new Size(88, 29);
            rbtActivo.TabIndex = 1;
            rbtActivo.TabStop = true;
            rbtActivo.Text = "Activo";
            rbtActivo.UseVisualStyleBackColor = true;
            // 
            // rbtInactivo
            // 
            rbtInactivo.AutoSize = true;
            rbtInactivo.Location = new Point(23, 81);
            rbtInactivo.Name = "rbtInactivo";
            rbtInactivo.Size = new Size(102, 29);
            rbtInactivo.TabIndex = 0;
            rbtInactivo.TabStop = true;
            rbtInactivo.Text = "Inactivo";
            rbtInactivo.UseVisualStyleBackColor = true;
            rbtInactivo.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gold;
            btnSalir.Location = new Point(1454, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 35);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(489, 126);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 25);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(581, 126);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(283, 31);
            txtTelefono.TabIndex = 24;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(500, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "E-mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(581, 168);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(283, 31);
            txtMail.TabIndex = 26;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(581, 38);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(268, 31);
            dtpFechaIngreso.TabIndex = 22;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(445, 41);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(130, 25);
            lblFechaIngreso.TabIndex = 21;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Anchor = AnchorStyles.None;
            btnCrearUsuario.BackColor = Color.PaleGreen;
            btnCrearUsuario.Location = new Point(1024, 22);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(115, 39);
            btnCrearUsuario.TabIndex = 23;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Anchor = AnchorStyles.None;
            btnModificarUsuario.BackColor = Color.Khaki;
            btnModificarUsuario.Location = new Point(1145, 22);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(141, 39);
            btnModificarUsuario.TabIndex = 24;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = false;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(rbtActivoFiltro);
            grbListaClientes.Controls.Add(btnModificarUsuario);
            grbListaClientes.Controls.Add(rbtInactivoFiltro);
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Controls.Add(btnBuscarDni);
            grbListaClientes.Controls.Add(btnCrearUsuario);
            grbListaClientes.Controls.Add(txtBuscarClientes);
            grbListaClientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbListaClientes.Location = new Point(12, 266);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(1294, 513);
            grbListaClientes.TabIndex = 25;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // rbtActivoFiltro
            // 
            rbtActivoFiltro.AutoSize = true;
            rbtActivoFiltro.Location = new Point(368, 31);
            rbtActivoFiltro.Name = "rbtActivoFiltro";
            rbtActivoFiltro.Size = new Size(88, 29);
            rbtActivoFiltro.TabIndex = 3;
            rbtActivoFiltro.TabStop = true;
            rbtActivoFiltro.Text = "Activo";
            rbtActivoFiltro.UseVisualStyleBackColor = true;
            // 
            // rbtInactivoFiltro
            // 
            rbtInactivoFiltro.AutoSize = true;
            rbtInactivoFiltro.Location = new Point(473, 31);
            rbtInactivoFiltro.Name = "rbtInactivoFiltro";
            rbtInactivoFiltro.Size = new Size(102, 29);
            rbtInactivoFiltro.TabIndex = 2;
            rbtInactivoFiltro.TabStop = true;
            rbtInactivoFiltro.Text = "Inactivo";
            rbtInactivoFiltro.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(9, 69);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(1279, 438);
            dgvClientes.TabIndex = 7;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellClick;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Location = new Point(219, 28);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(113, 35);
            btnBuscarDni.TabIndex = 6;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // txtBuscarClientes
            // 
            txtBuscarClientes.Location = new Point(9, 30);
            txtBuscarClientes.Name = "txtBuscarClientes";
            txtBuscarClientes.Size = new Size(204, 31);
            txtBuscarClientes.TabIndex = 12;
            txtBuscarClientes.TextChanged += txtBuscarClientes_TextChanged;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 803);
            Controls.Add(grbListaClientes);
            Controls.Add(grbDatosPersonales);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += frmClientes_Load;
            grbDatosPersonales.ResumeLayout(false);
            grbDatosPersonales.PerformLayout();
            gpbEstado.ResumeLayout(false);
            gpbEstado.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            grbListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private Label lblFechaNac;
        private DateTimePicker dtpFechaNac;
        private GroupBox grbDatosPersonales;
        private Button btnCrearUsuario;
        private Button btnModificarUsuario;
        private GroupBox grbListaClientes;
        private Button btnBuscarDni;
        private DataGridView dgvClientes;
        private TextBox txtBuscarClientes;
        private DateTimePicker dtpFechaIngreso;
        private Label lblFechaIngreso;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtMail;
        private Button btnSalir;
        private GroupBox gpbEstado;
        private RadioButton rbtActivo;
        private RadioButton rbtInactivo;
        private RadioButton rbtActivoFiltro;
        private RadioButton rbtInactivoFiltro;
        private Button button1;
    }
}