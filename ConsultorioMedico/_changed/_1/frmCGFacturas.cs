using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCGFacturas : Form
    {
        private readonly string connectionString =
            "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

        public frmCGFacturas()
        {
            InitializeComponent();
        }

        private void frmCGFacturas_Load(object sender, EventArgs e)
        {
            dgvData.AutoGenerateColumns = true;
            dtpFechaInicial.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = dtpFechaInicial.Value.Date;
            DateTime fechaFinal = dtpFechaFinal.Value.Date.AddDays(1);

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    f.IdFact,
                    c.Fecha,
                    p.Nombre + ' ' + p.APaterno + ' ' + p.AMaterno AS Paciente,
                    cl.NombreContribuyente AS Cliente,
                    cl.RFC,
                    co.TipoPago,
                    co.Monto
                FROM Facturas f
                INNER JOIN Cobros co ON co.IdCobro = f.IdCobro
                INNER JOIN Citas c ON c.IdCita = co.IdCita
                INNER JOIN Pacientes p ON p.IdPaciente = c.IdPaciente
                INNER JOIN Clientes cl ON cl.IdCliente = f.IdCliente
                WHERE c.Fecha >= @FechaInicial AND c.Fecha < @FechaFinal
                ORDER BY c.Fecha
            ", conn))
            {
                da.SelectCommand.Parameters.Add("@FechaInicial", SqlDbType.Date).Value = fechaInicial;
                da.SelectCommand.Parameters.Add("@FechaFinal", SqlDbType.Date).Value = fechaFinal;

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvData.DataSource = dt;
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}