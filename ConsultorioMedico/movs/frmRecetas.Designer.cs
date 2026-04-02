namespace ConsultorioMedico
{
    partial class frmRecetas
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
            lblFecha = new Label();
            dgvData = new DataGridView();
            lblHeader = new Label();
            cmdSalir = new Button();
            cmdRegistrar = new Button();
            txtEstudios = new RichTextBox();
            lblEstudios = new Label();
            txtTratamiento = new RichTextBox();
            lblTratamiento = new Label();
            txtDiagnostico = new TextBox();
            lblDiagnostico = new Label();
            txtSintomas = new TextBox();
            lblSintomas = new Label();
            txtIndicaciones = new RichTextBox();
            lblIndicaciones = new Label();
            txtMedicamento = new RichTextBox();
            lblMedicamento = new Label();
            cmdAgregar = new Button();
            txtEnfermedadCronica = new RichTextBox();
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
            lblNombre = new Label();
            cboPaciente = new ComboBox();
            label3 = new Label();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblEstatura = new Label();
            txtEstatura = new TextBox();
            lblTemperatura = new Label();
            txtTemperatura = new TextBox();
            lblPresion = new Label();
            txtPresion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(738, 34);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(206, 23);
            dtpFecha.TabIndex = 141;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Enabled = false;
            lblFecha.Location = new Point(695, 40);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 140;
            lblFecha.Text = "Fecha";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(382, 260);
            dgvData.Margin = new Padding(4, 3, 4, 3);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(562, 147);
            dgvData.TabIndex = 143;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(33, 34);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(254, 32);
            lblHeader.TabIndex = 241;
            lblHeader.Text = "Gestor de Recetas";
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(382, 444);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(562, 23);
            cmdSalir.TabIndex = 263;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(382, 415);
            cmdRegistrar.Margin = new Padding(4, 3, 4, 3);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(562, 23);
            cmdRegistrar.TabIndex = 262;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // txtEstudios
            // 
            txtEstudios.Enabled = false;
            txtEstudios.Location = new Point(710, 101);
            txtEstudios.Margin = new Padding(4, 3, 4, 3);
            txtEstudios.Name = "txtEstudios";
            txtEstudios.Size = new Size(234, 64);
            txtEstudios.TabIndex = 271;
            txtEstudios.Text = "";
            // 
            // lblEstudios
            // 
            lblEstudios.AutoSize = true;
            lblEstudios.Enabled = false;
            lblEstudios.Location = new Point(630, 100);
            lblEstudios.Margin = new Padding(4, 0, 4, 0);
            lblEstudios.Name = "lblEstudios";
            lblEstudios.Size = new Size(51, 15);
            lblEstudios.TabIndex = 270;
            lblEstudios.Text = "Estudios";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Enabled = false;
            txtTratamiento.Location = new Point(382, 101);
            txtTratamiento.Margin = new Padding(4, 3, 4, 3);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(234, 64);
            txtTratamiento.TabIndex = 269;
            txtTratamiento.Text = "";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Enabled = false;
            lblTratamiento.Location = new Point(317, 102);
            lblTratamiento.Margin = new Padding(4, 0, 4, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(47, 15);
            lblTratamiento.TabIndex = 268;
            lblTratamiento.Text = "Tratam.";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Enabled = false;
            txtDiagnostico.Location = new Point(710, 69);
            txtDiagnostico.Margin = new Padding(4, 3, 4, 3);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(234, 23);
            txtDiagnostico.TabIndex = 267;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Enabled = false;
            lblDiagnostico.Location = new Point(628, 69);
            lblDiagnostico.Margin = new Padding(4, 0, 4, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(70, 15);
            lblDiagnostico.TabIndex = 266;
            lblDiagnostico.Text = "Diagnostico";
            // 
            // txtSintomas
            // 
            txtSintomas.Enabled = false;
            txtSintomas.Location = new Point(382, 68);
            txtSintomas.Margin = new Padding(4, 3, 4, 3);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(234, 23);
            txtSintomas.TabIndex = 265;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Enabled = false;
            lblSintomas.Location = new Point(317, 69);
            lblSintomas.Margin = new Padding(4, 0, 4, 0);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(56, 15);
            lblSintomas.TabIndex = 264;
            lblSintomas.Text = "Sintomas";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(710, 169);
            txtIndicaciones.Margin = new Padding(4, 3, 4, 3);
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(234, 57);
            txtIndicaciones.TabIndex = 283;
            txtIndicaciones.Text = "";
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Location = new Point(628, 170);
            lblIndicaciones.Margin = new Padding(4, 0, 4, 0);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new Size(73, 15);
            lblIndicaciones.TabIndex = 282;
            lblIndicaciones.Text = "Indicaciones";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(382, 169);
            txtMedicamento.Margin = new Padding(4, 3, 4, 3);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(234, 57);
            txtMedicamento.TabIndex = 281;
            txtMedicamento.Text = "";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(317, 172);
            lblMedicamento.Margin = new Padding(4, 0, 4, 0);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(43, 15);
            lblMedicamento.TabIndex = 280;
            lblMedicamento.Text = "Medic.";
            // 
            // cmdAgregar
            // 
            cmdAgregar.Location = new Point(381, 231);
            cmdAgregar.Margin = new Padding(4, 3, 4, 3);
            cmdAgregar.Name = "cmdAgregar";
            cmdAgregar.Size = new Size(563, 23);
            cmdAgregar.TabIndex = 284;
            cmdAgregar.Text = "Agregar";
            cmdAgregar.UseVisualStyleBackColor = true;
            cmdAgregar.Click += cmdAgregar_Click;
            // 
            // txtEnfermedadCronica
            // 
            txtEnfermedadCronica.Enabled = false;
            txtEnfermedadCronica.Location = new Point(108, 353);
            txtEnfermedadCronica.Margin = new Padding(4, 3, 4, 3);
            txtEnfermedadCronica.Name = "txtEnfermedadCronica";
            txtEnfermedadCronica.Size = new Size(191, 114);
            txtEnfermedadCronica.TabIndex = 304;
            txtEnfermedadCronica.Text = "";
            // 
            // lblEnfermedadCronica
            // 
            lblEnfermedadCronica.AutoSize = true;
            lblEnfermedadCronica.Enabled = false;
            lblEnfermedadCronica.Location = new Point(32, 356);
            lblEnfermedadCronica.Margin = new Padding(4, 0, 4, 0);
            lblEnfermedadCronica.Name = "lblEnfermedadCronica";
            lblEnfermedadCronica.Size = new Size(71, 30);
            lblEnfermedadCronica.TabIndex = 303;
            lblEnfermedadCronica.Text = "Enfermedad\r\nCronica";
            // 
            // txtAlergias
            // 
            txtAlergias.Enabled = false;
            txtAlergias.Location = new Point(108, 263);
            txtAlergias.Margin = new Padding(4, 3, 4, 3);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(191, 84);
            txtAlergias.TabIndex = 302;
            txtAlergias.Text = "";
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Enabled = false;
            lblAlergias.Location = new Point(32, 270);
            lblAlergias.Margin = new Padding(4, 0, 4, 0);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(49, 15);
            lblAlergias.TabIndex = 301;
            lblAlergias.Text = "Alergias";
            // 
            // cboSangre
            // 
            cboSangre.Enabled = false;
            cboSangre.FormattingEnabled = true;
            cboSangre.Location = new Point(248, 200);
            cboSangre.Margin = new Padding(4, 3, 4, 3);
            cboSangre.Name = "cboSangre";
            cboSangre.Size = new Size(51, 23);
            cboSangre.TabIndex = 300;
            // 
            // lblTipoSangre
            // 
            lblTipoSangre.AutoSize = true;
            lblTipoSangre.Enabled = false;
            lblTipoSangre.Location = new Point(180, 205);
            lblTipoSangre.Margin = new Padding(4, 0, 4, 0);
            lblTipoSangre.Name = "lblTipoSangre";
            lblTipoSangre.Size = new Size(63, 15);
            lblTipoSangre.TabIndex = 299;
            lblTipoSangre.Text = "Tipo Sang.";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Enabled = false;
            dtpFechaNacimiento.Location = new Point(108, 233);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(191, 23);
            dtpFechaNacimiento.TabIndex = 298;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Enabled = false;
            lblFechaNacimiento.Location = new Point(31, 239);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(65, 15);
            lblFechaNacimiento.TabIndex = 297;
            lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // cboGenero
            // 
            cboGenero.Enabled = false;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(108, 200);
            cboGenero.Margin = new Padding(4, 3, 4, 3);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(51, 23);
            cboGenero.TabIndex = 296;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Enabled = false;
            lblGenero.Location = new Point(31, 208);
            lblGenero.Margin = new Padding(4, 0, 4, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 295;
            lblGenero.Text = "Genero";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(108, 168);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Mask = "(52) 000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 23);
            txtTelefono.TabIndex = 294;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Enabled = false;
            txtAMaterno.Location = new Point(211, 138);
            txtAMaterno.Margin = new Padding(4, 3, 4, 3);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(88, 23);
            txtAMaterno.TabIndex = 293;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Enabled = false;
            lblTelefono.Location = new Point(32, 171);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 292;
            lblTelefono.Text = "Telefono";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Enabled = false;
            txtAPaterno.Location = new Point(108, 138);
            txtAPaterno.Margin = new Padding(4, 3, 4, 3);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(83, 23);
            txtAPaterno.TabIndex = 291;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Enabled = false;
            lblApellidos.Location = new Point(32, 142);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 290;
            lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(108, 109);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 289;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Enabled = false;
            lblNombre.Location = new Point(32, 113);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 288;
            lblNombre.Text = "Nombre";
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(108, 80);
            cboPaciente.Margin = new Padding(4, 3, 4, 3);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(191, 23);
            cboPaciente.TabIndex = 287;
            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 286;
            label3.Text = "Sel. Paciente";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Enabled = false;
            lblPeso.Location = new Point(317, 42);
            lblPeso.Margin = new Padding(4, 0, 4, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 272;
            lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Enabled = false;
            txtPeso.Location = new Point(352, 37);
            txtPeso.Margin = new Padding(4, 3, 4, 3);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(37, 23);
            txtPeso.TabIndex = 273;
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Enabled = false;
            lblEstatura.Location = new Point(396, 40);
            lblEstatura.Margin = new Padding(4, 0, 4, 0);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(49, 15);
            lblEstatura.TabIndex = 274;
            lblEstatura.Text = "Estatura";
            // 
            // txtEstatura
            // 
            txtEstatura.Enabled = false;
            txtEstatura.Location = new Point(447, 35);
            txtEstatura.Margin = new Padding(4, 3, 4, 3);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(44, 23);
            txtEstatura.TabIndex = 275;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Enabled = false;
            lblTemperatura.Location = new Point(493, 40);
            lblTemperatura.Margin = new Padding(4, 0, 4, 0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(40, 15);
            lblTemperatura.TabIndex = 276;
            lblTemperatura.Text = "Temp.";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Enabled = false;
            txtTemperatura.Location = new Point(535, 35);
            txtTemperatura.Margin = new Padding(4, 3, 4, 3);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(49, 23);
            txtTemperatura.TabIndex = 277;
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Enabled = false;
            lblPresion.Location = new Point(590, 40);
            lblPresion.Margin = new Padding(4, 0, 4, 0);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(46, 15);
            lblPresion.TabIndex = 278;
            lblPresion.Text = "Presion";
            // 
            // txtPresion
            // 
            txtPresion.Enabled = false;
            txtPresion.Location = new Point(635, 34);
            txtPresion.Margin = new Padding(4, 3, 4, 3);
            txtPresion.Name = "txtPresion";
            txtPresion.Size = new Size(55, 23);
            txtPresion.TabIndex = 279;
            // 
            // frmRecetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 494);
            Controls.Add(txtEnfermedadCronica);
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
            Controls.Add(cboPaciente);
            Controls.Add(label3);
            Controls.Add(cmdAgregar);
            Controls.Add(txtIndicaciones);
            Controls.Add(lblIndicaciones);
            Controls.Add(txtMedicamento);
            Controls.Add(lblMedicamento);
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
            Controls.Add(cmdSalir);
            Controls.Add(cmdRegistrar);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Name = "frmRecetas";
            Text = "frmRecetas";
            Load += frmRecetas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private DataGridView dgvData;
        private Label lblHeader;
        private Button cmdSalir;
        private Button cmdRegistrar;
        private RichTextBox txtEstudios;
        private Label lblEstudios;
        private RichTextBox txtTratamiento;
        private Label lblTratamiento;
        private TextBox txtDiagnostico;
        private Label lblDiagnostico;
        private TextBox txtSintomas;
        private Label lblSintomas;
        private RichTextBox txtIndicaciones;
        private Label lblIndicaciones;
        private RichTextBox richTextBox2;
        private Label lblMedicamento;
        private Button cmdAgregar;
        private RichTextBox txtEnfermedadCronica;
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
        private Label lblNombre;
        private ComboBox cboPaciente;
        private Label label3;
        private Label lblPeso;
        private TextBox txtPeso;
        private Label lblEstatura;
        private TextBox txtEstatura;
        private Label lblTemperatura;
        private TextBox txtTemperatura;
        private Label lblPresion;
        private TextBox txtPresion;
        private RichTextBox txtMedicamento;
    }
}