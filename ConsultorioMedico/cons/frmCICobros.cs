using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCICobros : Form
    {
        SqlConnection conn;

        public frmCICobros()
        {
            InitializeComponent();

            conn = new SqlConnection(
                "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");
        }

        private void frmCICobros_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT IdCobro
                FROM Cobros
            ", conn);

            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            cboIdCobro.DataSource = dt;
            cboIdCobro.DisplayMember = "IdCobro";
            cboIdCobro.ValueMember = "IdCobro";

            dgvData.AutoGenerateColumns = true;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            int idCobro = Convert.ToInt32(cboIdCobro.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    co.IdCobro,
                    co.TipoPago,
                    co.Monto,

                    c.IdCita,
                    c.Fecha,
                    c.Hora,
                    c.Estado,

                    p.Nombre,
                    p.APaterno,
                    p.AMaterno,
                    p.Telefono,

                    cl.NombreContribuyente,
                    cl.RFC,
                    cl.Email

                FROM Cobros co
                INNER JOIN Citas c ON c.IdCita = co.IdCita
                INNER JOIN Pacientes p ON p.IdPaciente = c.IdPaciente
                LEFT JOIN Facturas f ON f.IdCobro = co.IdCobro
                LEFT JOIN Clientes cl ON cl.IdCliente = f.IdCliente

                WHERE co.IdCobro = @idCobro
            ", conn);

            da.SelectCommand.Parameters.AddWithValue("@idCobro", idCobro);

            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            // Prevent crash if no data
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el cobro.");
                return;
            }

            DataRow row = dt.Rows[0];

            // Cobro
            txtIdCobro.Text = row["IdCobro"].ToString();
            cboTipoPago.Text = row["TipoPago"].ToString();
            txtMonto.Text = row["Monto"].ToString();

            // Cita
            txtIdCita.Text = row["IdCita"].ToString();
            dtpFecha.Text = Convert.ToDateTime(row["Fecha"]).ToShortDateString();
            cboHora.Text = row["Hora"].ToString();

            // Paciente
            txtNombre.Text = row["Nombre"].ToString();
            txtAPaterno.Text = row["APaterno"].ToString();
            txtAMaterno.Text = row["AMaterno"].ToString();
            txtTelefono.Text = row["Telefono"].ToString();

            // Cliente (nullable)
            txtCliente.Text = row["NombreContribuyente"] == DBNull.Value ? "" : row["NombreContribuyente"].ToString();
            txtRfc.Text = row["RFC"] == DBNull.Value ? "" : row["RFC"].ToString();
            txtEmail.Text = row["Email"] == DBNull.Value ? "" : row["Email"].ToString();

            // Grid (optional full view)
            dgvData.DataSource = dt;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}