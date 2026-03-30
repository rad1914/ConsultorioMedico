namespace ConsultorioMedico
{
    partial class frmCIReceta
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
            cboIdReceta = new ComboBox();
            label3 = new Label();
            cmdBuscar = new Button();
            cmdSalir = new Button();
            lblHeader = new Label();
            dgvData = new DataGridView();
            grpPaciente = new GroupBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtAMaterno = new TextBox();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblApellidos = new Label();
            txtAPaterno = new TextBox();
            grpConsulta = new GroupBox();
            txtIdExpediente = new TextBox();
            label2 = new Label();
            txtPresion = new TextBox();
            lblPresion = new Label();
            txtEstudios = new RichTextBox();
            lblEstudios = new Label();
            txtTratamiento = new RichTextBox();
            lblTratamiento = new Label();
            txtTemperatura = new TextBox();
            txtDiagnostico = new TextBox();
            lblDiagnostico = new Label();
            lblTemperatura = new Label();
            txtSintomas = new TextBox();
            lblSintomas = new Label();
            txtPeso = new TextBox();
            lblPeso = new Label();
            txtEstatura = new TextBox();
            lblEstatura = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            grpPaciente.SuspendLayout();
            grpConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // cboIdReceta
            // 
            cboIdReceta.FormattingEnabled = true;
            cboIdReceta.Location = new Point(666, 80);
            cboIdReceta.Margin = new Padding(4, 2, 4, 2);
            cboIdReceta.Name = "cboIdReceta";
            cboIdReceta.Size = new Size(53, 20);
            cboIdReceta.TabIndex = 344;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(604, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 12);
            label3.TabIndex = 343;
            label3.Text = "Id Receta";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(722, 79);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(76, 22);
            cmdBuscar.TabIndex = 342;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click_1;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(42, 364);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(756, 26);
            cmdSalir.TabIndex = 338;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(46, 72);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(156, 19);
            lblHeader.TabIndex = 336;
            lblHeader.Text = "Consulta Individual";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(46, 219);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(321, 140);
            dgvData.TabIndex = 335;
            // 
            // grpPaciente
            // 
            grpPaciente.Controls.Add(txtTelefono);
            grpPaciente.Controls.Add(txtNombre);
            grpPaciente.Controls.Add(txtAMaterno);
            grpPaciente.Controls.Add(lblNombre);
            grpPaciente.Controls.Add(lblTelefono);
            grpPaciente.Controls.Add(lblApellidos);
            grpPaciente.Controls.Add(txtAPaterno);
            grpPaciente.Location = new Point(46, 101);
            grpPaciente.Name = "grpPaciente";
            grpPaciente.Size = new Size(321, 113);
            grpPaciente.TabIndex = 348;
            grpPaciente.TabStop = false;
            grpPaciente.Text = "Paciente";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(91, 76);
            txtTelefono.Margin = new Padding(4, 2, 4, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 23);
            txtTelefono.TabIndex = 355;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 21);
            txtNombre.Margin = new Padding(4, 2, 4, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 350;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(187, 49);
            txtAMaterno.Margin = new Padding(4, 2, 4, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(95, 23);
            txtAMaterno.TabIndex = 354;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 25);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 12);
            lblNombre.TabIndex = 349;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(16, 67);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 12);
            lblTelefono.TabIndex = 353;
            lblTelefono.Text = "Telefono";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(16, 48);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(60, 12);
            lblApellidos.TabIndex = 351;
            lblApellidos.Text = "Apellidos";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(91, 49);
            txtAPaterno.Margin = new Padding(4, 2, 4, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(95, 23);
            txtAPaterno.TabIndex = 352;
            // 
            // grpConsulta
            // 
            grpConsulta.Controls.Add(txtIdExpediente);
            grpConsulta.Controls.Add(label2);
            grpConsulta.Controls.Add(txtPresion);
            grpConsulta.Controls.Add(lblPresion);
            grpConsulta.Controls.Add(txtEstudios);
            grpConsulta.Controls.Add(lblEstudios);
            grpConsulta.Controls.Add(txtTratamiento);
            grpConsulta.Controls.Add(lblTratamiento);
            grpConsulta.Controls.Add(txtTemperatura);
            grpConsulta.Controls.Add(txtDiagnostico);
            grpConsulta.Controls.Add(lblDiagnostico);
            grpConsulta.Controls.Add(lblTemperatura);
            grpConsulta.Controls.Add(txtSintomas);
            grpConsulta.Controls.Add(lblSintomas);
            grpConsulta.Controls.Add(txtPeso);
            grpConsulta.Controls.Add(lblPeso);
            grpConsulta.Controls.Add(txtEstatura);
            grpConsulta.Controls.Add(lblEstatura);
            grpConsulta.Location = new Point(374, 101);
            grpConsulta.Name = "grpConsulta";
            grpConsulta.Size = new Size(424, 258);
            grpConsulta.TabIndex = 356;
            grpConsulta.TabStop = false;
            grpConsulta.Text = "Consulta";
            // 
            // txtIdExpediente
            // 
            txtIdExpediente.Location = new Point(21, 45);
            txtIdExpediente.Margin = new Padding(4, 2, 4, 2);
            txtIdExpediente.Name = "txtIdExpediente";
            txtIdExpediente.Size = new Size(55, 23);
            txtIdExpediente.TabIndex = 369;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 12);
            label2.TabIndex = 368;
            label2.Text = "IdExp.";
            // 
            // txtPresion
            // 
            txtPresion.Location = new Point(22, 221);
            txtPresion.Margin = new Padding(4, 2, 4, 2);
            txtPresion.Name = "txtPresion";
            txtPresion.Size = new Size(55, 23);
            txtPresion.TabIndex = 365;
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Location = new Point(20, 207);
            lblPresion.Margin = new Padding(4, 0, 4, 0);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(49, 12);
            lblPresion.TabIndex = 364;
            lblPresion.Text = "Presion";
            // 
            // txtEstudios
            // 
            txtEstudios.Location = new Point(166, 161);
            txtEstudios.Margin = new Padding(4, 2, 4, 2);
            txtEstudios.Name = "txtEstudios";
            txtEstudios.Size = new Size(234, 83);
            txtEstudios.TabIndex = 259;
            txtEstudios.Text = "";
            // 
            // lblEstudios
            // 
            lblEstudios.AutoSize = true;
            lblEstudios.Location = new Point(98, 164);
            lblEstudios.Margin = new Padding(4, 0, 4, 0);
            lblEstudios.Name = "lblEstudios";
            lblEstudios.Size = new Size(55, 12);
            lblEstudios.TabIndex = 258;
            lblEstudios.Text = "Estudios";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(166, 48);
            txtTratamiento.Margin = new Padding(4, 2, 4, 2);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(234, 83);
            txtTratamiento.TabIndex = 257;
            txtTratamiento.Text = "";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Location = new Point(98, 51);
            lblTratamiento.Margin = new Padding(4, 0, 4, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(32, 12);
            lblTratamiento.TabIndex = 256;
            lblTratamiento.Text = "Trat.";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(22, 176);
            txtTemperatura.Margin = new Padding(4, 2, 4, 2);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(55, 23);
            txtTemperatura.TabIndex = 363;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(166, 134);
            txtDiagnostico.Margin = new Padding(4, 2, 4, 2);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(234, 23);
            txtDiagnostico.TabIndex = 255;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(98, 140);
            lblDiagnostico.Margin = new Padding(4, 0, 4, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(35, 12);
            lblDiagnostico.TabIndex = 254;
            lblDiagnostico.Text = "Diag.";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(21, 162);
            lblTemperatura.Margin = new Padding(4, 0, 4, 0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(42, 12);
            lblTemperatura.TabIndex = 362;
            lblTemperatura.Text = "Temp.";
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(166, 20);
            txtSintomas.Margin = new Padding(4, 2, 4, 2);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(234, 23);
            txtSintomas.TabIndex = 253;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Location = new Point(98, 26);
            lblSintomas.Margin = new Padding(4, 0, 4, 0);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(58, 12);
            lblSintomas.TabIndex = 252;
            lblSintomas.Text = "Sintomas";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(20, 86);
            txtPeso.Margin = new Padding(4, 2, 4, 2);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(55, 23);
            txtPeso.TabIndex = 359;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(20, 73);
            lblPeso.Margin = new Padding(4, 0, 4, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(34, 12);
            lblPeso.TabIndex = 358;
            lblPeso.Text = "Peso";
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(22, 128);
            txtEstatura.Margin = new Padding(4, 2, 4, 2);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(55, 23);
            txtEstatura.TabIndex = 361;
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(20, 114);
            lblEstatura.Margin = new Padding(4, 0, 4, 0);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(53, 12);
            lblEstatura.TabIndex = 360;
            lblEstatura.Text = "Estatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 41);
            label1.TabIndex = 357;
            label1.Text = "Recetas";
            // 
            // frmCIReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 420);
            Controls.Add(label1);
            Controls.Add(grpConsulta);
            Controls.Add(grpPaciente);
            Controls.Add(cboIdReceta);
            Controls.Add(label3);
            Controls.Add(cmdBuscar);
            Controls.Add(cmdSalir);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCIReceta";
            Text = "frmCIReceta";
            Load += frmCIReceta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            grpPaciente.ResumeLayout(false);
            grpPaciente.PerformLayout();
            grpConsulta.ResumeLayout(false);
            grpConsulta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboIdReceta;
        private Label label3;
        private Button cmdBuscar;
        private Button cmdSalir;
        private Label lblHeader;
        private DataGridView dgvData;
        private GroupBox grpPaciente;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtAMaterno;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblApellidos;
        private TextBox txtAPaterno;
        private GroupBox grpConsulta;
        private RichTextBox txtEstudios;
        private Label lblEstudios;
        private RichTextBox txtTratamiento;
        private Label lblTratamiento;
        private TextBox txtDiagnostico;
        private Label lblDiagnostico;
        private TextBox txtSintomas;
        private Label lblSintomas;
        private Label label1;
        private TextBox txtPresion;
        private Label lblPresion;
        private TextBox txtTemperatura;
        private Label lblTemperatura;
        private TextBox txtPeso;
        private Label lblPeso;
        private TextBox txtEstatura;
        private Label lblEstatura;
        private TextBox txtIdExpediente;
        private Label label2;
    }
}