using Microsoft.Reporting.WinForms;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConsultorioMedico
{
    public partial class frmReportes : Form
    {
        string cs = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

        public frmReportes()
        {
            InitializeComponent();
        }

        string Ask(string label, string def = "")
        {
            return Interaction.InputBox(label, "Parámetro", def);
        }

        DateTime AskDate(string label)
        {
            var s = Ask(label, DateTime.Now.ToString("yyyy-MM-dd"));
            if (!DateTime.TryParse(s, out var d))
                throw new Exception($"Fecha inválida: {s}");
            return d;
        }

        int AskInt(string label)
        {
            var s = Ask(label);
            if (!int.TryParse(s, out var i))
                throw new Exception($"Entero inválido: {s}");
            return i;
        }

        private DataTable ToDynamic(DataTable original)
        {
            var dt = new DataTable();
            dt.Columns.Add("Linea", typeof(string));

            if (original == null || original.Rows.Count == 0)
                return dt;

            foreach (DataRow row in original.Rows)
            {
                var parts = new System.Collections.Generic.List<string>();

                foreach (DataColumn col in original.Columns)
                {
                    var val = row[col] == DBNull.Value ? "NULL" : row[col].ToString();
                    parts.Add($"{col.ColumnName}: {val}");
                }

                dt.Rows.Add(string.Join(Environment.NewLine, parts));
            }

            return dt;
        }

        void Run(string sp, params SqlParameter[] p)
        {
            var dt = new DataTable();

            using var da = new SqlDataAdapter(sp, cs);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (p != null) da.SelectCommand.Parameters.AddRange(p);
            da.Fill(dt);

            var dtFinal = ToDynamic(dt);

            var rv = new ReportViewer { Dock = DockStyle.Fill, ProcessingMode = ProcessingMode.Local };

            rv.Reset();

            rv.LocalReport.ReportPath =
                Path.Combine(Application.StartupPath, "Report.rdlc");

            rv.LocalReport.DataSources.Clear();
            rv.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtFinal));
            rv.RefreshReport();

            var win = new Form
            {
                Text = "Reporte",
                Size = new System.Drawing.Size(900, 600),
                StartPosition = FormStartPosition.CenterScreen
            };
            win.Controls.Add(rv);
            win.Show();
        }

        void cmdGetClientes_Click(object s, EventArgs e) => Run("sp_GetClientes");
        void cmdGetPacientes_Click(object s, EventArgs e) => Run("sp_GetPacientes");

        void cmdCitasPorEstadoFecha_Click(object s, EventArgs e) =>
            Run("sp_CitasPorEstadoFecha",
                new SqlParameter("@Estado", Ask("Estado")),
                new SqlParameter("@Fecha", AskDate("Fecha (yyyy-MM-dd)")));

        void cmdCobrosPorPeriodo_Click(object s, EventArgs e) =>
            Run("sp_CobrosPorPeriodo",
                new SqlParameter("@FechaInicio", AskDate("Fecha Inicio")),
                new SqlParameter("@FechaFin", AskDate("Fecha Fin")));

        void cmdFacturasPorPeriodo_Click(object s, EventArgs e) =>
            Run("sp_FacturasPorPeriodo",
                new SqlParameter("@FechaInicio", AskDate("Fecha Inicio")),
                new SqlParameter("@FechaFin", AskDate("Fecha Fin")));

        void cmdExpedientePorPaciente_Click(object s, EventArgs e) =>
            Run("sp_ExpedientePorPaciente",
                new SqlParameter("@IdPaciente", AskInt("IdPaciente")));

        void cmdSalir_Click(object s, EventArgs e) => Close();
    }
}