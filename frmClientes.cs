using System.Data;
using Microsoft.Data.SqlClient;
using static pryAccesoGym.bdGimnasio;


namespace pryAccesoGym
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += VolverPagina_KeyDown;
            CargarClientes();
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void VolverPagina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
                this.Hide();
            }
        }

        private void CargarClientes()
        {
            try
            {
                string query = "SELECT DNI, Nombre, Apellido, FechaNacimiento, Sexo, FechaIngreso, Telefono, Email, Estado FROM Clientes ORDER BY Nombre ASC";
                DataTable dataTable = DatabaseHelper.ExecuteQuery(query);
                dgvClientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) || cmbSexo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string estado = rbtActivo.Checked ? "Activo" : rbtInactivo.Checked ? "Inactivo" : "Activo";

            string query = @"
        INSERT INTO Clientes (DNI, Nombre, Apellido, FechaNacimiento, Sexo, FechaIngreso, Telefono, Email, Estado)
        VALUES (@DNI, @Nombre, @Apellido, @FechaNacimiento, @Sexo, @FechaIngreso, @Telefono, @Email, @Estado)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@DNI", txtDni.Text.Trim()),
        new SqlParameter("@Nombre", txtNombre.Text.Trim()),
        new SqlParameter("@Apellido", txtApellido.Text.Trim()),
        new SqlParameter("@FechaNacimiento", dtpFechaNac.Value),
        new SqlParameter("@Sexo", cmbSexo.SelectedItem.ToString()),
        new SqlParameter("@FechaIngreso", dtpFechaIngreso.Value),
        new SqlParameter("@Telefono", txtTelefono.Text.Trim()),
        new SqlParameter("@Email", txtMail.Text.Trim()),
        new SqlParameter("@Estado", estado)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Cliente creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarClientes();
            LimpiarCampos();
        }


        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                txtDni.Text = row.Cells["DNI"].Value?.ToString() ?? "";
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtApellido.Text = row.Cells["Apellido"].Value?.ToString() ?? "";
                dtpFechaNac.Value = row.Cells["FechaNacimiento"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["FechaNacimiento"].Value) : DateTime.Now;
                cmbSexo.SelectedItem = row.Cells["Sexo"].Value?.ToString() ?? "";
                dtpFechaIngreso.Value = row.Cells["FechaIngreso"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["FechaIngreso"].Value) : DateTime.Now;
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? ""; // Nuevo
                txtMail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                dgvClientes.Columns["Estado"].HeaderText = "Estado";

            }
        }

        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNac.Value = DateTime.Now;
            cmbSexo.SelectedIndex = -1;
            dtpFechaIngreso.Value = DateTime.Now;
            txtTelefono.Clear();
            txtMail.Clear();

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            cmbSexo.SelectedIndex = -1;
            rbtActivo.Checked = true;
            rbtActivoFiltro.Checked = true;

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string estado = rbtActivo.Checked ? "Activo" : rbtInactivo.Checked ? "Inactivo" : "Activo";

            string query = @"
        UPDATE Clientes 
        SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, 
            Sexo = @Sexo, FechaIngreso = @FechaIngreso, Telefono = @Telefono, Email = @Email, Estado = @Estado
        WHERE DNI = @DNI";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@DNI", txtDni.Text.Trim()),
        new SqlParameter("@Nombre", txtNombre.Text.Trim()),
        new SqlParameter("@Apellido", txtApellido.Text.Trim()),
        new SqlParameter("@FechaNacimiento", dtpFechaNac.Value),
        new SqlParameter("@Sexo", cmbSexo.SelectedItem.ToString()),
        new SqlParameter("@FechaIngreso", dtpFechaIngreso.Value),
        new SqlParameter("@Telefono", txtTelefono.Text.Trim()),
        new SqlParameter("@Email", txtMail.Text.Trim()),
        new SqlParameter("@Estado", estado)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Cliente modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarClientes();
            LimpiarCampos();
        }


        /*private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    
                    string dni = dgvClientes.SelectedRows[0].Cells["DNI"].Value.ToString();

                    
                    DialogResult result = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar este cliente?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        
                        string query = "DELETE FROM Clientes WHERE DNI = @DNI";

                        
                        int filasAfectadas = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter[]
                        {
                    new SqlParameter("@DNI", dni)
                        });

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarClientes();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void cmbFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {

            FiltrarClientes(txtBuscarClientes.Text.Trim());
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBuscarClientes.Text))
            {
                CargarClientes();
            }
            else
            {

                FiltrarClientes(txtBuscarClientes.Text.Trim());
            }
        }
        private void FiltrarClientes(string filtro)
        {
            try
            {
                string query = @"
            SELECT DNI, Nombre, Apellido, FechaNacimiento, Sexo, FechaIngreso, Telefono, Email, Estado 
            FROM Clientes 
            WHERE (DNI LIKE @Filtro OR Nombre LIKE @Filtro)";

                List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@Filtro", "%" + filtro + "%")
        };

                if (rbtActivoFiltro.Checked)
                {
                    query += " AND Estado = @Estado";
                    parameters.Add(new SqlParameter("@Estado", "Activo"));
                }
                else if (rbtInactivoFiltro.Checked)
                {
                    query += " AND Estado = @Estado";
                    parameters.Add(new SqlParameter("@Estado", "Inactivo"));
                }

                query += " ORDER BY Nombre ASC";

                DataTable dataTable = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
                dgvClientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
