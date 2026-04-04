namespace ConsultorioMedico
{
    partial class frmCICobros
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
            grpPago = new GroupBox();
            txtIdCobro = new TextBox();
            idCobro = new Label();
            txtMonto = new TextBox();
            lblMonto = new Label();
            cboTipoPago = new ComboBox();
            lblTipoPago = new Label();
            grpPaciente = new GroupBox();
            txtTelefono = new TextBox();
            lblNombre = new Label();
            txtAMaterno = new TextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblApellidos = new Label();
            txtAPaterno = new TextBox();
            lblCobros = new Label();
            grpCliente = new GroupBox();
            txtEmail = new TextBox();
            txtCliente = new TextBox();
            lblCliente = new Label();
            lblEmail = new Label();
            lblRfc = new Label();
            txtRfc = new TextBox();
            cboIdCobro = new ComboBox();
            lblIdCobro = new Label();
            cmdBuscar = new Button();
            cmdSalir = new Button();
            lblHeader = new Label();
            dgvData = new DataGridView();
            grpCita = new GroupBox();
            cboHora = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtIdCita = new TextBox();
            lblIdCita = new Label();
            lblHora = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            grpPago.SuspendLayout();
            grpPaciente.SuspendLayout();
            grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            grpCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpPago
            // 
            grpPago.Controls.Add(txtIdCobro);
            grpPago.Controls.Add(idCobro);
            grpPago.Controls.Add(txtMonto);
            grpPago.Controls.Add(lblMonto);
            grpPago.Controls.Add(cboTipoPago);
            grpPago.Controls.Add(lblTipoPago);
            grpPago.Location = new Point(77, 224);
            grpPago.Margin = new Padding(3, 2, 3, 2);
            grpPago.Name = "grpPago";
            grpPago.Padding = new Padding(3, 2, 3, 2);
            grpPago.Size = new Size(301, 125);
            grpPago.TabIndex = 381;
            grpPago.TabStop = false;
            grpPago.Text = "Pago";
            // 
            // txtIdCobro
            // 
            txtIdCobro.Location = new Point(94, 28);
            txtIdCobro.Margin = new Padding(4, 2, 4, 2);
            txtIdCobro.Name = "txtIdCobro";
            txtIdCobro.Size = new Size(54, 23);
            txtIdCobro.TabIndex = 379;
            // 
            // idCobro
            // 
            idCobro.AutoSize = true;
            idCobro.Location = new Point(19, 36);
            idCobro.Margin = new Padding(4, 0, 4, 0);
            idCobro.Name = "idCobro";
            idCobro.Size = new Size(53, 12);
            idCobro.TabIndex = 378;
            idCobro.Text = "idCobro";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(94, 56);
            txtMonto.Margin = new Padding(4, 2, 4, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(190, 23);
            txtMonto.TabIndex = 377;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(19, 66);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(42, 12);
            lblMonto.TabIndex = 376;
            lblMonto.Text = "Monto";
            // 
            // cboTipoPago
            // 
            cboTipoPago.FormattingEnabled = true;
            cboTipoPago.Location = new Point(95, 85);
            cboTipoPago.Margin = new Padding(3, 2, 3, 2);
            cboTipoPago.Name = "cboTipoPago";
            cboTipoPago.Size = new Size(190, 20);
            cboTipoPago.TabIndex = 375;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(20, 90);
            lblTipoPago.Margin = new Padding(4, 0, 4, 0);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(61, 12);
            lblTipoPago.TabIndex = 374;
            lblTipoPago.Text = "Tip. Pago";
            // 
            // grpPaciente
            // 
            grpPaciente.Controls.Add(txtTelefono);
            grpPaciente.Controls.Add(lblNombre);
            grpPaciente.Controls.Add(txtAMaterno);
            grpPaciente.Controls.Add(txtNombre);
            grpPaciente.Controls.Add(lblTelefono);
            grpPaciente.Controls.Add(lblApellidos);
            grpPaciente.Controls.Add(txtAPaterno);
            grpPaciente.Location = new Point(77, 97);
            grpPaciente.Margin = new Padding(3, 2, 3, 2);
            grpPaciente.Name = "grpPaciente";
            grpPaciente.Padding = new Padding(3, 2, 3, 2);
            grpPaciente.Size = new Size(301, 125);
            grpPaciente.TabIndex = 379;
            grpPaciente.TabStop = false;
            grpPaciente.Text = "Paciente";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(88, 81);
            txtTelefono.Margin = new Padding(4, 2, 4, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 23);
            txtTelefono.TabIndex = 388;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 31);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 12);
            lblNombre.TabIndex = 382;
            lblNombre.Text = "Nombre";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(184, 54);
            txtAMaterno.Margin = new Padding(4, 2, 4, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(95, 23);
            txtAMaterno.TabIndex = 387;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 28);
            txtNombre.Margin = new Padding(4, 2, 4, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 383;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(19, 84);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 12);
            lblTelefono.TabIndex = 386;
            lblTelefono.Text = "Telefono";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(19, 60);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(60, 12);
            lblApellidos.TabIndex = 384;
            lblApellidos.Text = "Apellidos";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(88, 54);
            txtAPaterno.Margin = new Padding(4, 2, 4, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(95, 23);
            txtAPaterno.TabIndex = 385;
            // 
            // lblCobros
            // 
            lblCobros.AutoSize = true;
            lblCobros.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCobros.Location = new Point(69, 33);
            lblCobros.Margin = new Padding(4, 0, 4, 0);
            lblCobros.Name = "lblCobros";
            lblCobros.Size = new Size(128, 37);
            lblCobros.TabIndex = 380;
            lblCobros.Text = "Cobros";
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(txtEmail);
            grpCliente.Controls.Add(txtCliente);
            grpCliente.Controls.Add(lblCliente);
            grpCliente.Controls.Add(lblEmail);
            grpCliente.Controls.Add(lblRfc);
            grpCliente.Controls.Add(txtRfc);
            grpCliente.Enabled = false;
            grpCliente.Location = new Point(384, 224);
            grpCliente.Margin = new Padding(3, 2, 3, 2);
            grpCliente.Name = "grpCliente";
            grpCliente.Padding = new Padding(3, 2, 3, 2);
            grpCliente.Size = new Size(314, 125);
            grpCliente.TabIndex = 378;
            grpCliente.TabStop = false;
            grpCliente.Text = "Cliente";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 83);
            txtEmail.Margin = new Padding(4, 2, 4, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 23);
            txtEmail.TabIndex = 355;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(87, 26);
            txtCliente.Margin = new Padding(4, 2, 4, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(191, 23);
            txtCliente.TabIndex = 350;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(17, 33);
            lblCliente.Margin = new Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 12);
            lblCliente.TabIndex = 349;
            lblCliente.Text = "Cliente";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 88);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(37, 12);
            lblEmail.TabIndex = 353;
            lblEmail.Text = "Email";
            // 
            // lblRfc
            // 
            lblRfc.AutoSize = true;
            lblRfc.Location = new Point(18, 60);
            lblRfc.Margin = new Padding(4, 0, 4, 0);
            lblRfc.Name = "lblRfc";
            lblRfc.Size = new Size(28, 12);
            lblRfc.TabIndex = 351;
            lblRfc.Text = "RFC";
            // 
            // txtRfc
            // 
            txtRfc.Location = new Point(87, 54);
            txtRfc.Margin = new Padding(4, 2, 4, 2);
            txtRfc.Name = "txtRfc";
            txtRfc.Size = new Size(190, 23);
            txtRfc.TabIndex = 352;
            // 
            // cboIdCobro
            // 
            cboIdCobro.FormattingEnabled = true;
            cboIdCobro.Location = new Point(566, 69);
            cboIdCobro.Margin = new Padding(4, 2, 4, 2);
            cboIdCobro.Name = "cboIdCobro";
            cboIdCobro.Size = new Size(53, 20);
            cboIdCobro.TabIndex = 377;
            // 
            // lblIdCobro
            // 
            lblIdCobro.AutoSize = true;
            lblIdCobro.Location = new Point(507, 76);
            lblIdCobro.Margin = new Padding(4, 0, 4, 0);
            lblIdCobro.Name = "lblIdCobro";
            lblIdCobro.Size = new Size(56, 12);
            lblIdCobro.TabIndex = 376;
            lblIdCobro.Text = "Id Cobro";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(622, 70);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(76, 20);
            cmdBuscar.TabIndex = 375;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(75, 493);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(621, 24);
            cmdSalir.TabIndex = 374;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = SystemColors.ControlDarkDark;
            lblHeader.Location = new Point(72, 67);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(156, 19);
            lblHeader.TabIndex = 373;
            lblHeader.Text = "Consulta Individual";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(76, 355);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(621, 132);
            dgvData.TabIndex = 372;
            // 
            // grpCita
            // 
            grpCita.Controls.Add(cboHora);
            grpCita.Controls.Add(dtpFecha);
            grpCita.Controls.Add(txtIdCita);
            grpCita.Controls.Add(lblIdCita);
            grpCita.Controls.Add(lblHora);
            grpCita.Controls.Add(label3);
            grpCita.Location = new Point(384, 98);
            grpCita.Margin = new Padding(3, 2, 3, 2);
            grpCita.Name = "grpCita";
            grpCita.Padding = new Padding(3, 2, 3, 2);
            grpCita.Size = new Size(314, 125);
            grpCita.TabIndex = 382;
            grpCita.TabStop = false;
            grpCita.Text = "Cita";
            // 
            // cboHora
            // 
            cboHora.FormattingEnabled = true;
            cboHora.Location = new Point(207, 41);
            cboHora.Margin = new Padding(3, 2, 3, 2);
            cboHora.Name = "cboHora";
            cboHora.Size = new Size(77, 20);
            cboHora.TabIndex = 380;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(93, 69);
            dtpFecha.Margin = new Padding(4, 2, 4, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(191, 23);
            dtpFecha.TabIndex = 380;
            // 
            // txtIdCita
            // 
            txtIdCita.Location = new Point(93, 40);
            txtIdCita.Margin = new Padding(4, 2, 4, 2);
            txtIdCita.Name = "txtIdCita";
            txtIdCita.Size = new Size(54, 23);
            txtIdCita.TabIndex = 379;
            // 
            // lblIdCita
            // 
            lblIdCita.AutoSize = true;
            lblIdCita.Location = new Point(18, 47);
            lblIdCita.Margin = new Padding(4, 0, 4, 0);
            lblIdCita.Name = "lblIdCita";
            lblIdCita.Size = new Size(38, 12);
            lblIdCita.TabIndex = 378;
            lblIdCita.Text = "idCita";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(169, 46);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(34, 12);
            lblHora.TabIndex = 376;
            lblHora.Text = "Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 12);
            label3.TabIndex = 374;
            label3.Text = "Tip. Pago";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, -28);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 591);
            dataGridView1.TabIndex = 383;
            // 
            // frmCICobros
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 541);
            Controls.Add(dataGridView1);
            Controls.Add(grpCita);
            Controls.Add(grpPago);
            Controls.Add(grpPaciente);
            Controls.Add(lblCobros);
            Controls.Add(grpCliente);
            Controls.Add(cboIdCobro);
            Controls.Add(lblIdCobro);
            Controls.Add(dgvData);
            Controls.Add(cmdBuscar);
            Controls.Add(cmdSalir);
            Controls.Add(lblHeader);
            Name = "frmCICobros";
            Text = "frmCICobros";
            Load += frmCICobros_Load;
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            grpPaciente.ResumeLayout(false);
            grpPaciente.PerformLayout();
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            grpCita.ResumeLayout(false);
            grpCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpPago;
        private TextBox txtMonto;
        private Label lblMonto;
        private ComboBox cboTipoPago;
        private Label lblTipoPago;
        private GroupBox grpPaciente;
        private Label lblCobros;
        private GroupBox grpCliente;
        private TextBox txtEmail;
        private TextBox txtCliente;
        private Label lblCliente;
        private Label lblEmail;
        private Label lblRfc;
        private TextBox txtRfc;
        private ComboBox cboIdCobro;
        private Label lblIdCobro;
        private Button cmdBuscar;
        private Button cmdSalir;
        private Label lblHeader;
        private DataGridView dgvData;
        private TextBox txtIdCobro;
        private Label idCobro;
        private TextBox txtTelefono;
        private Label lblNombre;
        private TextBox txtAMaterno;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblApellidos;
        private TextBox txtAPaterno;
        private GroupBox grpCita;
        private DateTimePicker dtpFecha;
        private TextBox txtIdCita;
        private Label lblIdCita;
        private TextBox textBox2;
        private Label lblHora;
        private Label label3;
        private ComboBox cboHora;
        private DataGridView dataGridView1;
    }
}