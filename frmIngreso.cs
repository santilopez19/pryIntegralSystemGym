using System.Data;
using static pryAccesoGym.bdGimnasio;
using Microsoft.Data.SqlClient;
using System.IO.Ports;

namespace pryAccesoGym
{
    public partial class frmIngreso : Form
    {
        private SerialPort arduinoPort;
        public frmIngreso()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += VolverPagina_KeyDown;
            this.KeyDown += EnterKey_KeyDown;
        }
        private void EnterKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            txtDniIngreso.Focus();
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            txtDniIngreso.Focus();
            CargarAnuncio();
        }
        private void VolverPagina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
        private void IniciarTemporizador()
        {
            tLbl.Stop();
            tLbl.Start();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDniIngreso.Text.Trim();
                txtDniIngreso.Text = "";
                IniciarTemporizador();
                if (string.IsNullOrWhiteSpace(dni))
                {
                    lblAvisoIngreso.Text = "Por favor, ingrese un DNI válido.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }

                string clienteQuery = "SELECT Nombre FROM Clientes WHERE DNI = @DNI";
                object nombreClienteObj = DatabaseHelper.ExecuteScalar(clienteQuery, new SqlParameter[]
                {
            new SqlParameter("@DNI", dni)
                });

                if (nombreClienteObj == null || nombreClienteObj == DBNull.Value)
                {
                    lblAvisoIngreso.Text = "El DNI no está registrado en el sistema.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }

                string nombreCliente = nombreClienteObj.ToString();

                string pagoQuery = @"
        SELECT TOP 1 FechaPago 
        FROM Pagos 
        WHERE DNI = @DNI 
        ORDER BY FechaPago DESC";

                object fechaPagoObj = DatabaseHelper.ExecuteScalar(pagoQuery, new SqlParameter[]
                {
            new SqlParameter("@DNI", dni)
                });

                if (fechaPagoObj == null || fechaPagoObj == DBNull.Value)
                {
                    lblAvisoIngreso.Text = $"No se encontraron pagos registrados para {nombreCliente}.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }
                txtDniIngreso.Text = "";
                DateTime fechaPago = Convert.ToDateTime(fechaPagoObj);
                DateTime fechaProximoPago = fechaPago.AddMonths(1);
                DateTime fechaLimiteAviso = fechaProximoPago.AddDays(-10);

                if (DateTime.Now >= fechaLimiteAviso && DateTime.Now < fechaProximoPago)
                {
                    lblAvisoIngreso.Text = $"{nombreCliente}, su cuota vence el {fechaProximoPago:dd/MM/yyyy}.";
                    lblAvisoIngreso.ForeColor = Color.Orange; 
                }
                else if (DateTime.Now >= fechaProximoPago)
                {
                    lblAvisoIngreso.Text = $"{nombreCliente}, su cuota venció el {fechaProximoPago:dd/MM/yyyy}.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                }
                else
                {// Lista de mensajes de bienvenida
                    string[] mensajesBienvenida = new string[]
                    {
    $"¡Hola {nombreCliente}! 😄 ¡Qué bueno verte de nuevo!",
    $"¡Hola {nombreCliente}! 😄 ¡Vamos por más juntos! 💪",
    $"¡Hola {nombreCliente}! 🏋️‍♂️ ¡Qué bueno verte de nuevo!",
    $"¡Hola {nombreCliente}! ✨ ¡Va a ser un gran día de entrenamiento! 💥"
                    };
                    Random random = new Random();
                    string mensajeAleatorio = mensajesBienvenida[random.Next(mensajesBienvenida.Length)];
                    lblAvisoIngreso.Text = mensajeAleatorio;
                    lblAvisoIngreso.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al verificar el ingreso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarAnuncio()
        {
            try
            {
                string query = "SELECT Texto, Color FROM Anuncio WHERE Id = 1";
                DataTable dataTable = bdGimnasio.DatabaseHelper.ExecuteQuery(query);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    lblAnuncio.Text = row["Texto"].ToString();

                    string color = row["Color"].ToString();
                    switch (color.ToLower())
                    {
                        case "azul":
                            lblAnuncio.ForeColor = Color.Blue;
                            break;
                        case "rojo":
                            lblAnuncio.ForeColor = Color.Red;
                            break;
                        case "negro":
                            lblAnuncio.ForeColor = Color.Black;
                            break;
                    }

                    // Cambiar borde si el texto no está vacío
                    if (!string.IsNullOrWhiteSpace(lblAnuncio.Text))
                    {
                        lblAnuncio.BorderStyle = BorderStyle.None; // Quita el borde predeterminado
                        this.Paint += new PaintEventHandler(DibujarBordeAnuncio);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el anuncio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tLbl_Tick(object sender, EventArgs e)
        {

            tLbl.Stop();
            lblAvisoIngreso.Text = "";
        }
        private void AbrirPuerta(int tiempoEnMilisegundos)
        {
            try
            {
                // Abrir el puerto serie si no está abierto
                if (!arduinoPort.IsOpen)
                {
                    arduinoPort.Open();
                }

                // Enviar el comando para abrir la puerta
                arduinoPort.WriteLine("OPEN");
                MessageBox.Show($"Puerta abierta por {tiempoEnMilisegundos / 1000} segundos.", "Puerta abierta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Esperar el tiempo indicado antes de cerrar la puerta
                Thread.Sleep(tiempoEnMilisegundos);

                // Enviar el comando para cerrar la puerta
                arduinoPort.WriteLine("CLOSE");
                MessageBox.Show("Puerta cerrada.", "Puerta cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el puerto serie
                arduinoPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al controlar la puerta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de que el puerto esté cerrado al finalizar
                if (arduinoPort.IsOpen)
                {
                    arduinoPort.Close();
                }
            }
        }
        private void DibujarBordeAnuncio(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblAnuncio.Text))
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    // Calcula la posición del borde basado en el lblAnuncio
                    Rectangle rect = lblAnuncio.Bounds;
                    rect.Inflate(2, 2); // Ajustar para que el borde no quede pegado al texto
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
