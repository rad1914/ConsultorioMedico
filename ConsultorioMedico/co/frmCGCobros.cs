using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCGCobros : Form
    {
        SqlConnection conn = new SqlConnection(
            "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;");

        public frmCGCobros()
        {
            InitializeComponent();
        }

        private void frmCICobros_Load(object sender, EventArgs e)
        {
            dgvData.AutoGenerateColumns = true;
            dtpFechaInicial.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;
        }

        private void cmdBuscar_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    c.IdCita,
                    c.Fecha,
                    p.Nombre,
                    p.APaterno,
                    p.AMaterno,
                    co.IdCobro,
                    co.TipoPago,
                    co.Monto
                FROM Cobros co
                INNER JOIN Citas c ON c.IdCita = co.IdCita
                INNER JOIN Pacientes p ON p.IdPaciente = c.IdPaciente
                WHERE c.Fecha BETWEEN @FechaInicial AND @FechaFinal
                ORDER BY c.Fecha
            ", conn);

            da.SelectCommand.Parameters.AddWithValue("@FechaInicial", dtpFechaInicial.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@FechaFinal", dtpFechaFinal.Value.Date);

            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            dgvData.DataSource = dt;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}