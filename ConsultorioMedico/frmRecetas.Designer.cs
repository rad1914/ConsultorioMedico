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
            cmdBuscar = new Button();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            dgvData = new DataGridView();
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
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            lblTelefono = new Label();
            textBox2 = new TextBox();
            lblApellidos = new Label();
            textBox1 = new TextBox();
            txtNombre = new Label();
            cboCitas = new ComboBox();
            label3 = new Label();
            lblHeader = new Label();
            cmdSalir = new Button();
            cmdRegistrar = new Button();
            textBox7 = new TextBox();
            lblPresion = new Label();
            textBox6 = new TextBox();
            lblTemperatura = new Label();
            textBox5 = new TextBox();
            lblEstatura = new Label();
            textBox4 = new TextBox();
            lblPeso = new Label();
            txtEstudios = new RichTextBox();
            lblEstudios = new Label();
            txtTratamiento = new RichTextBox();
            lblTratamiento = new Label();
            txtDiagnostico = new TextBox();
            lblDiagnostico = new Label();
            txtSintomas = new TextBox();
            lblSintomas = new Label();
            richTextBox1 = new RichTextBox();
            lblIndicaciones = new Label();
            richTextBox2 = new RichTextBox();
            lblMedicamento = new Label();
            cmdAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(241, 91);
            cmdBuscar.Margin = new Padding(4, 3, 4, 3);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(93, 24);
            cmdBuscar.TabIndex = 142;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(828, 36);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(213, 23);
            dtpFecha.TabIndex = 141;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Enabled = false;
            lblFecha.Location = new Point(790, 40);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 140;
            lblFecha.Text = "Fecha";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(433, 324);
            dgvData.Margin = new Padding(4, 3, 4, 3);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(610, 157);
            dgvData.TabIndex = 143;
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.Location = new Point(100, 422);
            txtEnfermedades.Margin = new Padding(4, 3, 4, 3);
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(234, 117);
            txtEnfermedades.TabIndex = 260;
            txtEnfermedades.Text = "";
            // 
            // lblEnfermedadCronica
            // 
            lblEnfermedadCronica.AutoSize = true;
            lblEnfermedadCronica.Location = new Point(28, 425);
            lblEnfermedadCronica.Margin = new Padding(4, 0, 4, 0);
            lblEnfermedadCronica.Name = "lblEnfermedadCronica";
            lblEnfermedadCronica.Size = new Size(71, 30);
            lblEnfermedadCronica.TabIndex = 259;
            lblEnfermedadCronica.Text = "Enfermedad\r\nCronica";
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(100, 313);
            txtAlergias.Margin = new Padding(4, 3, 4, 3);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(234, 103);
            txtAlergias.TabIndex = 258;
            txtAlergias.Text = "";
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Location = new Point(33, 320);
            lblAlergias.Margin = new Padding(4, 0, 4, 0);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(49, 15);
            lblAlergias.TabIndex = 257;
            lblAlergias.Text = "Alergias";
            // 
            // cboSangre
            // 
            cboSangre.FormattingEnabled = true;
            cboSangre.Location = new Point(100, 282);
            cboSangre.Margin = new Padding(4, 3, 4, 3);
            cboSangre.Name = "cboSangre";
            cboSangre.Size = new Size(234, 23);
            cboSangre.TabIndex = 256;
            // 
            // lblTipoSangre
            // 
            lblTipoSangre.AutoSize = true;
            lblTipoSangre.Location = new Point(31, 287);
            lblTipoSangre.Margin = new Padding(4, 0, 4, 0);
            lblTipoSangre.Name = "lblTipoSangre";
            lblTipoSangre.Size = new Size(63, 15);
            lblTipoSangre.TabIndex = 255;
            lblTipoSangre.Text = "Tipo Sang.";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(100, 252);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(234, 23);
            dtpFechaNacimiento.TabIndex = 254;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(32, 258);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(65, 15);
            lblFechaNacimiento.TabIndex = 253;
            lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(100, 219);
            cboGenero.Margin = new Padding(4, 3, 4, 3);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(234, 23);
            cboGenero.TabIndex = 252;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(32, 227);
            lblGenero.Margin = new Padding(4, 0, 4, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 251;
            lblGenero.Text = "Genero";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(100, 187);
            maskedTextBox1.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox1.Mask = "(52) 000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(234, 23);
            maskedTextBox1.TabIndex = 250;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(207, 157);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 249;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(33, 190);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 248;
            lblTelefono.Text = "Telefono";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(100, 157);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 23);
            textBox2.TabIndex = 247;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(33, 161);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 246;
            lblApellidos.Text = "Apellidos";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(100, 128);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 245;
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(33, 132);
            txtNombre.Margin = new Padding(4, 0, 4, 0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(51, 15);
            txtNombre.TabIndex = 244;
            txtNombre.Text = "Nombre";
            // 
            // cboCitas
            // 
            cboCitas.FormattingEnabled = true;
            cboCitas.Location = new Point(32, 91);
            cboCitas.Margin = new Padding(4, 3, 4, 3);
            cboCitas.Name = "cboCitas";
            cboCitas.Size = new Size(203, 23);
            cboCitas.TabIndex = 243;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 74);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 242;
            label3.Text = "Sel. Paciente";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(25, 40);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(254, 32);
            lblHeader.TabIndex = 241;
            lblHeader.Text = "Gestor de Recetas";
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(433, 516);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(610, 23);
            cmdSalir.TabIndex = 263;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(433, 489);
            cmdRegistrar.Margin = new Padding(4, 3, 4, 3);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(610, 23);
            cmdRegistrar.TabIndex = 262;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(729, 35);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(55, 23);
            textBox7.TabIndex = 279;
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Enabled = false;
            lblPresion.Location = new Point(677, 40);
            lblPresion.Margin = new Padding(4, 0, 4, 0);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(46, 15);
            lblPresion.TabIndex = 278;
            lblPresion.Text = "Presion";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(618, 36);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(55, 23);
            textBox6.TabIndex = 277;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Enabled = false;
            lblTemperatura.Location = new Point(571, 39);
            lblTemperatura.Margin = new Padding(4, 0, 4, 0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(40, 15);
            lblTemperatura.TabIndex = 276;
            lblTemperatura.Text = "Temp.";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(511, 36);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(55, 23);
            textBox5.TabIndex = 275;
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Enabled = false;
            lblEstatura.Location = new Point(457, 39);
            lblEstatura.Margin = new Padding(4, 0, 4, 0);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(49, 15);
            lblEstatura.TabIndex = 274;
            lblEstatura.Text = "Estatura";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(392, 36);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(55, 23);
            textBox4.TabIndex = 273;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Enabled = false;
            lblPeso.Location = new Point(352, 39);
            lblPeso.Margin = new Padding(4, 0, 4, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 272;
            lblPeso.Text = "Peso";
            // 
            // txtEstudios
            // 
            txtEstudios.Enabled = false;
            txtEstudios.Location = new Point(807, 96);
            txtEstudios.Margin = new Padding(4, 3, 4, 3);
            txtEstudios.Name = "txtEstudios";
            txtEstudios.Size = new Size(234, 84);
            txtEstudios.TabIndex = 271;
            txtEstudios.Text = "";
            // 
            // lblEstudios
            // 
            lblEstudios.AutoSize = true;
            lblEstudios.Enabled = false;
            lblEstudios.Location = new Point(726, 99);
            lblEstudios.Margin = new Padding(4, 0, 4, 0);
            lblEstudios.Name = "lblEstudios";
            lblEstudios.Size = new Size(71, 15);
            lblEstudios.TabIndex = 270;
            lblEstudios.Text = "Tratamiento";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Enabled = false;
            txtTratamiento.Location = new Point(433, 96);
            txtTratamiento.Margin = new Padding(4, 3, 4, 3);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(234, 84);
            txtTratamiento.TabIndex = 269;
            txtTratamiento.Text = "";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Enabled = false;
            lblTratamiento.Location = new Point(352, 99);
            lblTratamiento.Margin = new Padding(4, 0, 4, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(71, 15);
            lblTratamiento.TabIndex = 268;
            lblTratamiento.Text = "Tratamiento";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Enabled = false;
            txtDiagnostico.Location = new Point(807, 68);
            txtDiagnostico.Margin = new Padding(4, 3, 4, 3);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(234, 23);
            txtDiagnostico.TabIndex = 267;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Enabled = false;
            lblDiagnostico.Location = new Point(726, 72);
            lblDiagnostico.Margin = new Padding(4, 0, 4, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(70, 15);
            lblDiagnostico.TabIndex = 266;
            lblDiagnostico.Text = "Diagnostico";
            // 
            // txtSintomas
            // 
            txtSintomas.Enabled = false;
            txtSintomas.Location = new Point(433, 67);
            txtSintomas.Margin = new Padding(4, 3, 4, 3);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(234, 23);
            txtSintomas.TabIndex = 265;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Enabled = false;
            lblSintomas.Location = new Point(352, 71);
            lblSintomas.Margin = new Padding(4, 0, 4, 0);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(56, 15);
            lblSintomas.TabIndex = 264;
            lblSintomas.Text = "Sintomas";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(807, 187);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(234, 103);
            richTextBox1.TabIndex = 283;
            richTextBox1.Text = "";
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Location = new Point(726, 190);
            lblIndicaciones.Margin = new Padding(4, 0, 4, 0);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new Size(73, 15);
            lblIndicaciones.TabIndex = 282;
            lblIndicaciones.Text = "Indicaciones";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(433, 187);
            richTextBox2.Margin = new Padding(4, 3, 4, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(234, 103);
            richTextBox2.TabIndex = 281;
            richTextBox2.Text = "";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(352, 187);
            lblMedicamento.Margin = new Padding(4, 0, 4, 0);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(43, 15);
            lblMedicamento.TabIndex = 280;
            lblMedicamento.Text = "Medic.";
            // 
            // cmdAgregar
            // 
            cmdAgregar.Location = new Point(433, 295);
            cmdAgregar.Margin = new Padding(4, 3, 4, 3);
            cmdAgregar.Name = "cmdAgregar";
            cmdAgregar.Size = new Size(610, 23);
            cmdAgregar.TabIndex = 284;
            cmdAgregar.Text = "Agregar";
            cmdAgregar.UseVisualStyleBackColor = true;
            cmdAgregar.Click += cmdAgregar_Click;
            // 
            // frmRecetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 562);
            Controls.Add(cmdAgregar);
            Controls.Add(richTextBox1);
            Controls.Add(lblIndicaciones);
            Controls.Add(richTextBox2);
            Controls.Add(lblMedicamento);
            Controls.Add(textBox7);
            Controls.Add(lblPresion);
            Controls.Add(textBox6);
            Controls.Add(lblTemperatura);
            Controls.Add(textBox5);
            Controls.Add(lblEstatura);
            Controls.Add(textBox4);
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
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox3);
            Controls.Add(lblTelefono);
            Controls.Add(textBox2);
            Controls.Add(lblApellidos);
            Controls.Add(textBox1);
            Controls.Add(txtNombre);
            Controls.Add(cboCitas);
            Controls.Add(label3);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Controls.Add(cmdBuscar);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Name = "frmRecetas";
            Text = "frmRecetas";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdBuscar;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private DataGridView dgvData;
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
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private Label lblTelefono;
        private TextBox textBox2;
        private Label lblApellidos;
        private TextBox textBox1;
        private Label txtNombre;
        private ComboBox cboCitas;
        private Label label3;
        private Label lblHeader;
        private Button cmdSalir;
        private Button cmdRegistrar;
        private TextBox textBox7;
        private Label lblPresion;
        private TextBox textBox6;
        private Label lblTemperatura;
        private TextBox textBox5;
        private Label lblEstatura;
        private TextBox textBox4;
        private Label lblPeso;
        private RichTextBox txtEstudios;
        private Label lblEstudios;
        private RichTextBox txtTratamiento;
        private Label lblTratamiento;
        private TextBox txtDiagnostico;
        private Label lblDiagnostico;
        private TextBox txtSintomas;
        private Label lblSintomas;
        private RichTextBox richTextBox1;
        private Label lblIndicaciones;
        private RichTextBox richTextBox2;
        private Label lblMedicamento;
        private Button cmdAgregar;
    }
}