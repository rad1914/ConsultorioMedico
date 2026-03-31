using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCIRecetas : Form
    {
        SqlConnection conn;

        public frmCIRecetas()
        {
            InitializeComponent();

            conn = new SqlConnection(
                "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");
        }

        private void frmCIReceta_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT IdReceta
                FROM Recetas
            ", conn);

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
            int idReceta = Convert.ToInt32(cboIdReceta.SelectedValue);

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
                    r.IdReceta,
                    d.Medicamento,
                    d.Indicaciones
                FROM Recetas r
                INNER JOIN Expedientes e ON e.IdExpediente = r.IdExpediente
                INNER JOIN Citas c ON c.IdCita = e.IdCita
                INNER JOIN Pacientes p ON p.IdPaciente = c.IdPaciente
                LEFT JOIN DetReceta d ON d.IdReceta = r.IdReceta
                WHERE r.IdReceta = @idReceta
            ", conn);

            da.SelectCommand.Parameters.AddWithValue("@idReceta", idReceta);

            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            DataRow row = dt.Rows[0];

            txtNombre.Text = row["Nombre"].ToString();
            txtAPaterno.Text = row["APaterno"].ToString();
            txtAMaterno.Text = row["AMaterno"].ToString();
            txtTelefono.Text = row["Telefono"].ToString();
            txtIdExpediente.Text = row["IdExpediente"].ToString();
            txtPeso.Text = row["Peso"].ToString();
            txtEstatura.Text = row["Estatura"].ToString();
            txtTemperatura.Text = row["Temperatura"].ToString();
            txtPresion.Text = row["Presion"].ToString();
            txtSintomas.Text = row["Sintomas"].ToString();
            txtDiagnostico.Text = row["Diagnostico"].ToString();
            txtTratamiento.Text = row["Tratamiento"].ToString();
            txtEstudios.Text = row["Estudios"].ToString();

            DataView dv = new DataView(dt);
            DataTable recetaTable = dv.ToTable(false, "Medicamento", "Indicaciones");
            dgvData.DataSource = recetaTable;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}