using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCitas : Form
    {
        SqlConnection conn;
        DataTable citas, pacientes;
        BindingSource bs = new BindingSource();

        const string CS = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";
        string R = @"SELECT 
                    c.IdCita,
                    c.IdPaciente,
                    c.IdMedico,
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
            citas = new DataTable();

            SqlCommand comando = new SqlCommand(R, conn);
            conn.Open();
            SqlDataReader reader = comando.ExecuteReader();
            citas.Load(reader);
            conn.Close();

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

            pacientes = new DataTable();
            comando = new SqlCommand(@"
                 SELECT 
                     IdPaciente,
                     CONCAT(Nombre, ' ', APaterno, ' ', AMaterno) AS NombreCompleto
                 FROM Pacientes", conn);

            conn.Open();
            reader = comando.ExecuteReader();
            pacientes.Load(reader);
            conn.Close();

            cboPaciente.DataSource = pacientes;
            cboPaciente.DisplayMember = "NombreCompleto";
            cboPaciente.ValueMember = "IdPaciente";

            DataTable medicos = new DataTable();
            comando = new SqlCommand("SELECT IdMedico,Nombre FROM Medicos", conn);

            conn.Open();
            reader = comando.ExecuteReader();
            medicos.Load(reader);
            conn.Close();

            cboMedico.DataSource = medicos;
            cboMedico.DisplayMember = "Nombre";
            cboMedico.ValueMember = "IdMedico";
        }

        void cmdBuscar_Click(object s, EventArgs e)
        {
            citas.Clear();

            cboHora.Enabled = true;
            cboMedico.Enabled = true;
            cboPaciente.Enabled = true;

            SqlCommand comando = new SqlCommand(R + " WHERE c.Fecha=@f", conn);
            comando.Parameters.AddWithValue("@f", dtpFecha.Value.Date);

            conn.Open();
            SqlDataReader reader = comando.ExecuteReader();
            citas.Load(reader);
            conn.Close();

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
            SqlCommand comando = conn.CreateCommand();

            comando.CommandText =
            "INSERT INTO Citas (IdPaciente,IdMedico,Fecha,Hora,Estado) VALUES(@IdPaciente,@IdMedico,@Fecha,@Hora,'R')";

            comando.Parameters.AddWithValue("@IdPaciente", cboPaciente.SelectedValue);
            comando.Parameters.AddWithValue("@IdMedico", cboMedico.SelectedValue);
            comando.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
            comando.Parameters.AddWithValue("@Hora", TimeSpan.Parse(cboHora.Text));

            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();

            citas.Clear();
            comando = new SqlCommand(R, conn);

            conn.Open();
            SqlDataReader reader = comando.ExecuteReader();
            citas.Load(reader);
            conn.Close();
        }

        void cmdCancelar_Click(object s, EventArgs e)
        {
            dgvData.EndEdit();
            bs.EndEdit();

            foreach (DataRow row in citas.Rows)
            {
                if (row.RowState == DataRowState.Modified)
                {
                    SqlCommand comando = conn.CreateCommand();

                    comando.CommandText = @"UPDATE Citas 
                                           SET Estado=@Estado 
                                           WHERE IdCita=@IdCita";

                    comando.Parameters.AddWithValue("@Estado", row["Estado"]);
                    comando.Parameters.AddWithValue("@IdCita", row["IdCita"]);

                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}