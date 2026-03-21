using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmPacientes : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable tablaPacientes;
        private System.Windows.Forms.BindingSource pacientesBindingSource;

        public frmPacientes()
        {
            InitializeComponent();
            pacientesBindingSource = new BindingSource();
        }
        private void frmPacientes_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT * FROM Pacientes", conn); // IDENTITY ON

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            tablaPacientes = new DataTable();
            adapter.Fill(tablaPacientes);
            tablaPacientes.Columns["idPaciente"].ReadOnly = true;

            pacientesBindingSource.DataSource = tablaPacientes;
            dgvData.DataSource = pacientesBindingSource;

            cboGenero.Items.AddRange(new object[] { "MASCULINO", "FEMENINO", "NO BINARIO" });
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
            txtEnfermedades.DataBindings.Add("Text", pacientesBindingSource, "EnfermedadCronica", true, DataSourceUpdateMode.OnPropertyChanged);
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
            adapter.Update(tablaPacientes);
            tablaPacientes.Clear();
            adapter.Fill(tablaPacientes);

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