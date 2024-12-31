namespace pryAccesoGym
{
    partial class frmIngreso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            btnIngresar = new Button();
            txtDniIngreso = new TextBox();
            lblAvisoIngreso = new Label();
            tLbl = new System.Windows.Forms.Timer(components);
            lblDniIngrese = new Label();
            lblAnuncio = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(721, 607);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(178, 55);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtDniIngreso
            // 
            txtDniIngreso.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDniIngreso.Location = new Point(667, 546);
            txtDniIngreso.Multiline = true;
            txtDniIngreso.Name = "txtDniIngreso";
            txtDniIngreso.Size = new Size(270, 46);
            txtDniIngreso.TabIndex = 1;
            txtDniIngreso.TextAlign = HorizontalAlignment.Center;
            txtDniIngreso.TextChanged += txtDniIngreso_TextChanged;
            // 
            // lblAvisoIngreso
            // 
            lblAvisoIngreso.BackColor = Color.Transparent;
            lblAvisoIngreso.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvisoIngreso.Location = new Point(470, 681);
            lblAvisoIngreso.Name = "lblAvisoIngreso";
            lblAvisoIngreso.Size = new Size(653, 111);
            lblAvisoIngreso.TabIndex = 2;
            lblAvisoIngreso.TextAlign = ContentAlignment.MiddleCenter;
            lblAvisoIngreso.Click += lblAvisoIngreso_Click;
            // 
            // tLbl
            // 
            tLbl.Interval = 5000;
            tLbl.Tick += tLbl_Tick;
            // 
            // lblDniIngrese
            // 
            lblDniIngrese.AutoSize = true;
            lblDniIngrese.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniIngrese.Location = new Point(650, 489);
            lblDniIngrese.Name = "lblDniIngrese";
            lblDniIngrese.Size = new Size(345, 54);
            lblDniIngrese.TabIndex = 3;
            lblDniIngrese.Text = "INGRESE SU DNI ";
            // 
            // lblAnuncio
            // 
            lblAnuncio.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnuncio.ForeColor = SystemColors.ActiveCaptionText;
            lblAnuncio.Location = new Point(42, 65);
            lblAnuncio.Name = "lblAnuncio";
            lblAnuncio.Size = new Size(527, 461);
            lblAnuncio.TabIndex = 4;
            lblAnuncio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview__1_;
            pictureBox1.Location = new Point(650, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1682, 953);
            Controls.Add(lblAnuncio);
            Controls.Add(lblAvisoIngreso);
            Controls.Add(lblDniIngrese);
            Controls.Add(btnIngresar);
            Controls.Add(txtDniIngreso);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmIngreso";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            Load += frmIngreso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtDniIngreso;
        private Label lblAvisoIngreso;
        private System.Windows.Forms.Timer tLbl;
        private Label lblDniIngrese;
        private Label lblAnuncio;
        private PictureBox pictureBox1;
    }
}