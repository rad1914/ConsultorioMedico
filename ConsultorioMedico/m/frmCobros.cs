using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmCobros : Form
    {
        SqlConnection conn;
        DataTable citas;
        BindingSource bs = new BindingSource();

        const string CS = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sistema;Integrated Security=True;TrustServerCertificate=True;";

        string R = @"SELECT 
                        c.IdCita,
                        c.IdPaciente,
                        p.Nombre,
                        p.APaterno,
                        p.AMaterno,
                        c.Fecha,
                        c.Hora,
                        c.Estado
                     FROM Citas c
                     INNER JOIN Pacientes p ON c.IdPaciente = p.IdPaciente
                     WHERE (c.Estado = 'R' OR c.Estado = 'M')";

        public frmCobros()
        {
            InitializeComponent();
        }

        private void frmCobros_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(CS);

            citas = new DataTable();

            SqlCommand comando = new SqlCommand(R, conn);
            conn.Open();
            citas.Load(comando.ExecuteReader());
            conn.Close();

            bs.DataSource = citas;
            dgvData.DataSource = bs;

            cboCitaPagar.DataSource = bs;
            cboCitaPagar.DisplayMember = "Nombre";
            cboCitaPagar.ValueMember = "IdCita";

            cboTipoPago.Items.AddRange(new object[] { "EFECTIVO", "TARJETA", "TRANSFERENCIA" });

            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtpFecha.Format = DateTimePickerFormat.Short;

            txtIdPaciente.DataBindings.Clear();
            txtNombre.DataBindings.Clear();
            txtAPaterno.DataBindings.Clear();
            txtAMaterno.DataBindings.Clear();

            txtIdPaciente.DataBindings.Add("Text", bs, "IdPaciente");
            txtNombre.DataBindings.Add("Text", bs, "Nombre");
            txtAPaterno.DataBindings.Add("Text", bs, "APaterno");
            txtAMaterno.DataBindings.Add("Text", bs, "AMaterno");
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            citas.Clear();

            string query = R + " AND CAST(c.Fecha AS DATE) = @f";
            SqlCommand comando = new SqlCommand(query, conn);
            comando.Parameters.AddWithValue("@f", dtpFecha.Value.Date);

            conn.Open();
            citas.Load(comando.ExecuteReader());
            conn.Close();

            if (citas.Rows.Count == 0)
            {
                MessageBox.Show("No hay citas en esa fecha.");
            }

            bs.DataSource = citas;
            cboCitaPagar.DataSource = bs;

            dgvData.DataSource = bs;
            dgvData.Refresh();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cboCitaPagar.SelectedIndex = -1;
            cboTipoPago.SelectedIndex = -1;

            cmdRegistrar.Enabled = true;
            cboCitaPagar.Enabled = true;
            cboTipoPago.Enabled = true;
            txtMonto.Enabled = true;
            cmdNuevo.Enabled = false;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (cboCitaPagar.SelectedIndex == -1 || cboTipoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona cita y tipo de pago.");
                return;
            }

            SqlCommand comando = conn.CreateCommand();

            comando.CommandText =
            @"IF NOT EXISTS (SELECT 1 FROM Cobros WHERE IdCita = @IdCita)
      BEGIN
          INSERT INTO Cobros (IdCita, TipoPago, Monto)
          VALUES (@IdCita, @TipoPago, @Monto);

          UPDATE Citas SET Estado='P' WHERE IdCita=@IdCita;
      END
      ELSE
      BEGIN
          SELECT -1;
      END";

            comando.Parameters.AddWithValue("@IdCita", cboCitaPagar.SelectedValue);
            comando.Parameters.AddWithValue("@TipoPago", cboTipoPago.Text);
            comando.Parameters.AddWithValue("@Monto", decimal.Parse(txtMonto.Text));

            conn.Open();
            object result = comando.ExecuteScalar();
            conn.Close();

            if (result != null && result.ToString() == "-1")
            {
                MessageBox.Show("Esta cita ya fue cobrada.");
                return;
            }

            citas.Clear();

            comando = new SqlCommand(R, conn);
            conn.Open();
            citas.Load(comando.ExecuteReader());
            conn.Close();

            bs.DataSource = citas;
            cboCitaPagar.DataSource = bs;
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}