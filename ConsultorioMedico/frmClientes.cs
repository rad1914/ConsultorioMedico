using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmClientes : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable tablaClientes;
        BindingSource clientesBindingSource;

        public frmClientes()
        {
            InitializeComponent();
            clientesBindingSource = new BindingSource();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            string connectionString =
            "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT * FROM Clientes", conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            tablaClientes = new DataTable();
            adapter.Fill(tablaClientes);

            tablaClientes.Columns["IdCliente"].ReadOnly = true;

            clientesBindingSource.DataSource = tablaClientes;
            dgvData.DataSource = clientesBindingSource;

            txtIdCliente.DataBindings.Add("Text", clientesBindingSource, "IdCliente");
            txtRfc.DataBindings.Add("Text", clientesBindingSource, "RFC");
            txtNombre.DataBindings.Add("Text", clientesBindingSource, "NombreContribuyente");
            txtDomicilioFiscal.DataBindings.Add("Text", clientesBindingSource, "DomicilioFiscal");
            txtEmail.DataBindings.Add("Text", clientesBindingSource, "Email");

            dgvData.Columns["IdCliente"].ReadOnly = true;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();

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
            clientesBindingSource.EndEdit();
            adapter.Update(tablaClientes);

            tablaClientes.Clear();
            adapter.Fill(tablaClientes);

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
                clientesBindingSource.RemoveFilter();
                return;
            }

            clientesBindingSource.Filter =
            $"NombreContribuyente LIKE '%{nombre}%'";
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
    }
}