using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
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
        int consecutivo;
        BindingSource fuente = new BindingSource();

        public frmRecetas()
        {
            InitializeComponent();
            AssignBindingTags();

            conn = new SqlConnection(
              "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");
        }

        private void AssignBindingTags()
        {
            txtNombre.Tag = "Nombre";
            txtAPaterno.Tag = "APaterno";
            txtAMaterno.Tag = "AMaterno";
            txtTelefono.Tag = "Telefono";
            cboGenero.Tag = "Genero";
            dtpFechaNacimiento.Tag = "FechaNac";
            cboSangre.Tag = "TipoSangre";
            txtAlergias.Tag = "Alergias";
            txtEnfermedadCronica.Tag = "EnfermedadCronica";
            txtPeso.Tag = "Peso";
            txtEstatura.Tag = "Estatura";
            txtTemperatura.Tag = "Temperatura";
            txtPresion.Tag = "Presion";
            txtSintomas.Tag = "Sintomas";
            txtDiagnostico.Tag = "Diagnostico";
            txtTratamiento.Tag = "Tratamiento";
            txtEstudios.Tag = "Estudios";
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

            cboPaciente.SelectedIndexChanged -= cboPaciente_SelectedIndexChanged;

            cboPaciente.DataSource = tabla;
            cboPaciente.DisplayMember = "Nombre";
            cboPaciente.ValueMember = "IdPaciente";

            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaciente.SelectedValue == null || cboPaciente.SelectedValue is DataRowView)
                return;

            int idPaciente = Convert.ToInt32(cboPaciente.SelectedValue);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT TOP 1 
                    c.IdCita, c.IdMedico, e.IdExpediente,
                    p.Nombre, p.APaterno, p.AMaterno, p.Telefono, p.Genero,
                    p.TipoSangre, p.FechaNac, p.Alergias, p.EnfermedadCronica,
                    e.Peso, e.Estatura, e.Temperatura, e.Presion,
                    e.Sintomas, e.Diagnostico, e.Tratamiento, e.Estudios
                FROM Citas c
                LEFT JOIN Expedientes e ON e.IdCita = c.IdCita
                INNER JOIN Pacientes p ON p.IdPaciente = c.IdPaciente
                WHERE c.IdPaciente = @id AND c.Estado = 'A'", conn);

            da.SelectCommand.Parameters.AddWithValue("@id", idPaciente);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                idCita = Convert.ToInt32(dt.Rows[0]["IdCita"]);
                idExpediente = dt.Rows[0]["IdExpediente"] == DBNull.Value
                    ? 0
                    : Convert.ToInt32(dt.Rows[0]["IdExpediente"]);

                fuente.DataSource = dt;
                fuente.Position = 0;

                BindControls();
                fuente.ResetBindings(false);
            }

            conn.Close();
        }

        private void BindControls()
        {
            BindControlsRecursive(this.Controls);
        }

        private void BindControlsRecursive(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c.Tag != null)
                {
                    c.DataBindings.Clear();
                    c.DataBindings.Add("Text", fuente, c.Tag.ToString());
                }

                if (c.HasChildren)
                    BindControlsRecursive(c.Controls);
            }
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

            if (idExpediente == 0)
            {
                SqlCommand cmdExp = new SqlCommand(@"
                    INSERT INTO Expedientes
                        (IdCita, Peso, Estatura, Temperatura, Presion,
                         Sintomas, Diagnostico, Tratamiento, Estudios)
                    VALUES
                        (@idCita, @peso, @est, @temp, @pres,
                         @sint, @diag, @trat, @estu);
                    SELECT SCOPE_IDENTITY();", conn);

                cmdExp.Parameters.AddWithValue("@idCita", idCita);
                cmdExp.Parameters.AddWithValue("@peso", txtPeso.Text);
                cmdExp.Parameters.AddWithValue("@est", txtEstatura.Text);
                cmdExp.Parameters.AddWithValue("@temp", txtTemperatura.Text);
                cmdExp.Parameters.AddWithValue("@pres", txtPresion.Text);
                cmdExp.Parameters.AddWithValue("@sint", txtSintomas.Text);
                cmdExp.Parameters.AddWithValue("@diag", txtDiagnostico.Text);
                cmdExp.Parameters.AddWithValue("@trat", txtTratamiento.Text);
                cmdExp.Parameters.AddWithValue("@estu", txtEstudios.Text);

                idExpediente = Convert.ToInt32(cmdExp.ExecuteScalar());
            }

            SqlCommand cmdMed = new SqlCommand(
                "SELECT IdMedico FROM Citas WHERE IdCita = @idCita", conn);
            cmdMed.Parameters.AddWithValue("@idCita", idCita);
            int idMedico = Convert.ToInt32(cmdMed.ExecuteScalar());

            SqlCommand cmdRecetas = new SqlCommand(@"
                IF NOT EXISTS (SELECT 1 FROM Recetas WHERE IdExpediente = @idExp)
                BEGIN
                    INSERT INTO Recetas (IdExpediente, IdMedico)
                    VALUES (@idExp, @idMedico);
                END

                SELECT IdReceta FROM Recetas WHERE IdExpediente = @idExp;", conn);

            cmdRecetas.Parameters.AddWithValue("@idExp", idExpediente);
            cmdRecetas.Parameters.AddWithValue("@idMedico", idMedico);

            idReceta = Convert.ToInt32(cmdRecetas.ExecuteScalar());

            SqlCommand cmdNR = new SqlCommand(@"
                SELECT ISNULL(MAX(IdConsec), 0)
                FROM DetReceta
                WHERE IdReceta = @idReceta", conn);

            cmdNR.Parameters.AddWithValue("@idReceta", idReceta);
            consecutivo = Convert.ToInt32(cmdNR.ExecuteScalar());

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

            MessageBox.Show("Receta registrada. Ejecute nuevamente el formulario si desea refrescar los Datos.");

            conn.Close();
            tablaDetalle.Clear();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}