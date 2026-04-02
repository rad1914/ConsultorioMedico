using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCIRecetas : Form
    {
        SqlConnection conn = new SqlConnection(
            "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");

        public frmCIRecetas()
        {
            InitializeComponent();
        }

        private void frmCIReceta_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IdReceta FROM Recetas", conn);

            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            cboIdReceta.DataSource = dt;
            cboIdReceta.DisplayMember = "IdReceta";
            cboIdReceta.ValueMember = "IdReceta";

            dgvData.AutoGenerateColumns = true;
        }

        private void cmdBuscar_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    c.IdCita,
                    p.Nombre,
                    p.APaterno,
                    p.AMaterno,
                    p.Telefono,
                    e.IdExpediente,
                    e.Peso,
                    e.Estatura,
                    e.Temperatura,
                    e.Presion,
                    e.Sintomas,
                    e.Diagnostico,
                    e.Tratamiento,
                    e.Estudios,
                    d.Medicamento,
                    d.Indicaciones
                FROM Recetas r
                INNER JOIN Expedientes e ON e.IdExpediente = r.IdExpediente
                INNER JOIN Citas c ON c.IdCita = e.IdCita
                INNER JOIN Pacientes p ON p.IdPaciente = c.IdPaciente
                LEFT JOIN DetReceta d ON d.IdReceta = r.IdReceta
                WHERE r.IdReceta = @idReceta
            ", conn);

            da.SelectCommand.Parameters.AddWithValue("@idReceta", cboIdReceta.SelectedValue);

            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
            txtAPaterno.Text = dt.Rows[0]["APaterno"].ToString();
            txtAMaterno.Text = dt.Rows[0]["AMaterno"].ToString();
            txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
            txtIdExpediente.Text = dt.Rows[0]["IdExpediente"].ToString();
            txtPeso.Text = dt.Rows[0]["Peso"].ToString();
            txtEstatura.Text = dt.Rows[0]["Estatura"].ToString();
            txtTemperatura.Text = dt.Rows[0]["Temperatura"].ToString();
            txtPresion.Text = dt.Rows[0]["Presion"].ToString();
            txtSintomas.Text = dt.Rows[0]["Sintomas"].ToString();
            txtDiagnostico.Text = dt.Rows[0]["Diagnostico"].ToString();
            txtTratamiento.Text = dt.Rows[0]["Tratamiento"].ToString();
            txtEstudios.Text = dt.Rows[0]["Estudios"].ToString();

            dgvData.DataSource = dt;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}