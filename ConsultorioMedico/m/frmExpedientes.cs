using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmExpedientes : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapterCitas;
        SqlDataAdapter adapterExp;
        DataTable tablaCitas;
        DataTable tablaExp;

        BindingSource citasBS = new BindingSource();
        BindingSource expBS = new BindingSource();

        public frmExpedientes()
        {
            InitializeComponent();
        }

        private void frmExpedientes_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");

            cmdBuscar.Click += cmdBuscar_Click;
            cboCitas.SelectedIndexChanged += cboCitas_SelectedIndexChanged;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value.Date;

            string query = @"
            SELECT C.IdCita, C.Fecha, P.IdPaciente, 
                    P.Nombre,
                    P.APaterno,
                    P.AMaterno,
                    P.Genero,
                    P.FechaNac,
                    P.TipoSangre,
                    P.Alergias,
                    P.EnfermedadCronica,
                    C.Hora, 
                    C.Estado AS Edo
            FROM Citas C
            JOIN Pacientes P ON C.IdPaciente = P.IdPaciente
            WHERE C.Fecha = @fecha AND C.Estado = 'R'";

            adapterCitas = new SqlDataAdapter(query, conn);
            adapterCitas.SelectCommand.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

            tablaCitas = new DataTable();
            adapterCitas.Fill(tablaCitas);

            citasBS.DataSource = tablaCitas;
            dgvData.DataSource = citasBS;

            cboCitas.DataSource = citasBS;
            cboCitas.DisplayMember = "IdCita";
            cboCitas.ValueMember = "IdCita";
        }

        private void cboCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cboCitas.SelectedItem;

            int idCita = (int)row["IdCita"];
            int idPaciente = (int)row["IdPaciente"];

            txtIdPaciente.DataBindings.Clear();
            txtNombre.DataBindings.Clear();
            txtAPaterno.DataBindings.Clear();
            txtAMaterno.DataBindings.Clear();
            cboGenero.DataBindings.Clear();
            dtpFechaNacimiento.DataBindings.Clear();
            cboSangre.DataBindings.Clear();
            txtAlergias.DataBindings.Clear();
            txtEnfermedadCronica.DataBindings.Clear();

            txtIdPaciente.DataBindings.Add("Text", citasBS, "IdPaciente");
            txtNombre.DataBindings.Add("Text", citasBS, "Nombre");
            txtAPaterno.DataBindings.Add("Text", citasBS, "APaterno");
            txtAMaterno.DataBindings.Add("Text", citasBS, "AMaterno");
            cboGenero.DataBindings.Add("Text", citasBS, "Genero");
            dtpFechaNacimiento.DataBindings.Add("Value", citasBS, "FechaNac");
            cboSangre.DataBindings.Add("Text", citasBS, "TipoSangre");
            txtAlergias.DataBindings.Add("Text", citasBS, "Alergias");
            txtEnfermedadCronica.DataBindings.Add("Text", citasBS, "EnfermedadCronica");

            string qExp = @"
            SELECT E.IdExpediente AS idExp, E.IdCita, 
                    E.Peso, E.Temperatura AS Temp,
                    E.Estatura AS Est, 
                    E.Sintomas AS Sin, 
                    E.Diagnostico,
                    E.Tratamiento,
                    E.Estudios,
                    E.Presion
            FROM Expedientes E
            WHERE E.IdCita IN (
                SELECT IdCita FROM Citas WHERE IdPaciente = @idPaciente
            )";

            adapterExp = new SqlDataAdapter(qExp, conn);
            adapterExp.SelectCommand.Parameters.AddWithValue("@idPaciente", idPaciente);

            tablaExp = new DataTable();
            adapterExp.Fill(tablaExp);

            expBS.DataSource = tablaExp;
            dgvExpedientes.DataSource = expBS;

            dgvExpedientes.ReadOnly = true;

            expBS.AddNew();

            txtPeso.DataBindings.Clear();
            txtEstatura.DataBindings.Clear();
            txtTemperatura.DataBindings.Clear();
            txtSintomas.DataBindings.Clear();
            txtDiagnostico.DataBindings.Clear();
            txtTratamiento.DataBindings.Clear();
            txtEstudios.DataBindings.Clear();
            txtPresion.DataBindings.Clear();

            txtPeso.DataBindings.Add("Text", expBS, "Peso");
            txtEstatura.DataBindings.Add("Text", expBS, "Est");
            txtTemperatura.DataBindings.Add("Text", expBS, "Temp");
            txtSintomas.DataBindings.Add("Text", expBS, "Sin");
            txtDiagnostico.DataBindings.Add("Text", expBS, "Diagnostico");
            txtTratamiento.DataBindings.Add("Text", expBS, "Tratamiento");
            txtEstudios.DataBindings.Add("Text", expBS, "Estudios");
            txtPresion.DataBindings.Add("Text", expBS, "Presion");
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            int idCita = (int)cboCitas.SelectedValue;

            string insert = @"
            INSERT INTO Expedientes
            (IdCita, Sintomas, Diagnostico, Tratamiento, Estudios, Presion,
                Peso, Estatura, Temperatura)
            VALUES
            (@idCita, @sin, @diag, @trat, @estud, @pres,
                @peso, @est, @temp)";

            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@idCita", idCita);
            cmd.Parameters.AddWithValue("@sin", txtSintomas.Text);
            cmd.Parameters.AddWithValue("@diag", txtDiagnostico.Text);
            cmd.Parameters.AddWithValue("@trat", txtTratamiento.Text);
            cmd.Parameters.AddWithValue("@estud", txtEstudios.Text);
            cmd.Parameters.AddWithValue("@pres", txtPresion.Text);

            decimal peso = decimal.Parse(txtPeso.Text);
            decimal est = decimal.Parse(txtEstatura.Text);
            decimal temp = decimal.Parse(txtTemperatura.Text);

            cmd.Parameters.Add("@peso", SqlDbType.Decimal).Value = peso;
            cmd.Parameters.Add("@est", SqlDbType.Decimal).Value = est;
            cmd.Parameters.Add("@temp", SqlDbType.Decimal).Value = temp;

            conn.Open();
            cmd.ExecuteNonQuery();

            string update = "UPDATE Citas SET Estado = 'A' WHERE IdCita = @idCita";
            SqlCommand cmdUpdate = new SqlCommand(update, conn);
            cmdUpdate.Parameters.AddWithValue("@idCita", idCita);
            cmdUpdate.ExecuteNonQuery();

            conn.Close();

            tablaExp.Clear();
            adapterExp.Fill(tablaExp);

            MessageBox.Show("Expediente registrado. Ejecute nuevamente el formulario si desea refrescar los Datos.");
        }

        private void cmdAtender_Click(object sender, EventArgs e)
        {
            int idCita = (int)cboCitas.SelectedValue;

            string update = "UPDATE Citas SET Estado = 'A' WHERE IdCita = @idCita";
            SqlCommand cmdUpdate = new SqlCommand(update, conn);
            cmdUpdate.Parameters.AddWithValue("@idCita", idCita);

            conn.Open();
            cmdUpdate.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cita finalizada");
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}