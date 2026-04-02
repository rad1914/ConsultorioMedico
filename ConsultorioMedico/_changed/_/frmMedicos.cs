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
            conn = new SqlConnection("Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");
            tablaMedicos = new DataTable();

            conn.Open();
            comando = new SqlCommand("SELECT * FROM Medicos", conn);
            tablaMedicos.Load(comando.ExecuteReader());
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

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtIdMedico.Clear();
            txtNombre.Clear();
            txtCedulaProfesional.Clear();
            txtDomicilio.Clear();

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

            if (txtIdMedico.Text == "")
            {
                comando = new SqlCommand(
                    "INSERT INTO Medicos (Nombre, CedProfesional, Domicilio) VALUES (@Nombre, @CedProfesional, @Domicilio)",
                    conn);
            }
            else
            {
                comando = new SqlCommand(
                    "UPDATE Medicos SET Nombre=@Nombre, CedProfesional=@CedProfesional, Domicilio=@Domicilio WHERE IdMedico=@IdMedico",
                    conn);

                comando.Parameters.AddWithValue("@IdMedico", txtIdMedico.Text);
            }

            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@CedProfesional", txtCedulaProfesional.Text);
            comando.Parameters.AddWithValue("@Domicilio", txtDomicilio.Text);

            comando.ExecuteNonQuery();
            conn.Close();

            tablaMedicos.Clear();

            conn.Open();
            comando = new SqlCommand("SELECT * FROM Medicos", conn);
            tablaMedicos.Load(comando.ExecuteReader());
            conn.Close();

            cmdNuevo.Enabled = true;
            cmdGrabar.Enabled = false;
            cmdModificar.Enabled = true;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                medicosBindingSource.RemoveFilter();
            else
                medicosBindingSource.Filter = $"Nombre LIKE '%{txtBuscar.Text}%'";
        }

        private void cmdAnterior_Click(object sender, EventArgs e) => medicosBindingSource.MovePrevious();
        private void cmdSiguiente_Click(object sender, EventArgs e) => medicosBindingSource.MoveNext();
        private void cmdUltimo_Click(object sender, EventArgs e) => medicosBindingSource.MoveLast();
        private void cmdPrimero_Click(object sender, EventArgs e) => medicosBindingSource.MoveFirst();
        private void cmdSalir_Click(object sender, EventArgs e) => Close();
    }
}