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
            lblApellidos = new Label();
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
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(134, 81);
            dtpFecha.Margin = new Padding(4, 2, 4, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(186, 23);
            dtpFecha.TabIndex = 140;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblHeader.Location = new Point(38, 43);
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
            lblNombre.Location = new Point(44, 219);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 12);
            lblNombre.TabIndex = 241;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(133, 211);
            txtNombre.Margin = new Padding(4, 2, 4, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 23);
            txtNombre.TabIndex = 242;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Enabled = false;
            lblApellidos.Location = new Point(44, 250);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(60, 12);
            lblApellidos.TabIndex = 243;
            lblApellidos.Text = "Apellidos";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Enabled = false;
            txtAPaterno.Location = new Point(134, 242);
            txtAPaterno.Margin = new Padding(4, 2, 4, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(89, 23);
            txtAPaterno.TabIndex = 244;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Enabled = false;
            txtAMaterno.Location = new Point(230, 241);
            txtAMaterno.Margin = new Padding(4, 2, 4, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(90, 23);
            txtAMaterno.TabIndex = 246;
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(134, 269);
            cmdNuevo.Margin = new Padding(4, 2, 4, 2);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(88, 22);
            cmdNuevo.TabIndex = 260;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            cmdNuevo.Click += cmdNuevo_Click_1;
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Enabled = false;
            lblIdPaciente.Location = new Point(44, 192);
            lblIdPaciente.Margin = new Padding(4, 0, 4, 0);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(69, 12);
            lblIdPaciente.TabIndex = 278;
            lblIdPaciente.Text = "Id Paciente";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new Point(133, 184);
            txtIdPaciente.Margin = new Padding(4, 2, 4, 2);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(90, 23);
            txtIdPaciente.TabIndex = 279;
            // 
            // lblCitaPagar
            // 
            lblCitaPagar.AutoSize = true;
            lblCitaPagar.Location = new Point(44, 110);
            lblCitaPagar.Margin = new Padding(4, 0, 4, 0);
            lblCitaPagar.Name = "lblCitaPagar";
            lblCitaPagar.Size = new Size(75, 12);
            lblCitaPagar.TabIndex = 280;
            lblCitaPagar.Text = "Cita a Pagar";
            // 
            // cboCitaPagar
            // 
            cboCitaPagar.FormattingEnabled = true;
            cboCitaPagar.Location = new Point(134, 107);
            cboCitaPagar.Margin = new Padding(3, 2, 3, 2);
            cboCitaPagar.Name = "cboCitaPagar";
            cboCitaPagar.Size = new Size(186, 20);
            cboCitaPagar.TabIndex = 282;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(44, 135);
            lblTipoPago.Margin = new Padding(4, 0, 4, 0);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(84, 12);
            lblTipoPago.TabIndex = 283;
            lblTipoPago.Text = "Tipo de Pago";
            // 
            // cboTipoPago
            // 
            cboTipoPago.FormattingEnabled = true;
            cboTipoPago.Location = new Point(134, 131);
            cboTipoPago.Margin = new Padding(3, 2, 3, 2);
            cboTipoPago.Name = "cboTipoPago";
            cboTipoPago.Size = new Size(186, 20);
            cboTipoPago.TabIndex = 284;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(45, 161);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(42, 12);
            lblMonto.TabIndex = 285;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(133, 154);
            txtMonto.Margin = new Padding(4, 2, 4, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(187, 23);
            txtMonto.TabIndex = 286;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Enabled = false;
            cmdRegistrar.Location = new Point(230, 269);
            cmdRegistrar.Margin = new Padding(4, 2, 4, 2);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(90, 22);
            cmdRegistrar.TabIndex = 287;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click_1;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(134, 295);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(186, 23);
            cmdSalir.TabIndex = 289;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 12);
            label1.TabIndex = 290;
            label1.Text = "Sel. Fecha";
            // 
            // frmCobros
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 375);
            Controls.Add(label1);
            Controls.Add(cmdSalir);
            Controls.Add(cmdRegistrar);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(cboTipoPago);
            Controls.Add(lblTipoPago);
            Controls.Add(cboCitaPagar);
            Controls.Add(lblCitaPagar);
            Controls.Add(txtIdPaciente);
            Controls.Add(lblIdPaciente);
            Controls.Add(cmdNuevo);
            Controls.Add(txtAMaterno);
            Controls.Add(txtAPaterno);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblHeader);
            Controls.Add(dtpFecha);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCobros";
            Text = "frmCobros";
            Load += frmCobros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Label lblHeader;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellidos;
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
    }
}