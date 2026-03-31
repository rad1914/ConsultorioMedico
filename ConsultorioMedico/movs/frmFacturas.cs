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

            // LoadCobros INLINE
            cobros = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT IdCobro FROM Cobros WHERE IdCobro NOT IN (SELECT IdCobro FROM Facturas)", conn))
            {
                da.Fill(cobros);
            }
            cboIdCobro.DataSource = cobros;
            cboIdCobro.DisplayMember = "IdCobro";
            cboIdCobro.ValueMember = "IdCobro";

            // LoadClientes INLINE
            clientes = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT IdCliente, NombreContribuyente FROM Clientes", conn))
            {
                da.Fill(clientes);
            }
            cboIdCliente.DataSource = clientes;
            cboIdCliente.DisplayMember = "NombreContribuyente";
            cboIdCliente.ValueMember = "IdCliente";

            // LoadFacturas INLINE
            facturas = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    f.IdFact,
                    f.IdCobro,
                    f.IdCliente,
                    cl.NombreContribuyente,
                    cl.RFC
                FROM Facturas f
                INNER JOIN Clientes cl ON f.IdCliente = cl.IdCliente", conn))
            {
                da.Fill(facturas);
            }

            bs.DataSource = facturas;
            dgvData.DataSource = bs;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (cboIdCobro.SelectedValue == null || cboIdCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione Cobro y Cliente");
                return;
            }

            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Facturas (IdCobro, IdCliente)
                                    VALUES (@IdCobro, @IdCliente)";

                cmd.Parameters.AddWithValue("@IdCobro", cboIdCobro.SelectedValue);
                cmd.Parameters.AddWithValue("@IdCliente", cboIdCliente.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Factura registrada");

            cobros = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT IdCobro FROM Cobros WHERE IdCobro NOT IN (SELECT IdCobro FROM Facturas)", conn))
            {
                da.Fill(cobros);
            }
            cboIdCobro.DataSource = cobros;

            // Reload Facturas
            facturas = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    f.IdFact,
                    f.IdCobro,
                    f.IdCliente,
                    cl.NombreContribuyente,
                    cl.RFC
                FROM Facturas f
                INNER JOIN Clientes cl ON f.IdCliente = cl.IdCliente", conn))
            {
                da.Fill(facturas);
            }

            bs.DataSource = facturas;
            dgvData.DataSource = bs;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cboIdCobro.SelectedIndex = -1;
            cboIdCliente.SelectedIndex = -1;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}