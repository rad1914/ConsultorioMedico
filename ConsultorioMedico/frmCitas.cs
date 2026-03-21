using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCitas : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable citas, pacientes;
        BindingSource bs = new BindingSource();

        const string CS = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";
        const string Q = @"SELECT 
                   c.IdCita,
                   c.IdPaciente,
                   c.Fecha,
                   c.Hora,
                   p.Nombre,
                   p.Telefono,
                   c.Estado
                   FROM Citas c 
                   INNER JOIN Pacientes p ON c.IdPaciente=p.IdPaciente";

        public frmCitas() { InitializeComponent(); }

        void frmCitas_Load(object s, EventArgs e)
        {
            conn = new SqlConnection(CS);
            adapter = new SqlDataAdapter(Q, conn);
            citas = new DataTable();
            adapter.Fill(citas);

            bs.DataSource = citas;
            dgvData.DataSource = bs;
            dgvData.Columns["Telefono"].Visible = false;
            citas.Columns["IdCita"].ReadOnly = true;
            dgvData.Columns["IdPaciente"].ReadOnly = true;

            dgvData.CellFormatting += (s2, e2) =>
            {
                if (dgvData.Columns[e2.ColumnIndex].Name == "Hora" && e2.Value != null)
                    e2.Value = ((TimeSpan)e2.Value).ToString(@"hh\:mm");
            };

            txtIdPaciente.DataBindings.Add("Text", bs, "IdPaciente", true, DataSourceUpdateMode.Never);
            txtTelefono.DataBindings.Add("Text", bs, "Telefono", true, DataSourceUpdateMode.Never);

            var daPac = new SqlDataAdapter("SELECT IdPaciente,Nombre FROM Pacientes", conn);
            pacientes = new DataTable();
            daPac.Fill(pacientes);

            cboPaciente.DataSource = pacientes;
            cboPaciente.DisplayMember = "Nombre";
            cboPaciente.ValueMember = "IdPaciente";

            adapter.InsertCommand = new SqlCommand("INSERT INTO Citas(IdPaciente,Fecha,Hora,Estado) VALUES(@IdPaciente,@Fecha,@Hora,@Estado)", conn);

            adapter.InsertCommand.Parameters.Add("@IdPaciente", SqlDbType.Int, 0, "IdPaciente");
            adapter.InsertCommand.Parameters.Add("@Fecha", SqlDbType.Date, 0, "Fecha");
            adapter.InsertCommand.Parameters.Add("@Hora", SqlDbType.Time, 0, "Hora");
            adapter.InsertCommand.Parameters.Add("@Estado", SqlDbType.Char, 1, "Estado");

            adapter.UpdateCommand = new SqlCommand(@"UPDATE Citas SET IdPaciente=@IdPaciente,Fecha=@Fecha,Hora=@Hora,Estado=@Estado WHERE IdCita=@IdCita", conn);

            adapter.UpdateCommand.Parameters.Add("@IdPaciente", SqlDbType.Int, 0, "IdPaciente");
            adapter.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.Date, 0, "Fecha");
            adapter.UpdateCommand.Parameters.Add("@Hora", SqlDbType.Time, 0, "Hora");
            adapter.UpdateCommand.Parameters.Add("@Estado", SqlDbType.Char, 1, "Estado");
            adapter.UpdateCommand.Parameters.Add("@IdCita", SqlDbType.Int, 0, "IdCita");
        }

        void cmdBuscar_Click(object s, EventArgs e)
        {
            adapter.SelectCommand.CommandText = Q + " WHERE c.Fecha=@f";
            adapter.SelectCommand.Parameters.Clear();
            adapter.SelectCommand.Parameters.AddWithValue("@f", dtpFecha.Value.Date);

            citas.Clear();
            adapter.Fill(citas);
            cboHora.Items.Clear();

            for (int i = 12; i <= 20; i++)
                cboHora.Items.Add(i.ToString("00") + ":00");

            foreach (DataRow r in citas.Rows)
            {
                if (r["Estado"].ToString().Trim() == "R")
                {
                    int h = ((TimeSpan)r["Hora"]).Hours;
                    cboHora.Items.Remove(h.ToString("00") + ":00");
                }
            }
        }

        void cmdRegistrar_Click(object s, EventArgs e)
        {
            if (cboPaciente.SelectedValue == null || string.IsNullOrWhiteSpace(cboHora.Text))
            {
                MessageBox.Show("Seleccione paciente y hora");
                return;
            }

            SqlCommand comando = conn.CreateCommand();

            comando.CommandText =
            "INSERT INTO Citas (IdPaciente,Fecha,Hora,Estado) VALUES(@IdPaciente,@Fecha,@Hora,'R')";

            comando.Parameters.AddWithValue("@IdPaciente", cboPaciente.SelectedValue);
            comando.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);

            TimeSpan hora = TimeSpan.Parse(cboHora.Text);
            comando.Parameters.AddWithValue("@Hora", hora);

            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cita registrada");

            citas.Clear();
            adapter.SelectCommand.CommandText = Q;
            adapter.SelectCommand.Parameters.Clear();
            adapter.Fill(citas);
        }

        void cmdCancelar_Click(object s, EventArgs e)
        {
            if (dgvData.CurrentRow != null)
                dgvData.CurrentRow.Cells["Estado"].Value = "C";

            dgvData.EndEdit(); bs.EndEdit();
            adapter.Update(citas);

            MessageBox.Show("Cita cancelada");
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}