using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmReportes : Form
    {
        string cs = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

        public frmReportes()
        {
            InitializeComponent();
        }

        string Ask(string msg) => Interaction.InputBox(msg, "Parámetro");

        DateTime AskDate(string msg) => DateTime.Parse(Ask(msg));

        int AskInt(string msg) => int.Parse(Ask(msg));

        void Run(string sp, string title, params SqlParameter[] p)
        {
            var dt = new DataTable();

            using (var da = new SqlDataAdapter(sp, cs))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (p != null) da.SelectCommand.Parameters.AddRange(p);
                da.Fill(dt);
            }

            var rv = new ReportViewer { Dock = DockStyle.Fill };
            rv.LocalReport.LoadReportDefinition(
                new StringReader(new ReportDefinitionBuilder().Build(dt, title))
            );
            rv.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            rv.RefreshReport();

            var form = new Form
            {
                Text = title,
                Width = 1000,
                Height = 450
            };
            form.Controls.Add(rv);
            form.Show();
        }

        void cmdGetClientes_Click(object s, EventArgs e) =>
            Run("sp_GetClientes", "Clientes");

        void cmdGetPacientes_Click(object s, EventArgs e) =>
            Run("sp_GetPacientes", "Pacientes");

        void cmdCitasPorEstadoFecha_Click(object s, EventArgs e) =>
            Run("sp_CitasPorEstadoFecha", "Citas",
                new SqlParameter("@Fecha", AskDate("Fecha")),
                new SqlParameter("@Estado", Ask("Estado")));

        void cmdCobrosPorPeriodo_Click(object s, EventArgs e) =>
            Run("sp_CobrosPorPeriodo", "Cobros",
                new SqlParameter("@FechaInicio", AskDate("Inicio")),
                new SqlParameter("@FechaFin", AskDate("Fin")));

        void cmdFacturasPorPeriodo_Click(object s, EventArgs e) =>
            Run("sp_FacturasPorPeriodo", "Facturas",
                new SqlParameter("@FechaInicio", AskDate("Inicio")),
                new SqlParameter("@FechaFin", AskDate("Fin")));

        void cmdExpedientePorPaciente_Click(object s, EventArgs e) =>
            Run("sp_ExpedientePorPaciente", "Expediente",
                new SqlParameter("@IdPaciente", AskInt("Id")));

        void cmdSalir_Click(object s, EventArgs e) => Close();
    }
}