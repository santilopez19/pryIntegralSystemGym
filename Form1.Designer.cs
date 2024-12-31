namespace pryAccesoGym
{
    partial class frmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            btnIngresar = new Button();
            lblContraseña = new Label();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.FlatStyle = FlatStyle.System;
            btnIngresar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(608, 403);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 51);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // lblContraseña
            // 
            lblContraseña.Anchor = AnchorStyles.Right;
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.Location = new Point(693, 336);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(164, 38);
            lblContraseña.TabIndex = 7;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Anchor = AnchorStyles.None;
            txtContrasena.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtContrasena.Location = new Point(478, 331);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(209, 43);
            txtContrasena.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(478, 272);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(209, 43);
            txtUsuario.TabIndex = 8;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(706, 275);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(117, 38);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 721);
            Controls.Add(btnIngresar);
            Controls.Add(lblContraseña);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label lblContraseña;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label lblUsuario;
    }
}
