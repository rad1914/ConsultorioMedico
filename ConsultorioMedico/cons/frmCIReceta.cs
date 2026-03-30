using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCIReceta : Form
    {
        SqlConnection conn;

        public frmCIReceta()
        {
            InitializeComponent();

            conn = new SqlConnection(
              "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");
        }

        private void frmCIReceta_Load(object sender, EventArgs e)
        {
            CargarRecetas();
        }

        // ============================
        // CARGAR COMBO
        // ============================
        private void CargarRecetas()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT IdReceta FROM Recetas", conn);

            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            cboIdPaciente.SelectedIndexChanged -= cboIdReceta_SelectedIndexChanged;

            cboIdPaciente.DataSource = dt;
            cboIdPaciente.DisplayMember = "IdReceta";
            cboIdPaciente.ValueMember = "IdReceta";

            cboIdPaciente.SelectedIndexChanged += cboIdReceta_SelectedIndexChanged;
        }

        // ============================
        // EVENTO SELECCIÓN
        // ============================
        private void cboIdReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIdPaciente.SelectedValue == null || cboIdPaciente.SelectedValue is DataRowView)
                return;

            int idReceta = Convert.ToInt32(cboIdPaciente.SelectedValue);

            conn.Open();

            // ===== ENCABEZADO =====
            SqlCommand cmd = new SqlCommand(@"
                SELECT IdExpediente
                FROM Recetas
                WHERE IdReceta = @idReceta", conn);

            cmd.Parameters.AddWithValue("@idReceta", idReceta);

            object result = cmd.ExecuteScalar();
            textBox1.Text = result != null ? result.ToString() : "";

            // ===== DETALLE (MULTIPLE) =====
            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT IdConsec, Medicamento, Indicaciones
                FROM DetReceta
                WHERE IdReceta = @idReceta
                ORDER BY IdConsec", conn);

            da.SelectCommand.Parameters.AddWithValue("@idReceta", idReceta);

            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            // Mostrar en grid (porque sí, hay múltiples registros)
            dgvData.DataSource = dt;

            // Opcional: limpiar textbox (ya no tienen sentido como únicos)
            txtMedicamento.Clear();
            txtIndicaciones.Clear();
        }

        // ============================
        // SALIR
        // ============================
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}