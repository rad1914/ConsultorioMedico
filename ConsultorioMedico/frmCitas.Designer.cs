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
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // cboHora
            // 
            cboHora.FormattingEnabled = true;
            cboHora.Location = new Point(31, 107);
            cboHora.Margin = new Padding(4, 3, 4, 3);
            cboHora.Name = "cboHora";
            cboHora.Size = new Size(358, 23);
            cboHora.TabIndex = 86;
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(31, 154);
            cboPaciente.Margin = new Padding(4, 3, 4, 3);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(358, 23);
            cboPaciente.TabIndex = 85;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(213, 267);
            cmdCancelar.Margin = new Padding(4, 3, 4, 3);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(176, 23);
            cmdCancelar.TabIndex = 84;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lblSeleccionarPaciente
            // 
            lblSeleccionarPaciente.AutoSize = true;
            lblSeleccionarPaciente.Location = new Point(31, 136);
            lblSeleccionarPaciente.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionarPaciente.Name = "lblSeleccionarPaciente";
            lblSeleccionarPaciente.Size = new Size(115, 15);
            lblSeleccionarPaciente.TabIndex = 83;
            lblSeleccionarPaciente.Text = "Seleccionar Paciente";
            // 
            // lblSeleccionarHora
            // 
            lblSeleccionarHora.AutoSize = true;
            lblSeleccionarHora.Location = new Point(31, 90);
            lblSeleccionarHora.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionarHora.Name = "lblSeleccionarHora";
            lblSeleccionarHora.Size = new Size(96, 15);
            lblSeleccionarHora.TabIndex = 82;
            lblSeleccionarHora.Text = "Seleccionar Hora";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(974, 26);
            cmdBuscar.Margin = new Padding(4, 3, 4, 3);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(93, 24);
            cmdBuscar.TabIndex = 81;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(733, 27);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(233, 23);
            dtpFecha.TabIndex = 80;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(24, 56);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(217, 32);
            lblHeader.TabIndex = 79;
            lblHeader.Text = "Gestor de Citas";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(412, 56);
            dgvData.Margin = new Padding(4, 3, 4, 3);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(655, 259);
            dgvData.TabIndex = 78;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(31, 267);
            cmdRegistrar.Margin = new Padding(4, 3, 4, 3);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(165, 23);
            cmdRegistrar.TabIndex = 77;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(853, 31);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 76;
            lblFecha.Text = "Fecha";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(142, 228);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Mask = "(52) 000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(247, 23);
            txtTelefono.TabIndex = 129;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(31, 236);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 128;
            lblTelefono.Text = "Telefono";
            // 
            // idPaciente
            // 
            idPaciente.AutoSize = true;
            idPaciente.Location = new Point(31, 207);
            idPaciente.Margin = new Padding(4, 0, 4, 0);
            idPaciente.Name = "idPaciente";
            idPaciente.Size = new Size(17, 15);
            idPaciente.TabIndex = 132;
            idPaciente.Text = "Id";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new Point(142, 199);
            txtIdPaciente.Margin = new Padding(4, 3, 4, 3);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(54, 23);
            txtIdPaciente.TabIndex = 131;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(31, 292);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(358, 23);
            cmdSalir.TabIndex = 133;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // frmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 337);
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
    }
}