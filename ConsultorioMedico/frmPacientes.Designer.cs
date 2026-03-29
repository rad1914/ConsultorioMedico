namespace ConsultorioMedico
{
    partial class frmPacientes
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
            dgvData = new DataGridView();
            txtBuscar = new TextBox();
            cmdBuscar = new Button();
            lblHeader = new Label();
            cmdPrimero = new Button();
            cmdUltimo = new Button();
            cmdSiguiente = new Button();
            cmdAnterior = new Button();
            cmdSalir = new Button();
            cmdModificar = new Button();
            cmdGrabar = new Button();
            cmdNuevo = new Button();
            txtidPaciente = new TextBox();
            lblPaciente = new Label();
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
            lblTelefono = new Label();
            txtAPaterno = new TextBox();
            lblApellidos = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(305, 67);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(551, 229);
            dgvData.TabIndex = 124;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(616, 41);
            txtBuscar.Margin = new Padding(4, 3, 4, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(158, 23);
            txtBuscar.TabIndex = 123;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(776, 41);
            cmdBuscar.Margin = new Padding(4, 3, 4, 3);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(79, 23);
            cmdBuscar.TabIndex = 122;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(27, 30);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(277, 32);
            lblHeader.TabIndex = 104;
            lblHeader.Text = "Gestor de Pacientes";
            // 
            // cmdPrimero
            // 
            cmdPrimero.Location = new Point(717, 331);
            cmdPrimero.Margin = new Padding(4, 3, 4, 3);
            cmdPrimero.Name = "cmdPrimero";
            cmdPrimero.Size = new Size(140, 26);
            cmdPrimero.TabIndex = 103;
            cmdPrimero.Text = "Primero";
            cmdPrimero.UseVisualStyleBackColor = true;
            cmdPrimero.Click += cmdPrimero_Click;
            // 
            // cmdUltimo
            // 
            cmdUltimo.Location = new Point(305, 331);
            cmdUltimo.Margin = new Padding(4, 3, 4, 3);
            cmdUltimo.Name = "cmdUltimo";
            cmdUltimo.Size = new Size(141, 26);
            cmdUltimo.TabIndex = 102;
            cmdUltimo.Text = "Ultimo";
            cmdUltimo.UseVisualStyleBackColor = true;
            cmdUltimo.Click += cmdUltimo_Click;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(717, 302);
            cmdSiguiente.Margin = new Padding(4, 3, 4, 3);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(140, 26);
            cmdSiguiente.TabIndex = 101;
            cmdSiguiente.Text = "Siguiente";
            cmdSiguiente.UseVisualStyleBackColor = true;
            cmdSiguiente.Click += cmdSiguiente_Click;
            // 
            // cmdAnterior
            // 
            cmdAnterior.Location = new Point(305, 301);
            cmdAnterior.Margin = new Padding(4, 3, 4, 3);
            cmdAnterior.Name = "cmdAnterior";
            cmdAnterior.Size = new Size(141, 26);
            cmdAnterior.TabIndex = 100;
            cmdAnterior.Text = "Anterior";
            cmdAnterior.UseVisualStyleBackColor = true;
            cmdAnterior.Click += cmdAnterior_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(305, 388);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(552, 26);
            cmdSalir.TabIndex = 99;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(454, 331);
            cmdModificar.Margin = new Padding(4, 3, 4, 3);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(255, 26);
            cmdModificar.TabIndex = 98;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            cmdModificar.Click += cmdModificar_Click;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(305, 359);
            cmdGrabar.Margin = new Padding(4, 3, 4, 3);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(552, 26);
            cmdGrabar.TabIndex = 97;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(454, 302);
            cmdNuevo.Margin = new Padding(4, 3, 4, 3);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(255, 26);
            cmdNuevo.TabIndex = 96;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            cmdNuevo.Click += cmdNuevo_Click;
            // 
            // txtidPaciente
            // 
            txtidPaciente.Enabled = false;
            txtidPaciente.Location = new Point(369, 41);
            txtidPaciente.Margin = new Padding(4, 3, 4, 3);
            txtidPaciente.Name = "txtidPaciente";
            txtidPaciente.Size = new Size(45, 23);
            txtidPaciente.TabIndex = 94;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(304, 47);
            lblPaciente.Margin = new Padding(4, 0, 4, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(62, 15);
            lblPaciente.TabIndex = 93;
            lblPaciente.Text = "idPaciente";
            // 
            // txtEnfermedadCronica
            // 
            txtEnfermedadCronica.Location = new Point(107, 292);
            txtEnfermedadCronica.Margin = new Padding(4, 3, 4, 3);
            txtEnfermedadCronica.Name = "txtEnfermedadCronica";
            txtEnfermedadCronica.Size = new Size(190, 122);
            txtEnfermedadCronica.TabIndex = 321;
            txtEnfermedadCronica.Text = "";
            // 
            // lblEnfermedadCronica
            // 
            lblEnfermedadCronica.AutoSize = true;
            lblEnfermedadCronica.Location = new Point(32, 295);
            lblEnfermedadCronica.Margin = new Padding(4, 0, 4, 0);
            lblEnfermedadCronica.Name = "lblEnfermedadCronica";
            lblEnfermedadCronica.Size = new Size(71, 30);
            lblEnfermedadCronica.TabIndex = 320;
            lblEnfermedadCronica.Text = "Enfermedad\r\nCronica";
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(107, 201);
            txtAlergias.Margin = new Padding(4, 3, 4, 3);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(191, 87);
            txtAlergias.TabIndex = 319;
            txtAlergias.Text = "";
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Location = new Point(32, 204);
            lblAlergias.Margin = new Padding(4, 0, 4, 0);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(49, 15);
            lblAlergias.TabIndex = 318;
            lblAlergias.Text = "Alergias";
            // 
            // cboSangre
            // 
            cboSangre.FormattingEnabled = true;
            cboSangre.Location = new Point(246, 147);
            cboSangre.Margin = new Padding(4, 3, 4, 3);
            cboSangre.Name = "cboSangre";
            cboSangre.Size = new Size(51, 23);
            cboSangre.TabIndex = 317;
            // 
            // lblTipoSangre
            // 
            lblTipoSangre.AutoSize = true;
            lblTipoSangre.Location = new Point(176, 151);
            lblTipoSangre.Margin = new Padding(4, 0, 4, 0);
            lblTipoSangre.Name = "lblTipoSangre";
            lblTipoSangre.Size = new Size(63, 15);
            lblTipoSangre.TabIndex = 316;
            lblTipoSangre.Text = "Tipo Sang.";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(107, 174);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(191, 23);
            dtpFechaNacimiento.TabIndex = 315;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(32, 179);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(65, 15);
            lblFechaNacimiento.TabIndex = 314;
            lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(107, 147);
            cboGenero.Margin = new Padding(4, 3, 4, 3);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(51, 23);
            cboGenero.TabIndex = 313;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(32, 152);
            lblGenero.Margin = new Padding(4, 0, 4, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 312;
            lblGenero.Text = "Genero";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(203, 93);
            txtAMaterno.Margin = new Padding(4, 3, 4, 3);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(95, 23);
            txtAMaterno.TabIndex = 310;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(32, 125);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 309;
            lblTelefono.Text = "Telefono";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(107, 93);
            txtAPaterno.Margin = new Padding(4, 3, 4, 3);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(95, 23);
            txtAPaterno.TabIndex = 308;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(32, 101);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 307;
            lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 67);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 306;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 72);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 305;
            lblNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(107, 120);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 23);
            txtTelefono.TabIndex = 322;
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 439);
            Controls.Add(txtTelefono);
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
            Controls.Add(lblTelefono);
            Controls.Add(txtAPaterno);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(dgvData);
            Controls.Add(txtBuscar);
            Controls.Add(cmdBuscar);
            Controls.Add(lblHeader);
            Controls.Add(cmdPrimero);
            Controls.Add(cmdUltimo);
            Controls.Add(cmdSiguiente);
            Controls.Add(cmdAnterior);
            Controls.Add(cmdSalir);
            Controls.Add(cmdModificar);
            Controls.Add(cmdGrabar);
            Controls.Add(cmdNuevo);
            Controls.Add(txtidPaciente);
            Controls.Add(lblPaciente);
            Name = "frmPacientes";
            Text = "frmPaciente";
            Load += frmPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private TextBox txtBuscar;
        private Button cmdBuscar;
        private Label lblHeader;
        private Button cmdPrimero;
        private Button cmdUltimo;
        private Button cmdSiguiente;
        private Button cmdAnterior;
        private Button cmdSalir;
        private Button cmdModificar;
        private Button cmdGrabar;
        private Button cmdNuevo;
        private TextBox txtidPaciente;
        private Label lblPaciente;
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
        private Label lblTelefono;
        private TextBox txtAPaterno;
        private Label lblApellidos;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtTelefono;
    }
}