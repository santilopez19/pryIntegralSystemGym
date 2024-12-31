namespace pryAccesoGym
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;

            if (usuarioIngresado == nombre && contrasenaIngresada == numero.ToString())
            {
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string nombre = "Cristian";
        int numero = 12345;
    }
}
