using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmRecetas : Form
    {
        SqlConnection conn;
        int idCita;
        DataTable tablaDetalle = new DataTable();
        int idExpediente;
        int idReceta;

        public frmRecetas()
        {
            InitializeComponent();

            conn = new SqlConnection(
              "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");
        }

        private void frmRecetas_Load(object sender, EventArgs e)
        {
            tablaDetalle.Columns.Add("Medicamento");
            tablaDetalle.Columns.Add("Indicaciones");
            dgvData.DataSource = tablaDetalle;

            SqlDataAdapter adapter = new SqlDataAdapter(@"
                SELECT DISTINCT p.IdPaciente, p.Nombre
                FROM Citas c
                INNER JOIN Pacientes p ON p.IdPaciente = c.IdPaciente
                WHERE c.Estado = 'A'", conn);

            DataTable tabla = new DataTable();

            conn.Open();
            adapter.Fill(tabla);
            conn.Close();

            cboPaciente.DataSource = tabla;
            cboPaciente.DisplayMember = "Nombre";
            cboPaciente.ValueMember = "IdPaciente";
        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPaciente = Convert.ToInt32(cboPaciente.SelectedValue);

            conn.Open();

            SqlCommand cmd = new SqlCommand(@"
                SELECT TOP 1 c.IdCita, e.IdExpediente
                FROM Citas c
                LEFT JOIN Expedientes e ON e.IdCita = c.IdCita
                WHERE c.IdPaciente = @id AND c.Estado = 'A'", conn);

            cmd.Parameters.AddWithValue("@id", idPaciente);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            idCita = Convert.ToInt32(dr["IdCita"]);
            idExpediente = Convert.ToInt32(dr["IdExpediente"]);

            dr.Close();
            conn.Close();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            tablaDetalle.Rows.Add(txtMedicamento.Text, txtIndicaciones.Text);
            txtMedicamento.Clear();
            txtIndicaciones.Clear();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmdMed = new SqlCommand(
                "SELECT IdMedico FROM Citas WHERE IdCita = @idCita", conn);
            cmdMed.Parameters.AddWithValue("@idCita", idCita);
            int idMedico = Convert.ToInt32(cmdMed.ExecuteScalar());

            SqlCommand cmdReceta = new SqlCommand(@"
                IF NOT EXISTS (SELECT 1 FROM Recetas WHERE IdExpediente = @idExp)
                BEGIN
                    INSERT INTO Recetas (IdExpediente, IdMedico)
                    VALUES (@idExp, @idMedico);
                END

                SELECT IdReceta FROM Recetas WHERE IdExpediente = @idExp;", conn);

            cmdReceta.Parameters.AddWithValue("@idExp", idExpediente);
            cmdReceta.Parameters.AddWithValue("@idMedico", idMedico);

            idReceta = Convert.ToInt32(cmdReceta.ExecuteScalar());

            SqlCommand cmdNR = new SqlCommand(@"
                SELECT ISNULL(MAX(IdConsec), 0)
                FROM DetReceta
                WHERE IdReceta = @idReceta", conn);

            cmdNR.Parameters.AddWithValue("@idReceta", idReceta);
            int consecutivo = Convert.ToInt32(cmdNR.ExecuteScalar());

            foreach (DataRow row in tablaDetalle.Rows)
            {
                consecutivo++;

                SqlCommand cmdDet = new SqlCommand(@"
                    INSERT INTO DetReceta (IdReceta, IdConsec, Medicamento, Indicaciones)
                    VALUES (@idReceta, @nr, @med, @ind)", conn);

                cmdDet.Parameters.AddWithValue("@idReceta", idReceta);
                cmdDet.Parameters.AddWithValue("@nr", consecutivo);
                cmdDet.Parameters.AddWithValue("@med", row["Medicamento"]);
                cmdDet.Parameters.AddWithValue("@ind", row["Indicaciones"]);

                cmdDet.ExecuteNonQuery();
            }

            SqlCommand update = new SqlCommand(
                "UPDATE Citas SET Estado = 'M' WHERE IdCita = @idCita", conn);
            update.Parameters.AddWithValue("@idCita", idCita);
            update.ExecuteNonQuery();

            conn.Close();
            tablaDetalle.Clear();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}