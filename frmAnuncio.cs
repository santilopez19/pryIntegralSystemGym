using Microsoft.Data.SqlClient;
using System.Data;

namespace pryAccesoGym
{
    public partial class frmAnuncio : Form
    {
        public frmAnuncio()
        {
            InitializeComponent();
            CargarAnuncio();
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
                    txtAnuncio.Text = row["Texto"].ToString();

                    string color = row["Color"].ToString();
                    switch (color.ToLower())
                    {
                        case "azul":
                            rbtAzul.Checked = true;
                            break;
                        case "rojo":
                            rbtRojo.Checked = true;
                            break;
                        case "negro":
                            rbtNegro.Checked = true;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el anuncio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtAnuncio.Text;
                string color = rbtAzul.Checked ? "Azul" :
                               rbtRojo.Checked ? "Rojo" : "Negro";

                string query = "UPDATE Anuncio SET Texto = @Texto, Color = @Color WHERE Id = 1";
                SqlParameter[] parameters = {
                    new SqlParameter("@Texto", texto),
                    new SqlParameter("@Color", color)
                };

                bdGimnasio.DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Anuncio actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
