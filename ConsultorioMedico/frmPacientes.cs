using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmPacientes : Form
    {
        SqlConnection conn;
        DataTable tablaPacientes;
        BindingSource pacientesBindingSource;

        string R = "SELECT * FROM Pacientes"; // reusable query

        public frmPacientes()
        {
            InitializeComponent();
            pacientesBindingSource = new BindingSource();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";
            conn = new SqlConnection(connectionString);

            tablaPacientes = new DataTable();

            conn.Open();
            SqlCommand comando = new SqlCommand(R, conn);
            SqlDataReader reader = comando.ExecuteReader();
            tablaPacientes.Load(reader);
            conn.Close();

            tablaPacientes.Columns["idPaciente"].ReadOnly = true;

            pacientesBindingSource.DataSource = tablaPacientes;
            dgvData.DataSource = pacientesBindingSource;

            cboGenero.Items.AddRange(new object[] { "M", "F", "X" });
            cboSangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });

            txtidPaciente.DataBindings.Add("Text", pacientesBindingSource, "idPaciente", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("Text", pacientesBindingSource, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAPaterno.DataBindings.Add("Text", pacientesBindingSource, "APaterno", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAMaterno.DataBindings.Add("Text", pacientesBindingSource, "AMaterno", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefono.DataBindings.Add("Text", pacientesBindingSource, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGenero.DataBindings.Add("Text", pacientesBindingSource, "Genero", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpFechaNacimiento.DataBindings.Add("Value", pacientesBindingSource, "FechaNac", true, DataSourceUpdateMode.OnPropertyChanged);
            cboSangre.DataBindings.Add("Text", pacientesBindingSource, "TipoSangre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAlergias.DataBindings.Add("Text", pacientesBindingSource, "Alergias", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEnfermedadCronica.DataBindings.Add("Text", pacientesBindingSource, "EnfermedadCronica", true, DataSourceUpdateMode.OnPropertyChanged);

            dgvData.Columns["idPaciente"].ReadOnly = true;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.AddNew();
            cmdNuevo.Enabled = false;
            cmdGrabar.Enabled = true;
            cmdModificar.Enabled = false;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            cmdModificar.Enabled = false;
            cmdGrabar.Enabled = true;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.EndEdit();

            conn.Open();

            foreach (DataRow row in tablaPacientes.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    SqlCommand comando = new SqlCommand(
                        @"INSERT INTO Pacientes 
                        (Nombre, APaterno, AMaterno, Telefono, Genero, FechaNac, TipoSangre, Alergias, EnfermedadCronica)
                        VALUES 
                        (@Nombre, @APaterno, @AMaterno, @Telefono, @Genero, @FechaNac, @TipoSangre, @Alergias, @EnfermedadCronica)", conn);

                    comando.Parameters.AddWithValue("@Nombre", row["Nombre"]);
                    comando.Parameters.AddWithValue("@APaterno", row["APaterno"]);
                    comando.Parameters.AddWithValue("@AMaterno", row["AMaterno"]);
                    comando.Parameters.AddWithValue("@Telefono", row["Telefono"]);
                    comando.Parameters.AddWithValue("@Genero", row["Genero"]);
                    comando.Parameters.AddWithValue("@FechaNac", row["FechaNac"]);
                    comando.Parameters.AddWithValue("@TipoSangre", row["TipoSangre"]);
                    comando.Parameters.AddWithValue("@Alergias", row["Alergias"]);
                    comando.Parameters.AddWithValue("@EnfermedadCronica", row["EnfermedadCronica"]);

                    comando.ExecuteNonQuery();
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    SqlCommand comando = new SqlCommand(
                        @"UPDATE Pacientes SET
                        Nombre=@Nombre,
                        APaterno=@APaterno,
                        AMaterno=@AMaterno,
                        Telefono=@Telefono,
                        Genero=@Genero,
                        FechaNac=@FechaNac,
                        TipoSangre=@TipoSangre,
                        Alergias=@Alergias,
                        EnfermedadCronica=@EnfermedadCronica
                        WHERE idPaciente=@idPaciente", conn);

                    comando.Parameters.AddWithValue("@idPaciente", row["idPaciente"]);
                    comando.Parameters.AddWithValue("@Nombre", row["Nombre"]);
                    comando.Parameters.AddWithValue("@APaterno", row["APaterno"]);
                    comando.Parameters.AddWithValue("@AMaterno", row["AMaterno"]);
                    comando.Parameters.AddWithValue("@Telefono", row["Telefono"]);
                    comando.Parameters.AddWithValue("@Genero", row["Genero"]);
                    comando.Parameters.AddWithValue("@FechaNac", row["FechaNac"]);
                    comando.Parameters.AddWithValue("@TipoSangre", row["TipoSangre"]);
                    comando.Parameters.AddWithValue("@Alergias", row["Alergias"]);
                    comando.Parameters.AddWithValue("@EnfermedadCronica", row["EnfermedadCronica"]);

                    comando.ExecuteNonQuery();
                }
            }

            conn.Close();

            tablaPacientes.Clear();

            conn.Open();
            SqlCommand reload = new SqlCommand(R, conn);
            SqlDataReader reader = reload.ExecuteReader();
            tablaPacientes.Load(reader);
            conn.Close();

            MessageBox.Show("Registro Guardado");

            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdModificar.Enabled = true;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                pacientesBindingSource.RemoveFilter();
                return;
            }

            pacientesBindingSource.Filter = $"Nombre LIKE '%{nombre}%'";
        }

        private void cmdAnterior_Click(object sender, EventArgs e) => pacientesBindingSource.MovePrevious();
        private void cmdSiguiente_Click(object sender, EventArgs e) => pacientesBindingSource.MoveNext();
        private void cmdUltimo_Click(object sender, EventArgs e) => pacientesBindingSource.MoveLast();
        private void cmdPrimero_Click(object sender, EventArgs e) => pacientesBindingSource.MoveFirst();
        private void cmdSalir_Click(object sender, EventArgs e) => Close();
    }
}