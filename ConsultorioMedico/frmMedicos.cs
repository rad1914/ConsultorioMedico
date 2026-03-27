using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmMedicos : Form
    {
        SqlConnection conn;
        DataTable tablaMedicos;
        BindingSource medicosBindingSource;

        string R = "SELECT * FROM Medicos"; // reusable query

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

            // 🔥 MANUAL LOAD
            using (SqlCommand comando = new SqlCommand(R, conn))
            {
                conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                tablaMedicos.Load(reader);
                conn.Close();
            }

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

            conn.Open();

            foreach (DataRow row in tablaMedicos.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    using (SqlCommand comando = new SqlCommand(
                        "INSERT INTO Medicos (Nombre, CedProfesional, Domicilio) VALUES (@Nombre, @Ced, @Dom)", conn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", row["Nombre"]);
                        comando.Parameters.AddWithValue("@Ced", row["CedProfesional"]);
                        comando.Parameters.AddWithValue("@Dom", row["Domicilio"]);

                        comando.ExecuteNonQuery();
                    }
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    using (SqlCommand comando = new SqlCommand(
                        "UPDATE Medicos SET Nombre=@Nombre, CedProfesional=@Ced, Domicilio=@Dom WHERE IdMedico=@Id", conn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", row["Nombre"]);
                        comando.Parameters.AddWithValue("@Ced", row["CedProfesional"]);
                        comando.Parameters.AddWithValue("@Dom", row["Domicilio"]);
                        comando.Parameters.AddWithValue("@Id", row["IdMedico"]);

                        comando.ExecuteNonQuery();
                    }
                }
            }

            conn.Close();

            // 🔁 Reload manually
            tablaMedicos.Clear();

            using (SqlCommand comando = new SqlCommand(R, conn))
            {
                conn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                tablaMedicos.Load(reader);
                conn.Close();
            }

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