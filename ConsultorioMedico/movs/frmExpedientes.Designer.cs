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
            txtAMaterno = new TextBox();
            txtAPaterno = new TextBox();
            lblApellidos = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpedientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(447, 378);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(583, 24);
            cmdSalir.TabIndex = 149;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(447, 351);
            cmdRegistrar.Margin = new Padding(4, 2, 4, 2);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(583, 24);
            cmdRegistrar.TabIndex = 142;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(937, 39);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(93, 23);
            cmdBuscar.TabIndex = 139;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(724, 39);
            dtpFecha.Margin = new Padding(4, 2, 4, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(208, 23);
            dtpFecha.TabIndex = 138;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(366, 66);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(350, 135);
            dgvData.TabIndex = 136;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(681, 48);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(40, 12);
            lblFecha.TabIndex = 134;
            lblFecha.Text = "Fecha";
            // 
            // dgvExpedientes
            // 
            dgvExpedientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpedientes.Location = new Point(724, 66);
            dgvExpedientes.Margin = new Padding(4, 2, 4, 2);
            dgvExpedientes.Name = "dgvExpedientes";
            dgvExpedientes.Size = new Size(306, 135);
            dgvExpedientes.TabIndex = 176;
            // 
            // cboCitas
            // 
            cboCitas.FormattingEnabled = true;
            cboCitas.Location = new Point(87, 76);
            cboCitas.Margin = new Padding(4, 2, 4, 2);
            cboCitas.Name = "cboCitas";
            cboCitas.Size = new Size(266, 20);
            cboCitas.TabIndex = 223;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 12);
            label3.TabIndex = 222;
            label3.Text = "Sel. Cita";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(81, 31);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(273, 29);
            lblHeader.TabIndex = 221;
            lblHeader.Text = "Gestor de Expedientes";
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Location = new Point(367, 244);
            lblSintomas.Margin = new Padding(4, 0, 4, 0);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(58, 12);
            lblSintomas.TabIndex = 241;
            lblSintomas.Text = "Sintomas";
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(450, 237);
            txtSintomas.Margin = new Padding(4, 2, 4, 2);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(234, 23);
            txtSintomas.TabIndex = 242;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(773, 237);
            txtDiagnostico.Margin = new Padding(4, 2, 4, 2);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(257, 23);
            txtDiagnostico.TabIndex = 247;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(692, 244);
            lblDiagnostico.Margin = new Padding(4, 0, 4, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(75, 12);
            lblDiagnostico.TabIndex = 246;
            lblDiagnostico.Text = "Diagnostico";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(450, 262);
            txtTratamiento.Margin = new Padding(4, 2, 4, 2);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(234, 83);
            txtTratamiento.TabIndex = 249;
            txtTratamiento.Text = "";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Location = new Point(367, 265);
            lblTratamiento.Margin = new Padding(4, 0, 4, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(76, 12);
            lblTratamiento.TabIndex = 248;
            lblTratamiento.Text = "Tratamiento";
            // 
            // txtEstudios
            // 
            txtEstudios.Location = new Point(773, 262);
            txtEstudios.Margin = new Padding(4, 2, 4, 2);
            txtEstudios.Name = "txtEstudios";
            txtEstudios.Size = new Size(257, 83);
            txtEstudios.TabIndex = 251;
            txtEstudios.Text = "";
            // 
            // lblEstudios
            // 
            lblEstudios.AutoSize = true;
            lblEstudios.Location = new Point(694, 265);
            lblEstudios.Margin = new Padding(4, 0, 4, 0);
            lblEstudios.Name = "lblEstudios";
            lblEstudios.Size = new Size(55, 12);
            lblEstudios.TabIndex = 250;
            lblEstudios.Text = "Estudios";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(487, 209);
            txtPeso.Margin = new Padding(4, 2, 4, 2);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(55, 23);
            txtPeso.TabIndex = 253;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(451, 218);
            lblPeso.Margin = new Padding(4, 0, 4, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(34, 12);
            lblPeso.TabIndex = 252;
            lblPeso.Text = "Peso";
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(629, 209);
            txtEstatura.Margin = new Padding(4, 2, 4, 2);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(55, 23);
            txtEstatura.TabIndex = 255;
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(573, 218);
            lblEstatura.Margin = new Padding(4, 0, 4, 0);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(53, 12);
            lblEstatura.TabIndex = 254;
            lblEstatura.Text = "Estatura";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(819, 209);
            txtTemperatura.Margin = new Padding(4, 2, 4, 2);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(55, 23);
            txtTemperatura.TabIndex = 257;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(773, 218);
            lblTemperatura.Margin = new Padding(4, 0, 4, 0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(42, 12);
            lblTemperatura.TabIndex = 256;
            lblTemperatura.Text = "Temp.";
            // 
            // txtPresion
            // 
            txtPresion.Location = new Point(975, 209);
            txtPresion.Margin = new Padding(4, 2, 4, 2);
            txtPresion.Name = "txtPresion";
            txtPresion.Size = new Size(55, 23);
            txtPresion.TabIndex = 259;
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Location = new Point(922, 218);
            lblPresion.Margin = new Padding(4, 0, 4, 0);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(49, 12);
            lblPresion.TabIndex = 258;
            lblPresion.Text = "Presion";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new Point(435, 39);
            txtIdPaciente.Margin = new Padding(4, 2, 4, 2);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(45, 23);
            txtIdPaciente.TabIndex = 261;
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Location = new Point(364, 47);
            lblIdPaciente.Margin = new Padding(4, 0, 4, 0);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(69, 12);
            lblIdPaciente.TabIndex = 260;
            lblIdPaciente.Text = "Id Paciente";
            // 
            // txtEnfermedadCronica
            // 
            txtEnfermedadCronica.Enabled = false;
            txtEnfermedadCronica.Location = new Point(162, 291);
            txtEnfermedadCronica.Margin = new Padding(4, 2, 4, 2);
            txtEnfermedadCronica.Name = "txtEnfermedadCronica";
            txtEnfermedadCronica.Size = new Size(191, 111);
            txtEnfermedadCronica.TabIndex = 338;
            txtEnfermedadCronica.Text = "";
            // 
            // lblEnfermedadCronica
            // 
            lblEnfermedadCronica.AutoSize = true;
            lblEnfermedadCronica.Enabled = false;
            lblEnfermedadCronica.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnfermedadCronica.Location = new Point(87, 293);
            lblEnfermedadCronica.Margin = new Padding(4, 0, 4, 0);
            lblEnfermedadCronica.Name = "lblEnfermedadCronica";
            lblEnfermedadCronica.Size = new Size(65, 26);
            lblEnfermedadCronica.TabIndex = 337;
            lblEnfermedadCronica.Text = "Enfermedad\r\nCronica";
            // 
            // txtAlergias
            // 
            txtAlergias.Enabled = false;
            txtAlergias.Location = new Point(162, 205);
            txtAlergias.Margin = new Padding(4, 2, 4, 2);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(191, 82);
            txtAlergias.TabIndex = 336;
            txtAlergias.Text = "";
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Enabled = false;
            lblAlergias.Location = new Point(87, 208);
            lblAlergias.Margin = new Padding(4, 0, 4, 0);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(53, 12);
            lblAlergias.TabIndex = 335;
            lblAlergias.Text = "Alergias";
            // 
            // cboSangre
            // 
            cboSangre.Enabled = false;
            cboSangre.FormattingEnabled = true;
            cboSangre.Location = new Point(302, 154);
            cboSangre.Margin = new Padding(4, 2, 4, 2);
            cboSangre.Name = "cboSangre";
            cboSangre.Size = new Size(51, 20);
            cboSangre.TabIndex = 334;
            // 
            // lblTipoSangre
            // 
            lblTipoSangre.AutoSize = true;
            lblTipoSangre.Enabled = false;
            lblTipoSangre.Location = new Point(225, 160);
            lblTipoSangre.Margin = new Padding(4, 0, 4, 0);
            lblTipoSangre.Name = "lblTipoSangre";
            lblTipoSangre.Size = new Size(67, 12);
            lblTipoSangre.TabIndex = 333;
            lblTipoSangre.Text = "Tipo Sang.";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Enabled = false;
            dtpFechaNacimiento.Location = new Point(162, 178);
            dtpFechaNacimiento.Margin = new Padding(4, 2, 4, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(191, 23);
            dtpFechaNacimiento.TabIndex = 332;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Enabled = false;
            lblFechaNacimiento.Location = new Point(87, 182);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(69, 12);
            lblFechaNacimiento.TabIndex = 331;
            lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // cboGenero
            // 
            cboGenero.Enabled = false;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(162, 154);
            cboGenero.Margin = new Padding(4, 2, 4, 2);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(51, 20);
            cboGenero.TabIndex = 330;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Enabled = false;
            lblGenero.Location = new Point(87, 159);
            lblGenero.Margin = new Padding(4, 0, 4, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 12);
            lblGenero.TabIndex = 329;
            lblGenero.Text = "Genero";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Enabled = false;
            txtAMaterno.Location = new Point(259, 127);
            txtAMaterno.Margin = new Padding(4, 2, 4, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(94, 23);
            txtAMaterno.TabIndex = 328;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Enabled = false;
            txtAPaterno.Location = new Point(162, 127);
            txtAPaterno.Margin = new Padding(4, 2, 4, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(95, 23);
            txtAPaterno.TabIndex = 326;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Enabled = false;
            lblApellidos.Location = new Point(87, 134);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(60, 12);
            lblApellidos.TabIndex = 325;
            lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(162, 100);
            txtNombre.Margin = new Padding(4, 2, 4, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 324;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Enabled = false;
            lblNombre.Location = new Point(87, 104);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 12);
            lblNombre.TabIndex = 323;
            lblNombre.Text = "Nombre";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-7, -28);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 487);
            dataGridView1.TabIndex = 339;
            // 
            // frmExpedientes
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 427);
            Controls.Add(dataGridView1);
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
            Controls.Add(txtAMaterno);
            Controls.Add(txtAPaterno);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmExpedientes";
            Text = "frmExpedientes";
            Load += frmExpedientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpedientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtAMaterno;
        private TextBox txtAPaterno;
        private Label lblApellidos;
        private TextBox txtNombre;
        private Label lblNombre;
        private DataGridView dataGridView1;
    }
}