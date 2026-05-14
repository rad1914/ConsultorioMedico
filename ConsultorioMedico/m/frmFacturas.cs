using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmFacturas : Form
    {
        SqlConnection conn;
        DataTable facturas, citas, clientes;
        BindingSource bs = new BindingSource();

        const string CS = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(CS);

            citas = new DataTable();
            new SqlDataAdapter(
                "SELECT c.IdCita FROM Cobros c WHERE c.IdCobro NOT IN (SELECT IdCobro FROM Facturas)",
                conn).Fill(citas);

            cboIdCita.DataSource = citas;
            cboIdCita.DisplayMember = "IdCita";
            cboIdCita.ValueMember = "IdCita";

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
                    c.IdCita,
                    ci.Fecha,
                    f.IdCliente,
                    cl.NombreContribuyente,
                    cl.RFC
                FROM Facturas f
                INNER JOIN Cobros c ON f.IdCobro = c.IdCobro
                INNER JOIN Citas ci ON c.IdCita = ci.IdCita
                INNER JOIN Clientes cl ON f.IdCliente = cl.IdCliente",
                conn).Fill(facturas);

            bs.DataSource = facturas;
            dgvData.DataSource = bs;

            dgvData.Columns["IdFact"].Visible = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtpFecha.Format = DateTimePickerFormat.Short;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Facturas (IdCobro, IdCliente)
                                VALUES (
                                    (SELECT IdCobro FROM Cobros WHERE IdCita = @IdCita),
                                    @IdCliente
                                )";

            cmd.Parameters.AddWithValue("@IdCita", cboIdCita.SelectedValue);
            cmd.Parameters.AddWithValue("@IdCliente", cboIdCliente.SelectedValue);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Factura registrada");

            citas = new DataTable();
            new SqlDataAdapter(
                "SELECT c.IdCita FROM Cobros c WHERE c.IdCobro NOT IN (SELECT IdCobro FROM Facturas)",
                conn).Fill(citas);

            cboIdCita.DataSource = citas;

            facturas = new DataTable();
            new SqlDataAdapter(@"
                SELECT 
                    f.IdFact,
                    c.IdCita,
                    ci.Fecha,
                    f.IdCliente,
                    cl.NombreContribuyente,
                    cl.RFC
                FROM Facturas f
                INNER JOIN Cobros c ON f.IdCobro = c.IdCobro
                INNER JOIN Citas ci ON c.IdCita = ci.IdCita
                INNER JOIN Clientes cl ON f.IdCliente = cl.IdCliente",
                conn).Fill(facturas);

            bs.DataSource = facturas;
            dgvData.DataSource = bs;

            dgvData.Columns["IdFact"].Visible = false;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cboIdCita.SelectedIndex = -1;
            cboIdCliente.SelectedIndex = -1;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            facturas.Clear();

            string query = @"
                SELECT 
                    f.IdFact,
                    c.IdCita,
                    ci.Fecha,
                    f.IdCliente,
                    cl.NombreContribuyente,
                    cl.RFC
                FROM Facturas f
                INNER JOIN Cobros c ON f.IdCobro = c.IdCobro
                INNER JOIN Citas ci ON c.IdCita = ci.IdCita
                INNER JOIN Clientes cl ON f.IdCliente = cl.IdCliente
                WHERE CAST(ci.Fecha AS DATE) = @fecha";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
            da.Fill(facturas);

            bs.DataSource = facturas;
            dgvData.DataSource = bs;

            dgvData.Columns["IdFact"].Visible = false;

            dgvData.Refresh();
        }

        private void cmdSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}