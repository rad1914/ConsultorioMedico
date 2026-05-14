using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmPacientes : Form
    {
        SqlConnection conn;
        SqlCommand comando;
        DataTable tablaPacientes;
        BindingSource pacientesBindingSource;

        string R = "";

        public frmPacientes()
        {
            InitializeComponent();
            pacientesBindingSource = new BindingSource();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");
            tablaPacientes = new DataTable();

            conn.Open();
            comando = new SqlCommand("SELECT * FROM Pacientes", conn);
            tablaPacientes.Load(comando.ExecuteReader());
            conn.Close();

            pacientesBindingSource.DataSource = tablaPacientes;
            dgvData.DataSource = pacientesBindingSource;

            cboGenero.Items.AddRange(new object[] { "M", "F", "X" });
            cboSangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });

            txtidPaciente.DataBindings.Add("Text", pacientesBindingSource, "idPaciente");
            txtNombre.DataBindings.Add("Text", pacientesBindingSource, "Nombre");
            txtAPaterno.DataBindings.Add("Text", pacientesBindingSource, "APaterno");
            txtAMaterno.DataBindings.Add("Text", pacientesBindingSource, "AMaterno");
            txtTelefono.DataBindings.Add("Text", pacientesBindingSource, "Telefono");
            cboGenero.DataBindings.Add("Text", pacientesBindingSource, "Genero");
            dtpFechaNacimiento.DataBindings.Add("Value", pacientesBindingSource, "FechaNac");
            cboSangre.DataBindings.Add("Text", pacientesBindingSource, "TipoSangre");
            txtAlergias.DataBindings.Add("Text", pacientesBindingSource, "Alergias");
            txtEnfermedadCronica.DataBindings.Add("Text", pacientesBindingSource, "EnfermedadCronica");

            dgvData.Columns["idPaciente"].ReadOnly = true;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtidPaciente.Text = "";
            txtNombre.Text = "";
            txtAPaterno.Text = "";
            txtAMaterno.Text = "";
            txtTelefono.Text = "";
            cboGenero.SelectedIndex = -1;
            cboSangre.SelectedIndex = -1;
            txtAlergias.Text = "";
            txtEnfermedadCronica.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;

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
            conn.Open();

            if (txtidPaciente.Text == "")
            {
                comando = new SqlCommand(
                    "INSERT INTO Pacientes (Nombre, APaterno, AMaterno, Telefono, Genero, FechaNac, TipoSangre, Alergias, EnfermedadCronica) " +
                    "VALUES (@Nombre, @APaterno, @AMaterno, @Telefono, @Genero, @FechaNac, @TipoSangre, @Alergias, @EnfermedadCronica)", conn);
            }
            else
            {
                comando = new SqlCommand(
                    "UPDATE Pacientes SET Nombre=@Nombre, APaterno=@APaterno, AMaterno=@AMaterno, Telefono=@Telefono, Genero=@Genero, " +
                    "FechaNac=@FechaNac, TipoSangre=@TipoSangre, Alergias=@Alergias, EnfermedadCronica=@EnfermedadCronica " +
                    "WHERE idPaciente=@idPaciente", conn);

                comando.Parameters.AddWithValue("@idPaciente", txtidPaciente.Text);
            }

            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@APaterno", txtAPaterno.Text);
            comando.Parameters.AddWithValue("@AMaterno", txtAMaterno.Text);
            comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            comando.Parameters.AddWithValue("@Genero", cboGenero.Text);
            comando.Parameters.AddWithValue("@FechaNac", dtpFechaNacimiento.Value);
            comando.Parameters.AddWithValue("@TipoSangre", cboSangre.Text);
            comando.Parameters.AddWithValue("@Alergias", txtAlergias.Text);
            comando.Parameters.AddWithValue("@EnfermedadCronica", txtEnfermedadCronica.Text);

            comando.ExecuteNonQuery();
            conn.Close();

            tablaPacientes.Clear();

            conn.Open();
            comando = new SqlCommand("SELECT * FROM Pacientes", conn);
            tablaPacientes.Load(comando.ExecuteReader());
            conn.Close();

            MessageBox.Show("Registro Guardado");

            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdModificar.Enabled = true;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                pacientesBindingSource.RemoveFilter();
            else
                pacientesBindingSource.Filter = $"Nombre LIKE '%{txtBuscar.Text}%'";
        }

        private void cmdAnterior_Click(object sender, EventArgs e) => pacientesBindingSource.MovePrevious();
        private void cmdSiguiente_Click(object sender, EventArgs e) => pacientesBindingSource.MoveNext();
        private void cmdUltimo_Click(object sender, EventArgs e) => pacientesBindingSource.MoveLast();
        private void cmdPrimero_Click(object sender, EventArgs e) => pacientesBindingSource.MoveFirst();
        private void cmdSalir_Click(object sender, EventArgs e) => Close();
    }
}