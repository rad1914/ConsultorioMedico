using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmMedicos : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable tablaMedicos;
        BindingSource medicosBindingSource;

        public frmMedicos()
        {
            InitializeComponent();
            medicosBindingSource = new BindingSource();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            string connectionString =
            "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

            conn = new SqlConnection(connectionString);

            adapter = new SqlDataAdapter("SELECT * FROM Medicos", conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            tablaMedicos = new DataTable();
            adapter.Fill(tablaMedicos);

            tablaMedicos.Columns["IdMedico"].ReadOnly = true;

            medicosBindingSource.DataSource = tablaMedicos;

            dgvData.DataSource = medicosBindingSource;

            txtIdMedico.DataBindings.Add("Text", medicosBindingSource, "IdMedico", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("Text", medicosBindingSource, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCedulaProfesional.DataBindings.Add("Text", medicosBindingSource, "CedProfesional", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDomicilio.DataBindings.Add("Text", medicosBindingSource, "Domicilio", true, DataSourceUpdateMode.OnPropertyChanged);

            dgvData.Columns["IdMedico"].ReadOnly = true;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            medicosBindingSource.AddNew();

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
            medicosBindingSource.EndEdit();

            adapter.Update(tablaMedicos);

            tablaMedicos.Clear();
            adapter.Fill(tablaMedicos);

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
                medicosBindingSource.RemoveFilter();
                return;
            }

            medicosBindingSource.Filter = $"Nombre LIKE '%{nombre}%'";
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
            => medicosBindingSource.MovePrevious();

        private void cmdSiguiente_Click(object sender, EventArgs e)
            => medicosBindingSource.MoveNext();

        private void cmdUltimo_Click(object sender, EventArgs e)
            => medicosBindingSource.MoveLast();

        private void cmdPrimero_Click(object sender, EventArgs e)
            => medicosBindingSource.MoveFirst();

        private void cmdSalir_Click(object sender, EventArgs e)
            => Close();
    }
}