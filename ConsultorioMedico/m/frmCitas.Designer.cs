namespace ConsultorioMedico
{
    partial class frmCitas
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
            cboHora = new ComboBox();
            cboPaciente = new ComboBox();
            cmdCancelar = new Button();
            lblSeleccionarPaciente = new Label();
            lblSeleccionarHora = new Label();
            cmdBuscar = new Button();
            dtpFecha = new DateTimePicker();
            lblHeader = new Label();
            dgvData = new DataGridView();
            cmdRegistrar = new Button();
            lblFecha = new Label();
            txtTelefono = new MaskedTextBox();
            lblTelefono = new Label();
            lblIdCita = new Label();
            txtIdPaciente = new TextBox();
            cboMedico = new ComboBox();
            lblMedico = new Label();
            dataGridView1 = new DataGridView();
            cmdSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cboHora
            // 
            cboHora.Enabled = false;
            cboHora.FormattingEnabled = true;
            cboHora.Location = new Point(79, 77);
            cboHora.Margin = new Padding(4, 2, 4, 2);
            cboHora.Name = "cboHora";
            cboHora.Size = new Size(232, 20);
            cboHora.TabIndex = 86;
            // 
            // cboPaciente
            // 
            cboPaciente.Enabled = false;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(80, 155);
            cboPaciente.Margin = new Padding(4, 2, 4, 2);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(231, 20);
            cboPaciente.TabIndex = 85;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(204, 211);
            cmdCancelar.Margin = new Padding(4, 2, 4, 2);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(110, 23);
            cmdCancelar.TabIndex = 84;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lblSeleccionarPaciente
            // 
            lblSeleccionarPaciente.AutoSize = true;
            lblSeleccionarPaciente.Location = new Point(77, 140);
            lblSeleccionarPaciente.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionarPaciente.Name = "lblSeleccionarPaciente";
            lblSeleccionarPaciente.Size = new Size(126, 12);
            lblSeleccionarPaciente.TabIndex = 83;
            lblSeleccionarPaciente.Text = "Seleccionar Paciente";
            // 
            // lblSeleccionarHora
            // 
            lblSeleccionarHora.AutoSize = true;
            lblSeleccionarHora.Location = new Point(78, 62);
            lblSeleccionarHora.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionarHora.Name = "lblSeleccionarHora";
            lblSeleccionarHora.Size = new Size(57, 12);
            lblSeleccionarHora.TabIndex = 82;
            lblSeleccionarHora.Text = "Sel. Hora";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(705, 37);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(85, 21);
            cmdBuscar.TabIndex = 81;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(488, 35);
            dtpFecha.Margin = new Padding(4, 2, 4, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(214, 23);
            dtpFecha.TabIndex = 80;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblHeader.Location = new Point(70, 29);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(217, 32);
            lblHeader.TabIndex = 79;
            lblHeader.Text = "Gestor de Citas";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(326, 62);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(464, 199);
            dgvData.TabIndex = 78;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(77, 212);
            cmdRegistrar.Margin = new Padding(4, 2, 4, 2);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(110, 23);
            cmdRegistrar.TabIndex = 77;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(575, 39);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(40, 12);
            lblFecha.TabIndex = 76;
            lblFecha.Text = "Fecha";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(145, 182);
            txtTelefono.Margin = new Padding(4, 2, 4, 2);
            txtTelefono.Mask = "(52) 000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(166, 23);
            txtTelefono.TabIndex = 129;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(80, 189);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 12);
            lblTelefono.TabIndex = 128;
            lblTelefono.Text = "Telefono";
            // 
            // lblIdCita
            // 
            lblIdCita.AutoSize = true;
            lblIdCita.Location = new Point(325, 44);
            lblIdCita.Margin = new Padding(4, 0, 4, 0);
            lblIdCita.Name = "lblIdCita";
            lblIdCita.Size = new Size(38, 12);
            lblIdCita.TabIndex = 132;
            lblIdCita.Text = "IdCita";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new Point(366, 35);
            txtIdPaciente.Margin = new Padding(4, 2, 4, 2);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(54, 23);
            txtIdPaciente.TabIndex = 131;
            // 
            // cboMedico
            // 
            cboMedico.Enabled = false;
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(80, 116);
            cboMedico.Margin = new Padding(4, 2, 4, 2);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(231, 20);
            cboMedico.TabIndex = 135;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Location = new Point(78, 101);
            lblMedico.Margin = new Padding(4, 0, 4, 0);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(71, 12);
            lblMedico.TabIndex = 134;
            lblMedico.Text = "Sel. Medico";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, -28);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 328);
            dataGridView1.TabIndex = 136;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(77, 238);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(237, 23);
            cmdSalir.TabIndex = 137;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // frmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 284);
            Controls.Add(cmdSalir);
            Controls.Add(dataGridView1);
            Controls.Add(cboMedico);
            Controls.Add(lblMedico);
            Controls.Add(lblIdCita);
            Controls.Add(txtIdPaciente);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(cboHora);
            Controls.Add(cboPaciente);
            Controls.Add(cmdCancelar);
            Controls.Add(lblSeleccionarPaciente);
            Controls.Add(lblSeleccionarHora);
            Controls.Add(cmdBuscar);
            Controls.Add(dtpFecha);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Controls.Add(cmdRegistrar);
            Controls.Add(lblFecha);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCitas";
            Text = "frmCitas";
            Load += frmCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboHora;
        private ComboBox cboPaciente;
        private Button cmdCancelar;
        private Label lblSeleccionarPaciente;
        private Label lblSeleccionarHora;
        private Button cmdBuscar;
        private DateTimePicker dateTimePicker1;
        private Label lblHeader;
        private DataGridView dgvData;
        private Button cmdRegistrar;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private MaskedTextBox txtTelefono;
        private Label lblTelefono;
        private Label lblIdCita;
        private TextBox txtIdPaciente;
        private ComboBox cboMedico;
        private Label lblMedico;
        private DataGridView dataGridView1;
        private Button cmdSalir;
    }
}