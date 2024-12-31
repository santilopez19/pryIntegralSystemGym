namespace pryAccesoGym
{
    partial class frmAnuncio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnuncio));
            btnSalir = new Button();
            txtAnuncio = new TextBox();
            btnGuardarCambios = new Button();
            rbtRojo = new RadioButton();
            rbtAzul = new RadioButton();
            grbColores = new GroupBox();
            rbtNegro = new RadioButton();
            grbColores.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gold;
            btnSalir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(982, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 35);
            btnSalir.TabIndex = 27;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtAnuncio
            // 
            txtAnuncio.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnuncio.Location = new Point(74, 53);
            txtAnuncio.Multiline = true;
            txtAnuncio.Name = "txtAnuncio";
            txtAnuncio.Size = new Size(527, 461);
            txtAnuncio.TabIndex = 28;
            txtAnuncio.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.PaleGreen;
            btnGuardarCambios.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.Location = new Point(650, 245);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(214, 35);
            btnGuardarCambios.TabIndex = 30;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // rbtRojo
            // 
            rbtRojo.AutoSize = true;
            rbtRojo.Location = new Point(27, 75);
            rbtRojo.Name = "rbtRojo";
            rbtRojo.Size = new Size(72, 29);
            rbtRojo.TabIndex = 32;
            rbtRojo.TabStop = true;
            rbtRojo.Text = "Rojo";
            rbtRojo.UseVisualStyleBackColor = true;
            // 
            // rbtAzul
            // 
            rbtAzul.AutoSize = true;
            rbtAzul.Location = new Point(27, 39);
            rbtAzul.Name = "rbtAzul";
            rbtAzul.Size = new Size(71, 29);
            rbtAzul.TabIndex = 31;
            rbtAzul.TabStop = true;
            rbtAzul.Text = "Azul";
            rbtAzul.UseVisualStyleBackColor = true;
            // 
            // grbColores
            // 
            grbColores.Controls.Add(rbtNegro);
            grbColores.Controls.Add(rbtAzul);
            grbColores.Controls.Add(rbtRojo);
            grbColores.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbColores.Location = new Point(650, 53);
            grbColores.Name = "grbColores";
            grbColores.Size = new Size(302, 164);
            grbColores.TabIndex = 33;
            grbColores.TabStop = false;
            grbColores.Text = "Colores";
            // 
            // rbtNegro
            // 
            rbtNegro.AutoSize = true;
            rbtNegro.Location = new Point(26, 110);
            rbtNegro.Name = "rbtNegro";
            rbtNegro.Size = new Size(86, 29);
            rbtNegro.TabIndex = 33;
            rbtNegro.TabStop = true;
            rbtNegro.Text = "Negro";
            rbtNegro.UseVisualStyleBackColor = true;
            // 
            // frmAnuncio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 557);
            Controls.Add(grbColores);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtAnuncio);
            Controls.Add(btnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAnuncio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anuncio";
            grbColores.ResumeLayout(false);
            grbColores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private TextBox txtAnuncio;
        private Button btnGuardarCambios;
        private RadioButton rbtRojo;
        private RadioButton rbtAzul;
        private GroupBox grbColores;
        private RadioButton rbtNegro;
    }
}