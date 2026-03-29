using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmMedicos : Form
    {
        SqlConnection conn;
        SqlCommand comando;
        DataTable tablaMedicos;
        BindingSource medicosBindingSource;

        string R = "";

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

            tablaMedicos = new DataTable();

            conn.Open();
            R = "SELECT * FROM Medicos";
            comando = new SqlCommand(R, conn);

            SqlDataReader reader = comando.ExecuteReader();
            tablaMedicos.Load(reader);
            conn.Close();

            medicosBindingSource.DataSource = tablaMedicos;
            dgvData.DataSource = medicosBindingSource;

            txtIdMedico.DataBindings.Add("Text", medicosBindingSource, "IdMedico");
            txtNombre.DataBindings.Add("Text", medicosBindingSource, "Nombre");
            txtCedulaProfesional.DataBindings.Add("Text", medicosBindingSource, "CedProfesional");
            txtDomicilio.DataBindings.Add("Text", medicosBindingSource, "Domicilio");
            txtTelefono.DataBindings.Add("Text", medicosBindingSource, "Telefono");

            dgvData.Columns["IdMedico"].ReadOnly = true;
        }

        private void cmdNuevo_Click_1(object sender, EventArgs e)
        {
            txtIdMedico.Clear();
            txtNombre.Clear();
            txtCedulaProfesional.Clear();
            txtDomicilio.Clear();

            cmdNuevo.Enabled = false;
            cmdGrabar.Enabled = true;
            cmdModificar.Enabled = false;
        }

        private void cmdModificar_Click_1(object sender, EventArgs e)
        {
            cmdModificar.Enabled = false;
            cmdGrabar.Enabled = true;
        }

        private void cmdGrabar_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            if (string.IsNullOrEmpty(txtIdMedico.Text))
            {
                // INSERT
                R = "INSERT INTO Medicos (Nombre, CedProfesional, Domicilio) " +
                    "VALUES (@Nombre, @CedProfesional, @Domicilio)";
            }
            else
            {
                // UPDATE
                R = "UPDATE Medicos SET " +
                    "Nombre=@Nombre, CedProfesional=@CedProfesional, Domicilio=@Domicilio " +
                    "WHERE IdMedico=@IdMedico";
            }

            comando = new SqlCommand(R, conn);

            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@CedProfesional", txtCedulaProfesional.Text);
            comando.Parameters.AddWithValue("@Domicilio", txtDomicilio.Text);

            if (!string.IsNullOrEmpty(txtIdMedico.Text))
            {
                comando.Parameters.AddWithValue("@IdMedico", txtIdMedico.Text);
            }

            comando.ExecuteNonQuery();
            conn.Close();


            tablaMedicos.Clear();

            conn.Open();
            R = "SELECT * FROM Medicos";
            comando = new SqlCommand(R, conn);
            SqlDataReader reader = comando.ExecuteReader();
            tablaMedicos.Load(reader);
            conn.Close();

            MessageBox.Show("Registro Guardado");

            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdModificar.Enabled = true;
        }

        private void cmdBuscar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                medicosBindingSource.RemoveFilter();
                return;
            }

            medicosBindingSource.Filter = $"Nombre LIKE '%{nombre}%'";
        }

        private void cmdAnterior_Click_1(object sender, EventArgs e) => medicosBindingSource.MovePrevious();
        private void cmdSiguiente_Click_1(object sender, EventArgs e) => medicosBindingSource.MoveNext();
        private void cmdUltimo_Click_1(object sender, EventArgs e) => medicosBindingSource.MoveLast();
        private void cmdPrimero_Click_1(object sender, EventArgs e) => medicosBindingSource.MoveFirst();
        private void cmdSalir_Click_1(object sender, EventArgs e) => Close();
    }
}