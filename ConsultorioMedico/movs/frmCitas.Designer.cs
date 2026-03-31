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
            idPaciente = new Label();
            txtIdPaciente = new TextBox();
            cmdSalir = new Button();
            cboMedico = new ComboBox();
            lblMedico = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // cboHora
            // 
            cboHora.Enabled = false;
            cboHora.FormattingEnabled = true;
            cboHora.Location = new Point(43, 66);
            cboHora.Margin = new Padding(4, 2, 4, 2);
            cboHora.Name = "cboHora";
            cboHora.Size = new Size(110, 20);
            cboHora.TabIndex = 86;
            // 
            // cboPaciente
            // 
            cboPaciente.Enabled = false;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(43, 99);
            cboPaciente.Margin = new Padding(4, 2, 4, 2);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(231, 20);
            cboPaciente.TabIndex = 85;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(166, 161);
            cmdCancelar.Margin = new Padding(4, 2, 4, 2);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(110, 18);
            cmdCancelar.TabIndex = 84;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lblSeleccionarPaciente
            // 
            lblSeleccionarPaciente.AutoSize = true;
            lblSeleccionarPaciente.Location = new Point(40, 86);
            lblSeleccionarPaciente.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionarPaciente.Name = "lblSeleccionarPaciente";
            lblSeleccionarPaciente.Size = new Size(126, 12);
            lblSeleccionarPaciente.TabIndex = 83;
            lblSeleccionarPaciente.Text = "Seleccionar Paciente";
            // 
            // lblSeleccionarHora
            // 
            lblSeleccionarHora.AutoSize = true;
            lblSeleccionarHora.Location = new Point(40, 52);
            lblSeleccionarHora.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionarHora.Name = "lblSeleccionarHora";
            lblSeleccionarHora.Size = new Size(57, 12);
            lblSeleccionarHora.TabIndex = 82;
            lblSeleccionarHora.Text = "Sel. Hora";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(642, 30);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(93, 19);
            cmdBuscar.TabIndex = 81;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(449, 31);
            dtpFecha.Margin = new Padding(4, 2, 4, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(191, 23);
            dtpFecha.TabIndex = 80;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblHeader.Location = new Point(36, 25);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(217, 32);
            lblHeader.TabIndex = 79;
            lblHeader.Text = "Gestor de Citas";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(284, 52);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(451, 150);
            dgvData.TabIndex = 78;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(43, 161);
            cmdRegistrar.Margin = new Padding(4, 2, 4, 2);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(110, 18);
            cmdRegistrar.TabIndex = 77;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(521, 34);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(40, 12);
            lblFecha.TabIndex = 76;
            lblFecha.Text = "Fecha";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(106, 138);
            txtTelefono.Margin = new Padding(4, 2, 4, 2);
            txtTelefono.Mask = "(52) 000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 23);
            txtTelefono.TabIndex = 129;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(45, 144);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 12);
            lblTelefono.TabIndex = 128;
            lblTelefono.Text = "Telefono";
            // 
            // idPaciente
            // 
            idPaciente.AutoSize = true;
            idPaciente.Location = new Point(281, 38);
            idPaciente.Margin = new Padding(4, 0, 4, 0);
            idPaciente.Name = "idPaciente";
            idPaciente.Size = new Size(16, 12);
            idPaciente.TabIndex = 132;
            idPaciente.Text = "Id";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new Point(298, 31);
            txtIdPaciente.Margin = new Padding(4, 2, 4, 2);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(54, 23);
            txtIdPaciente.TabIndex = 131;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(43, 184);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(233, 18);
            cmdSalir.TabIndex = 133;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cboMedico
            // 
            cboMedico.Enabled = false;
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(156, 66);
            cboMedico.Margin = new Padding(4, 2, 4, 2);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(118, 20);
            cboMedico.TabIndex = 135;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Location = new Point(154, 52);
            lblMedico.Margin = new Padding(4, 0, 4, 0);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(71, 12);
            lblMedico.TabIndex = 134;
            lblMedico.Text = "Sel. Medico";
            // 
            // frmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 234);
            Controls.Add(cboMedico);
            Controls.Add(lblMedico);
            Controls.Add(cmdSalir);
            Controls.Add(idPaciente);
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
            Text = "Form1";
            Load += frmCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
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
        private Label idPaciente;
        private TextBox txtIdPaciente;
        private Button cmdSalir;
        private ComboBox cboMedico;
        private Label lblMedico;
    }
}