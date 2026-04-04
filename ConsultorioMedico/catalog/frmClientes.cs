using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmClientes : Form
    {
        SqlConnection conn;
        DataTable tablaClientes = new DataTable();
        BindingSource clientesBindingSource = new BindingSource();

        string connectionString =
        "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);

            conn.Open();
            new SqlDataAdapter("SELECT * FROM Clientes", conn).Fill(tablaClientes);
            conn.Close();

            clientesBindingSource.DataSource = tablaClientes;
            dgvData.DataSource = clientesBindingSource;

            txtIdCliente.DataBindings.Add("Text", clientesBindingSource, "IdCliente");
            txtRfc.DataBindings.Add("Text", clientesBindingSource, "RFC");
            txtNombre.DataBindings.Add("Text", clientesBindingSource, "NombreContribuyente");
            txtDomicilioFiscal.DataBindings.Add("Text", clientesBindingSource, "DomicilioFiscal");
            txtEmail.DataBindings.Add("Text", clientesBindingSource, "Email");
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();

            conn.Open();

            foreach (DataRow row in tablaClientes.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    new SqlCommand(
                        "INSERT INTO Clientes (RFC, NombreContribuyente, DomicilioFiscal, Email) " +
                        "VALUES (@RFC, @Nombre, @Domicilio, @Email)", conn)
                    {
                        Parameters =
                        {
                            new SqlParameter("@RFC", row["RFC"]),
                            new SqlParameter("@Nombre", row["NombreContribuyente"]),
                            new SqlParameter("@Domicilio", row["DomicilioFiscal"]),
                            new SqlParameter("@Email", row["Email"])
                        }
                    }.ExecuteNonQuery();
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    new SqlCommand(
                        "UPDATE Clientes SET RFC=@RFC, NombreContribuyente=@Nombre, " +
                        "DomicilioFiscal=@Domicilio, Email=@Email WHERE IdCliente=@Id", conn)
                    {
                        Parameters =
                        {
                            new SqlParameter("@RFC", row["RFC"]),
                            new SqlParameter("@Nombre", row["NombreContribuyente"]),
                            new SqlParameter("@Domicilio", row["DomicilioFiscal"]),
                            new SqlParameter("@Email", row["Email"]),
                            new SqlParameter("@Id", row["IdCliente"])
                        }
                    }.ExecuteNonQuery();
                }
            }

            conn.Close();

            tablaClientes.Clear();

            conn.Open();
            new SqlDataAdapter("SELECT * FROM Clientes", conn).Fill(tablaClientes);
            conn.Close();

            MessageBox.Show("Guardado");
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.Filter =
            $"NombreContribuyente LIKE '%{txtBuscar.Text}%'";
        }

        private void cmdAnterior_Click(object sender, EventArgs e) =>
            clientesBindingSource.MovePrevious();

        private void cmdSiguiente_Click(object sender, EventArgs e) =>
            clientesBindingSource.MoveNext();

        private void cmdUltimo_Click(object sender, EventArgs e) =>
            clientesBindingSource.MoveLast();

        private void cmdPrimero_Click(object sender, EventArgs e) =>
            clientesBindingSource.MoveFirst();

        private void cmdSalir_Click(object sender, EventArgs e) => Close();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}