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
            cmdBuscar = new Button();
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
            comboBox1 = new ComboBox();
            lblTipoPago = new Label();
            comboBox2 = new ComboBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            cmdRegistrar = new Button();
            label1 = new Label();
            cmdSalir = new Button();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(115, 73);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(186, 23);
            dtpFecha.TabIndex = 140;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(309, 72);
            cmdBuscar.Margin = new Padding(4, 3, 4, 3);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(72, 24);
            cmdBuscar.TabIndex = 141;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(28, 33);
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
            lblNombre.Location = new Point(32, 199);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 241;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(115, 196);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 23);
            txtNombre.TabIndex = 242;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Enabled = false;
            lblApellidos.Location = new Point(32, 229);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 243;
            lblApellidos.Text = "Apellidos";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Enabled = false;
            txtAPaterno.Location = new Point(115, 225);
            txtAPaterno.Margin = new Padding(4, 3, 4, 3);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(125, 23);
            txtAPaterno.TabIndex = 244;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Enabled = false;
            txtAMaterno.Location = new Point(256, 225);
            txtAMaterno.Margin = new Padding(4, 3, 4, 3);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(125, 23);
            txtAMaterno.TabIndex = 246;
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(114, 256);
            cmdNuevo.Margin = new Padding(4, 3, 4, 3);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(126, 23);
            cmdNuevo.TabIndex = 260;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Enabled = false;
            lblIdPaciente.Location = new Point(32, 171);
            lblIdPaciente.Margin = new Padding(4, 0, 4, 0);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(65, 15);
            lblIdPaciente.TabIndex = 278;
            lblIdPaciente.Text = "Id Paciente";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new Point(114, 166);
            txtIdPaciente.Margin = new Padding(4, 3, 4, 3);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(71, 23);
            txtIdPaciente.TabIndex = 279;
            // 
            // lblCitaPagar
            // 
            lblCitaPagar.AutoSize = true;
            lblCitaPagar.Location = new Point(33, 109);
            lblCitaPagar.Margin = new Padding(4, 0, 4, 0);
            lblCitaPagar.Name = "lblCitaPagar";
            lblCitaPagar.Size = new Size(70, 15);
            lblCitaPagar.TabIndex = 280;
            lblCitaPagar.Text = "Cita a Pagar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(115, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(70, 23);
            comboBox1.TabIndex = 282;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(192, 109);
            lblTipoPago.Margin = new Padding(4, 0, 4, 0);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(77, 15);
            lblTipoPago.TabIndex = 283;
            lblTipoPago.Text = "Tipo de Pago";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(274, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(107, 23);
            comboBox2.TabIndex = 284;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(34, 138);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 285;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(114, 135);
            txtMonto.Margin = new Padding(4, 3, 4, 3);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(267, 23);
            txtMonto.TabIndex = 286;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Enabled = false;
            cmdRegistrar.Location = new Point(255, 256);
            cmdRegistrar.Margin = new Padding(4, 3, 4, 3);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(126, 23);
            cmdRegistrar.TabIndex = 287;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 288;
            label1.Text = "Sel. Fecha";
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(115, 285);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(266, 23);
            cmdSalir.TabIndex = 289;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // frmCobros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 345);
            Controls.Add(cmdSalir);
            Controls.Add(label1);
            Controls.Add(cmdRegistrar);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(comboBox2);
            Controls.Add(lblTipoPago);
            Controls.Add(comboBox1);
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
            Controls.Add(cmdBuscar);
            Controls.Add(dtpFecha);
            Name = "frmCobros";
            Text = "frmCobros";
            Load += frmCobros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Button cmdBuscar;
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
        private ComboBox comboBox1;
        private Label lblTipoPago;
        private ComboBox comboBox2;
        private Label lblMonto;
        private TextBox txtMonto;
        private Button cmdRegistrar;
        private Label label1;
        private Button cmdSalir;
    }
}