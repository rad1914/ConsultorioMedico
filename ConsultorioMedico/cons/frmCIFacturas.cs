using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCIFacturas : Form
    {
        SqlConnection conn;

        public frmCIFacturas()
        {
            InitializeComponent();

            conn = new SqlConnection(
                "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");
        }

        private void frmCIFacturas_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT IdFact FROM Facturas", conn);
            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            cboIdFactura.DataSource = dt;
            cboIdFactura.DisplayMember = "IdFact";
            cboIdFactura.ValueMember = "IdFact";

            dgvData.AutoGenerateColumns = true;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            int idFactura = Convert.ToInt32(cboIdFactura.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    f.IdFact,
                    c.IdCobro,
                    c.TipoPago,
                    c.Monto,
                    cl.IdCliente,
                    cl.RFC,
                    cl.NombreContribuyente,
                    cl.DomicilioFiscal,
                    cl.Email,
                    ci.IdCita,
                    p.Nombre,
                    p.APaterno,
                    p.AMaterno,
                    p.Telefono
                FROM Facturas f
                INNER JOIN Cobros c ON c.IdCobro = f.IdCobro
                INNER JOIN Clientes cl ON cl.IdCliente = f.IdCliente
                INNER JOIN Citas ci ON ci.IdCita = c.IdCita
                INNER JOIN Pacientes p ON p.IdPaciente = ci.IdPaciente
                WHERE f.IdFact = @idFactura
            ", conn);

            da.SelectCommand.Parameters.AddWithValue("@idFactura", idFactura);

            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            DataRow row = dt.Rows[0];

            txtCliente.Text = row["NombreContribuyente"].ToString();
            txtRfc.Text = row["RFC"].ToString();
            txtEmail.Text = row["Email"].ToString();
            txtDomicilio.Text = row["DomicilioFiscal"].ToString();

            txtPaciente.Text = row["Nombre"].ToString() + " " +
                               row["APaterno"].ToString() + " " +
                               row["AMaterno"].ToString();
            txtTelefono.Text = row["Telefono"].ToString();

            txtMonto.Text = row["Monto"].ToString();
            cboTipoPago.Text = row["TipoPago"].ToString();

            dgvData.DataSource = dt;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}