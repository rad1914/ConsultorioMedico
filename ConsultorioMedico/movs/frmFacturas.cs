using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmFacturas : Form
    {
        SqlConnection conn;
        DataTable facturas, cobros, clientes;
        BindingSource bs = new BindingSource();

        const string CS = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(CS);

            cobros = new DataTable();
            new SqlDataAdapter(
                "SELECT IdCobro FROM Cobros WHERE IdCobro NOT IN (SELECT IdCobro FROM Facturas)",
                conn).Fill(cobros);

            cboIdCobro.DataSource = cobros;
            cboIdCobro.DisplayMember = "IdCobro";
            cboIdCobro.ValueMember = "IdCobro";

            clientes = new DataTable();
            new SqlDataAdapter(
                "SELECT IdCliente, NombreContribuyente FROM Clientes",
                conn).Fill(clientes);

            cboIdCliente.DataSource = clientes;
            cboIdCliente.DisplayMember = "NombreContribuyente";
            cboIdCliente.ValueMember = "IdCliente";

            facturas = new DataTable();
            new SqlDataAdapter(@"
                SELECT 
                    f.IdFact,
                    f.IdCobro,
                    f.IdCliente,
                    cl.NombreContribuyente,
                    cl.RFC
                FROM Facturas f
                INNER JOIN Clientes cl ON f.IdCliente = cl.IdCliente",
                conn).Fill(facturas);

            bs.DataSource = facturas;
            dgvData.DataSource = bs;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Facturas (IdCobro, IdCliente)
                                VALUES (@IdCobro, @IdCliente)";

            cmd.Parameters.AddWithValue("@IdCobro", cboIdCobro.SelectedValue);
            cmd.Parameters.AddWithValue("@IdCliente", cboIdCliente.SelectedValue);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Factura registrada");

            cobros = new DataTable();
            new SqlDataAdapter(
                "SELECT IdCobro FROM Cobros WHERE IdCobro NOT IN (SELECT IdCobro FROM Facturas)",
                conn).Fill(cobros);

            cboIdCobro.DataSource = cobros;

            facturas = new DataTable();
            new SqlDataAdapter(@"
                SELECT 
                    f.IdFact,
                    f.IdCobro,
                    f.IdCliente,
                    cl.NombreContribuyente,
                    cl.RFC
                FROM Facturas f
                INNER JOIN Clientes cl ON f.IdCliente = cl.IdCliente",
                conn).Fill(facturas);

            bs.DataSource = facturas;
            dgvData.DataSource = bs;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cboIdCobro.SelectedIndex = -1;
            cboIdCliente.SelectedIndex = -1;
        }

        private void cmdSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}