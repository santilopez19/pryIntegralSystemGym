
using System.Data;
using Microsoft.Data.SqlClient;
using static pryAccesoGym.bdGimnasio;
using System.IO.Ports;

namespace pryAccesoGym
{
    public partial class frmMenu : Form
    {

        private SerialPort arduinoPort;
        public frmMenu()
        {
            InitializeComponent();
            cmbFiltrado.Items.Add("DNI");
            cmbFiltrado.Items.Add("Nombre");
            cmbFiltrado.SelectedIndex = 0;
            CargarPagos();
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
            this.Hide();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            frmIngreso frmIngreso = new frmIngreso();
            frmIngreso.Show();
        }

        private void CargarPagos()
        {
            try
            {
                string query = @"
        SELECT 
            p.PagoID AS 'PagoID',
            p.DNI AS 'Documento', 
            c.Nombre AS 'Nombre', 
            c.Apellido AS 'Apellido', 
            p.Monto AS 'Monto Pagado', 
            p.MetodoPago AS 'Método de Pago', 
            p.FechaPago AS 'Fecha de Pago'
        FROM 
            Pagos p
        JOIN 
            Clientes c 
        ON 
            p.DNI = c.DNI
        ORDER BY 
            p.FechaPago DESC";

                DataTable dataTable = DatabaseHelper.ExecuteQuery(query);
                dgvClientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCargarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores ingresados por el usuario
                string dni = txtDniAbono.Text.Trim();
                string montoTexto = txtMonto.Text.Trim();
                decimal monto;

                // Validar que el monto sea un número válido
                if (!decimal.TryParse(montoTexto, out monto))
                {
                    MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determinar el método de pago
                string metodoPago = rbtEfectivo.Checked ? "Efectivo" : rbtTransferencia.Checked ? "Transferencia" : "";

                if (string.IsNullOrEmpty(metodoPago))
                {
                    MessageBox.Show("Debe seleccionar un método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Consulta para insertar el pago
                string query = "INSERT INTO Pagos (DNI, Monto, MetodoPago, FechaPago) " +
                               "VALUES (@DNI, @Monto, @MetodoPago, @FechaPago)";

                // Ejecutar el comando
                int filasAfectadas = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter[]
                {
            new SqlParameter("@DNI", dni),
            new SqlParameter("@Monto", monto),
            new SqlParameter("@MetodoPago", metodoPago),
            new SqlParameter("@FechaPago", DateTime.Now)
                });

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("      El DNI ingresado es Incorrecto    ");
            }
        }
        private void LimpiarCampos()
        {
            txtDniAbono.Text = "";
            txtMonto.Text = "";
            rbtEfectivo.Checked = false;
            rbtTransferencia.Checked = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Si el campo de búsqueda está vacío, cargar todos los pagos
                if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    CargarPagos();
                    return;
                }

                // Obtener el criterio de filtrado y el texto ingresado
                string criterio = cmbFiltrado.SelectedItem?.ToString();
                string textoBusqueda = txtBusqueda.Text.Trim();

                // Validar que haya un criterio seleccionado
                if (string.IsNullOrEmpty(criterio))
                {
                    MessageBox.Show("Por favor, seleccione un criterio de búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Definir la consulta dinámica según el criterio
                string query = @"
            SELECT 
                p.PagoID AS 'PagoID',
                p.DNI AS 'Documento', 
                c.Nombre AS 'Nombre', 
                c.Apellido AS 'Apellido', 
                p.Monto AS 'Monto Pagado', 
                p.MetodoPago AS 'Método de Pago', 
                p.FechaPago AS 'Fecha de Pago' 
            FROM 
                Pagos p
            JOIN 
                Clientes c 
            ON 
                p.DNI = c.DNI
            WHERE ";

                SqlParameter[] parametros;

                // Ajustar el filtro según el criterio seleccionado
                if (criterio == "DNI")
                {
                    query += "p.DNI LIKE @Busqueda";
                    parametros = new SqlParameter[]
                    {
                new SqlParameter("@Busqueda", "%" + textoBusqueda + "%")
                    };
                }
                else if (criterio == "Nombre")
                {
                    query += "c.Nombre LIKE @Busqueda";
                    parametros = new SqlParameter[]
                    {
                new SqlParameter("@Busqueda", "%" + textoBusqueda + "%")
                    };
                }
                else
                {
                    MessageBox.Show("Criterio de búsqueda no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                query += " ORDER BY p.FechaPago DESC";

                // Ejecutar la consulta con los parámetros y mostrar los resultados
                DataTable dataTable = DatabaseHelper.ExecuteQuery(query, parametros);

                // Verificar si hay resultados antes de mostrar en el DataGridView
                if (dataTable.Rows.Count > 0)
                {
                    dgvClientes.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para la búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvClientes.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dgvClientes.CurrentRow != null)
                {
                    // Obtener el PagoID del registro seleccionado
                    int pagoID = Convert.ToInt32(dgvClientes.CurrentRow.Cells["PagoID"].Value);

                    // Confirmar antes de eliminar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este pago?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Consulta para eliminar el pago utilizando PagoID
                        string query = "DELETE FROM Pagos WHERE PagoID = @PagoID";

                        int filasAfectadas = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter[]
                        {
                    new SqlParameter("@PagoID", pagoID)
                        });

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pago eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarPagos(); // Actualizar el DataGridView después de eliminar
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un pago para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDniAbono.Text = dgvClientes.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                txtMonto.Text = dgvClientes.Rows[e.RowIndex].Cells["Monto Pagado"].Value.ToString();
                string metodoPago = dgvClientes.Rows[e.RowIndex].Cells["Método de Pago"].Value.ToString();

                if (metodoPago == "Efectivo")
                    rbtEfectivo.Checked = true;
                else if (metodoPago == "Transferencia")
                    rbtTransferencia.Checked = true;
                dtpFechaPago.Value = Convert.ToDateTime(dgvClientes.Rows[e.RowIndex].Cells["Fecha de Pago"].Value);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    int pagoID = Convert.ToInt32(dgvClientes.CurrentRow.Cells["PagoID"].Value);
                    string nuevoDni = txtDniAbono.Text.Trim();
                    string montoTexto = txtMonto.Text.Trim();
                    decimal monto;

                    if (!decimal.TryParse(montoTexto, out monto))
                    {
                        MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(nuevoDni))
                    {
                        MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string metodoPago = rbtEfectivo.Checked ? "Efectivo" : rbtTransferencia.Checked ? "Transferencia" : "";

                    if (string.IsNullOrEmpty(metodoPago))
                    {
                        MessageBox.Show("Debe seleccionar un método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DateTime fechaPago = dtpFechaPago.Value;

                    string query = "UPDATE Pagos SET DNI = @DNI, Monto = @Monto, MetodoPago = @MetodoPago, FechaPago = @FechaPago WHERE PagoID = @PagoID";

                    int filasAfectadas = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter[]
                    {
                new SqlParameter("@DNI", nuevoDni),
                new SqlParameter("@Monto", monto),
                new SqlParameter("@MetodoPago", metodoPago),
                new SqlParameter("@FechaPago", fechaPago),
                new SqlParameter("@PagoID", pagoID)
                    });

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Pago modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPagos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un pago para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirPuerta1min_Click(object sender, EventArgs e)
        {
            // AbrirPuerta(60000);
        }

        private void btnAbrirPuerta_Click(object sender, EventArgs e)
        {
            //AbrirPuerta(5000);
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

                // Esperar el tiempo indicado antes de cerrar la puerta
                Thread.Sleep(tiempoEnMilisegundos);

                // Enviar el comando para cerrar la puerta
                arduinoPort.WriteLine("CLOSE");

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

        private void btnCartelIngreso_Click(object sender, EventArgs e)
        {
            frmAnuncio frmAnuncio = new frmAnuncio();
            frmAnuncio.Show();
        }
    }
}
