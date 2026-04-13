namespace ConsultorioMedico
{
    partial class frmCobros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFecha = new DateTimePicker();
            lblHeader = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblAPaterno = new Label();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            cmdNuevo = new Button();
            lblIdPaciente = new Label();
            txtIdPaciente = new TextBox();
            lblCitaPagar = new Label();
            cboCitaPagar = new ComboBox();
            lblTipoPago = new Label();
            cboTipoPago = new ComboBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            cmdRegistrar = new Button();
            cmdSalir = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            grpDetalle = new GroupBox();
            lblAMaterno = new Label();
            dgvData = new DataGridView();
            cmdBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(389, 36);
            dtpFecha.Margin = new Padding(4, 2, 4, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(186, 23);
            dtpFecha.TabIndex = 140;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblHeader.Location = new Point(70, 29);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(247, 32);
            lblHeader.TabIndex = 222;
            lblHeader.Text = "Gestor de Cobros";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Enabled = false;
            lblNombre.Location = new Point(22, 47);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 12);
            lblNombre.TabIndex = 241;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(107, 39);
            txtNombre.Margin = new Padding(4, 2, 4, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 23);
            txtNombre.TabIndex = 242;
            // 
            // lblAPaterno
            // 
            lblAPaterno.AutoSize = true;
            lblAPaterno.Enabled = false;
            lblAPaterno.Location = new Point(22, 73);
            lblAPaterno.Margin = new Padding(4, 0, 4, 0);
            lblAPaterno.Name = "lblAPaterno";
            lblAPaterno.Size = new Size(74, 12);
            lblAPaterno.TabIndex = 243;
            lblAPaterno.Text = "Ap. Paterno";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Enabled = false;
            txtAPaterno.Location = new Point(107, 65);
            txtAPaterno.Margin = new Padding(4, 2, 4, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(143, 23);
            txtAPaterno.TabIndex = 244;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Enabled = false;
            txtAMaterno.Location = new Point(107, 92);
            txtAMaterno.Margin = new Padding(4, 2, 4, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(144, 23);
            txtAMaterno.TabIndex = 246;
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(171, 284);
            cmdNuevo.Margin = new Padding(4, 2, 4, 2);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(88, 23);
            cmdNuevo.TabIndex = 260;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            cmdNuevo.Click += cmdNuevo_Click;
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Enabled = false;
            lblIdPaciente.Location = new Point(22, 22);
            lblIdPaciente.Margin = new Padding(4, 0, 4, 0);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(69, 12);
            lblIdPaciente.TabIndex = 278;
            lblIdPaciente.Text = "Id Paciente";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new Point(107, 14);
            txtIdPaciente.Margin = new Padding(4, 2, 4, 2);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(55, 23);
            txtIdPaciente.TabIndex = 279;
            // 
            // lblCitaPagar
            // 
            lblCitaPagar.AutoSize = true;
            lblCitaPagar.Location = new Point(75, 213);
            lblCitaPagar.Margin = new Padding(4, 0, 4, 0);
            lblCitaPagar.Name = "lblCitaPagar";
            lblCitaPagar.Size = new Size(75, 12);
            lblCitaPagar.TabIndex = 280;
            lblCitaPagar.Text = "Cita a Pagar";
            // 
            // cboCitaPagar
            // 
            cboCitaPagar.FormattingEnabled = true;
            cboCitaPagar.Location = new Point(171, 209);
            cboCitaPagar.Margin = new Padding(3, 2, 3, 2);
            cboCitaPagar.Name = "cboCitaPagar";
            cboCitaPagar.Size = new Size(186, 20);
            cboCitaPagar.TabIndex = 282;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(76, 236);
            lblTipoPago.Margin = new Padding(4, 0, 4, 0);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(84, 12);
            lblTipoPago.TabIndex = 283;
            lblTipoPago.Text = "Tipo de Pago";
            // 
            // cboTipoPago
            // 
            cboTipoPago.FormattingEnabled = true;
            cboTipoPago.Location = new Point(171, 233);
            cboTipoPago.Margin = new Padding(3, 2, 3, 2);
            cboTipoPago.Name = "cboTipoPago";
            cboTipoPago.Size = new Size(186, 20);
            cboTipoPago.TabIndex = 284;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(79, 264);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(42, 12);
            lblMonto.TabIndex = 285;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(171, 257);
            txtMonto.Margin = new Padding(4, 2, 4, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(187, 23);
            txtMonto.TabIndex = 286;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Enabled = false;
            cmdRegistrar.Location = new Point(267, 284);
            cmdRegistrar.Margin = new Padding(4, 2, 4, 2);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(91, 23);
            cmdRegistrar.TabIndex = 287;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(171, 311);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(187, 23);
            cmdSalir.TabIndex = 289;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 12);
            label1.TabIndex = 290;
            label1.Text = "Sel. Fecha";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-7, -29);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 415);
            dataGridView1.TabIndex = 291;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblAMaterno);
            grpDetalle.Controls.Add(lblIdPaciente);
            grpDetalle.Controls.Add(lblNombre);
            grpDetalle.Controls.Add(txtNombre);
            grpDetalle.Controls.Add(lblAPaterno);
            grpDetalle.Controls.Add(txtAPaterno);
            grpDetalle.Controls.Add(txtAMaterno);
            grpDetalle.Controls.Add(txtIdPaciente);
            grpDetalle.Location = new Point(365, 204);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(279, 130);
            grpDetalle.TabIndex = 292;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle";
            // 
            // lblAMaterno
            // 
            lblAMaterno.AutoSize = true;
            lblAMaterno.Enabled = false;
            lblAMaterno.Location = new Point(22, 103);
            lblAMaterno.Margin = new Padding(4, 0, 4, 0);
            lblAMaterno.Name = "lblAMaterno";
            lblAMaterno.Size = new Size(76, 12);
            lblAMaterno.TabIndex = 280;
            lblAMaterno.Text = "Ap. Materno";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(79, 63);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(565, 136);
            dgvData.TabIndex = 293;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(579, 36);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(66, 24);
            cmdBuscar.TabIndex = 294;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // frmCobros
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 362);
            Controls.Add(cmdBuscar);
            Controls.Add(dgvData);
            Controls.Add(grpDetalle);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(cmdSalir);
            Controls.Add(cmdRegistrar);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(cboTipoPago);
            Controls.Add(lblTipoPago);
            Controls.Add(cboCitaPagar);
            Controls.Add(lblCitaPagar);
            Controls.Add(cmdNuevo);
            Controls.Add(lblHeader);
            Controls.Add(dtpFecha);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCobros";
            Text = "frmCobros";
            Load += frmCobros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Label lblHeader;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblAPaterno;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private Button cmdNuevo;
        private Label lblIdPaciente;
        private TextBox txtIdPaciente;
        private Label lblCitaPagar;
        private ComboBox cboCitaPagar;
        private Label lblTipoPago;
        private ComboBox cboTipoPago;
        private Label lblMonto;
        private TextBox txtMonto;
        private Button cmdRegistrar;
        private Button cmdSalir;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox grpDetalle;
        private Label lblAMaterno;
        private DataGridView dgvData;
        private Button cmdBuscar;
    }
}