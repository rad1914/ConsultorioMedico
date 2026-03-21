namespace ConsultorioMedico
{
    partial class frmExpedientes
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
            cmdSalir = new Button();
            cmdRegistrar = new Button();
            cmdBuscar = new Button();
            dtpFecha = new DateTimePicker();
            dgvData = new DataGridView();
            lblFecha = new Label();
            dgvExpedientes = new DataGridView();
            txtEnfermedades = new RichTextBox();
            lblEnfermedadCronica = new Label();
            txtAlergias = new RichTextBox();
            lblAlergias = new Label();
            cboSangre = new ComboBox();
            lblTipoSangre = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            cboGenero = new ComboBox();
            lblGenero = new Label();
            txtTelefono = new MaskedTextBox();
            txtAMaterno = new TextBox();
            lblTelefono = new Label();
            txtAPaterno = new TextBox();
            lblApellidos = new Label();
            txtNombre = new TextBox();
            cboCitas = new ComboBox();
            label3 = new Label();
            lblHeader = new Label();
            lblSintomas = new Label();
            txtSintomas = new TextBox();
            txtDiagnostico = new TextBox();
            lblDiagnostico = new Label();
            txtTratamiento = new RichTextBox();
            lblTratamiento = new Label();
            txtEstudios = new RichTextBox();
            lblEstudios = new Label();
            txtPeso = new TextBox();
            lblPeso = new Label();
            txtEstatura = new TextBox();
            lblEstatura = new Label();
            txtTemperatura = new TextBox();
            lblTemperatura = new Label();
            txtPresion = new TextBox();
            lblPresion = new Label();
            txtIdPaciente = new TextBox();
            lblIdPaciente = new Label();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpedientes).BeginInit();
            SuspendLayout();
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(655, 487);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(323, 23);
            cmdSalir.TabIndex = 149;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(314, 487);
            cmdRegistrar.Margin = new Padding(4, 3, 4, 3);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(323, 23);
            cmdRegistrar.TabIndex = 142;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click_1;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(885, 22);
            cmdBuscar.Margin = new Padding(4, 3, 4, 3);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(93, 24);
            cmdBuscar.TabIndex = 139;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(672, 23);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(208, 23);
            dtpFecha.TabIndex = 138;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(314, 52);
            dgvData.Margin = new Padding(4, 3, 4, 3);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(664, 106);
            dgvData.TabIndex = 136;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(630, 29);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 134;
            lblFecha.Text = "Fecha";
            // 
            // dgvExpedientes
            // 
            dgvExpedientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpedientes.Location = new Point(314, 164);
            dgvExpedientes.Margin = new Padding(4, 3, 4, 3);
            dgvExpedientes.Name = "dgvExpedientes";
            dgvExpedientes.RowTemplate.Height = 25;
            dgvExpedientes.Size = new Size(664, 136);
            dgvExpedientes.TabIndex = 176;
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.Enabled = false;
            txtEnfermedades.Location = new Point(105, 393);
            txtEnfermedades.Margin = new Padding(4, 3, 4, 3);
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(191, 117);
            txtEnfermedades.TabIndex = 240;
            txtEnfermedades.Text = "";
            // 
            // lblEnfermedadCronica
            // 
            lblEnfermedadCronica.AutoSize = true;
            lblEnfermedadCronica.Enabled = false;
            lblEnfermedadCronica.Location = new Point(33, 396);
            lblEnfermedadCronica.Margin = new Padding(4, 0, 4, 0);
            lblEnfermedadCronica.Name = "lblEnfermedadCronica";
            lblEnfermedadCronica.Size = new Size(71, 30);
            lblEnfermedadCronica.TabIndex = 239;
            lblEnfermedadCronica.Text = "Enfermedad\r\nCronica";
            // 
            // txtAlergias
            // 
            txtAlergias.Enabled = false;
            txtAlergias.Location = new Point(105, 314);
            txtAlergias.Margin = new Padding(4, 3, 4, 3);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(191, 73);
            txtAlergias.TabIndex = 238;
            txtAlergias.Text = "";
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Enabled = false;
            lblAlergias.Location = new Point(33, 321);
            lblAlergias.Margin = new Padding(4, 0, 4, 0);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(49, 15);
            lblAlergias.TabIndex = 237;
            lblAlergias.Text = "Alergias";
            // 
            // cboSangre
            // 
            cboSangre.Enabled = false;
            cboSangre.FormattingEnabled = true;
            cboSangre.Location = new Point(245, 251);
            cboSangre.Margin = new Padding(4, 3, 4, 3);
            cboSangre.Name = "cboSangre";
            cboSangre.Size = new Size(51, 23);
            cboSangre.TabIndex = 236;
            // 
            // lblTipoSangre
            // 
            lblTipoSangre.AutoSize = true;
            lblTipoSangre.Enabled = false;
            lblTipoSangre.Location = new Point(170, 257);
            lblTipoSangre.Margin = new Padding(4, 0, 4, 0);
            lblTipoSangre.Name = "lblTipoSangre";
            lblTipoSangre.Size = new Size(63, 15);
            lblTipoSangre.TabIndex = 235;
            lblTipoSangre.Text = "Tipo Sang.";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Enabled = false;
            dtpFechaNacimiento.Location = new Point(105, 284);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(191, 23);
            dtpFechaNacimiento.TabIndex = 234;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Enabled = false;
            lblFechaNacimiento.Location = new Point(32, 290);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(65, 15);
            lblFechaNacimiento.TabIndex = 233;
            lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // cboGenero
            // 
            cboGenero.Enabled = false;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(105, 251);
            cboGenero.Margin = new Padding(4, 3, 4, 3);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(51, 23);
            cboGenero.TabIndex = 232;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Enabled = false;
            lblGenero.Location = new Point(32, 259);
            lblGenero.Margin = new Padding(4, 0, 4, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 231;
            lblGenero.Text = "Genero";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(105, 219);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Mask = "(52) 000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 23);
            txtTelefono.TabIndex = 230;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Enabled = false;
            txtAMaterno.Location = new Point(208, 189);
            txtAMaterno.Margin = new Padding(4, 3, 4, 3);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(88, 23);
            txtAMaterno.TabIndex = 229;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Enabled = false;
            lblTelefono.Location = new Point(33, 222);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 228;
            lblTelefono.Text = "Telefono";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Enabled = false;
            txtAPaterno.Location = new Point(105, 189);
            txtAPaterno.Margin = new Padding(4, 3, 4, 3);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(83, 23);
            txtAPaterno.TabIndex = 227;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Enabled = false;
            lblApellidos.Location = new Point(33, 193);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 226;
            lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(105, 160);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 225;
            // 
            // cboCitas
            // 
            cboCitas.FormattingEnabled = true;
            cboCitas.Location = new Point(38, 131);
            cboCitas.Margin = new Padding(4, 3, 4, 3);
            cboCitas.Name = "cboCitas";
            cboCitas.Size = new Size(258, 23);
            cboCitas.TabIndex = 223;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 222;
            label3.Text = "Sel. Cita";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(30, 42);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(175, 64);
            lblHeader.TabIndex = 221;
            lblHeader.Text = "Gestor de\r\nExpedientes";
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Location = new Point(314, 345);
            lblSintomas.Margin = new Padding(4, 0, 4, 0);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(56, 15);
            lblSintomas.TabIndex = 241;
            lblSintomas.Text = "Sintomas";
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(395, 341);
            txtSintomas.Margin = new Padding(4, 3, 4, 3);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(234, 23);
            txtSintomas.TabIndex = 242;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(744, 342);
            txtDiagnostico.Margin = new Padding(4, 3, 4, 3);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(234, 23);
            txtDiagnostico.TabIndex = 247;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(663, 346);
            lblDiagnostico.Margin = new Padding(4, 0, 4, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(70, 15);
            lblDiagnostico.TabIndex = 246;
            lblDiagnostico.Text = "Diagnostico";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(395, 370);
            txtTratamiento.Margin = new Padding(4, 3, 4, 3);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(234, 103);
            txtTratamiento.TabIndex = 249;
            txtTratamiento.Text = "";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Location = new Point(314, 373);
            lblTratamiento.Margin = new Padding(4, 0, 4, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(71, 15);
            lblTratamiento.TabIndex = 248;
            lblTratamiento.Text = "Tratamiento";
            // 
            // txtEstudios
            // 
            txtEstudios.Location = new Point(744, 370);
            txtEstudios.Margin = new Padding(4, 3, 4, 3);
            txtEstudios.Name = "txtEstudios";
            txtEstudios.Size = new Size(234, 103);
            txtEstudios.TabIndex = 251;
            txtEstudios.Text = "";
            // 
            // lblEstudios
            // 
            lblEstudios.AutoSize = true;
            lblEstudios.Location = new Point(663, 373);
            lblEstudios.Margin = new Padding(4, 0, 4, 0);
            lblEstudios.Name = "lblEstudios";
            lblEstudios.Size = new Size(51, 15);
            lblEstudios.TabIndex = 250;
            lblEstudios.Text = "Estudios";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(458, 309);
            txtPeso.Margin = new Padding(4, 3, 4, 3);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(55, 23);
            txtPeso.TabIndex = 253;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(418, 312);
            lblPeso.Margin = new Padding(4, 0, 4, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 252;
            lblPeso.Text = "Peso";
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(582, 308);
            txtEstatura.Margin = new Padding(4, 3, 4, 3);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(55, 23);
            txtEstatura.TabIndex = 255;
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(525, 312);
            lblEstatura.Margin = new Padding(4, 0, 4, 0);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(49, 15);
            lblEstatura.TabIndex = 254;
            lblEstatura.Text = "Estatura";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(705, 306);
            txtTemperatura.Margin = new Padding(4, 3, 4, 3);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(55, 23);
            txtTemperatura.TabIndex = 257;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(648, 309);
            lblTemperatura.Margin = new Padding(4, 0, 4, 0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(40, 15);
            lblTemperatura.TabIndex = 256;
            lblTemperatura.Text = "Temp.";
            // 
            // txtPresion
            // 
            txtPresion.Location = new Point(825, 306);
            txtPresion.Margin = new Padding(4, 3, 4, 3);
            txtPresion.Name = "txtPresion";
            txtPresion.Size = new Size(55, 23);
            txtPresion.TabIndex = 259;
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Location = new Point(771, 309);
            lblPresion.Margin = new Padding(4, 0, 4, 0);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(46, 15);
            lblPresion.TabIndex = 258;
            lblPresion.Text = "Presion";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new Point(381, 22);
            txtIdPaciente.Margin = new Padding(4, 3, 4, 3);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(45, 23);
            txtIdPaciente.TabIndex = 261;
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Location = new Point(312, 27);
            lblIdPaciente.Margin = new Padding(4, 0, 4, 0);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(65, 15);
            lblIdPaciente.TabIndex = 260;
            lblIdPaciente.Text = "Id Paciente";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Enabled = false;
            lblNombre.Location = new Point(33, 164);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 224;
            lblNombre.Text = "Nombre";
            // 
            // frmExpedientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 529);
            Controls.Add(txtIdPaciente);
            Controls.Add(lblIdPaciente);
            Controls.Add(txtPresion);
            Controls.Add(lblPresion);
            Controls.Add(txtTemperatura);
            Controls.Add(lblTemperatura);
            Controls.Add(txtEstatura);
            Controls.Add(lblEstatura);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtEstudios);
            Controls.Add(lblEstudios);
            Controls.Add(txtTratamiento);
            Controls.Add(lblTratamiento);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblDiagnostico);
            Controls.Add(txtSintomas);
            Controls.Add(lblSintomas);
            Controls.Add(txtEnfermedades);
            Controls.Add(lblEnfermedadCronica);
            Controls.Add(txtAlergias);
            Controls.Add(lblAlergias);
            Controls.Add(cboSangre);
            Controls.Add(lblTipoSangre);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(cboGenero);
            Controls.Add(lblGenero);
            Controls.Add(txtTelefono);
            Controls.Add(txtAMaterno);
            Controls.Add(lblTelefono);
            Controls.Add(txtAPaterno);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(cboCitas);
            Controls.Add(label3);
            Controls.Add(lblHeader);
            Controls.Add(dgvExpedientes);
            Controls.Add(cmdSalir);
            Controls.Add(cmdRegistrar);
            Controls.Add(cmdBuscar);
            Controls.Add(dtpFecha);
            Controls.Add(dgvData);
            Controls.Add(lblFecha);
            Name = "frmExpedientes";
            Text = "frmExpedientes";
            Load += frmExpedientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpedientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdSalir;
        private Button cmdRegistrar;
        private Button cmdBuscar;
        private DateTimePicker dtpFecha;
        private DataGridView dgvData;
        private Button cmdAtender;
        private Label lblFecha;
        private DataGridView dgvExpedientes;
        private RichTextBox txtEnfermedades;
        private Label lblEnfermedadCronica;
        private RichTextBox txtAlergias;
        private Label lblAlergias;
        private ComboBox cboSangre;
        private Label lblTipoSangre;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private ComboBox cboGenero;
        private Label lblGenero;
        private MaskedTextBox txtTelefono;
        private TextBox txtAMaterno;
        private Label lblTelefono;
        private TextBox txtAPaterno;
        private Label lblApellidos;
        private TextBox txtNombre;
        private ComboBox cboCitas;
        private Label label3;
        private Label lblHeader;
        private Label lblSintomas;
        private TextBox txtSintomas;
        private TextBox txtDiagnostico;
        private Label lblDiagnostico;
        private RichTextBox txtTratamiento;
        private Label lblTratamiento;
        private RichTextBox txtEstudios;
        private Label lblEstudios;
        private TextBox txtPeso;
        private Label lblPeso;
        private TextBox txtEstatura;
        private Label lblEstatura;
        private TextBox textBox6;
        private Label lblTemperatura;
        private TextBox textBox7;
        private Label lblPresion;
        private TextBox txtTemperatura;
        private TextBox txtPresion;
        private TextBox txtIdPaciente;
        private Label lblIdPaciente;
        private Label lblNombre;
    }
}