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
            txtTelefono = new MaskedTextBox();
            lblTelefono = new Label();
            txtEnfermedades = new RichTextBox();
            lblEnfermedadCronica = new Label();
            txtAlergias = new RichTextBox();
            lblAlergias = new Label();
            cboSangre = new ComboBox();
            lblTipoSangre = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            cboGenero = new ComboBox();
            txtAMaterno = new TextBox();
            AMaterno = new Label();
            txtAPaterno = new TextBox();
            lblAPaterno = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblHeader = new Label();
            cmdPrimero = new Button();
            cmdUltimo = new Button();
            cmdSiguiente = new Button();
            cmdAnterior = new Button();
            cmdSalir = new Button();
            cmdModificar = new Button();
            cmdGrabar = new Button();
            cmdNuevo = new Button();
            lblGenero = new Label();
            txtidPaciente = new TextBox();
            lblPaciente = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(408, 62);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(726, 382);
            dgvData.TabIndex = 124;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(950, 32);
            txtBuscar.Margin = new Padding(4, 3, 4, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(97, 23);
            txtBuscar.TabIndex = 123;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(1055, 32);
            cmdBuscar.Margin = new Padding(4, 3, 4, 3);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(79, 23);
            cmdBuscar.TabIndex = 122;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(142, 185);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Mask = "(52) 000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(247, 23);
            txtTelefono.TabIndex = 121;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(31, 193);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 120;
            lblTelefono.Text = "Telefono";
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.Location = new Point(142, 445);
            txtEnfermedades.Margin = new Padding(4, 3, 4, 3);
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(247, 117);
            txtEnfermedades.TabIndex = 119;
            txtEnfermedades.Text = "";
            // 
            // lblEnfermedadCronica
            // 
            lblEnfermedadCronica.AutoSize = true;
            lblEnfermedadCronica.Location = new Point(34, 458);
            lblEnfermedadCronica.Margin = new Padding(4, 0, 4, 0);
            lblEnfermedadCronica.Name = "lblEnfermedadCronica";
            lblEnfermedadCronica.Size = new Size(71, 30);
            lblEnfermedadCronica.TabIndex = 118;
            lblEnfermedadCronica.Text = "Enfermedad\r\nCronica";
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(142, 310);
            txtAlergias.Margin = new Padding(4, 3, 4, 3);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(247, 127);
            txtAlergias.TabIndex = 117;
            txtAlergias.Text = "";
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Location = new Point(34, 314);
            lblAlergias.Margin = new Padding(4, 0, 4, 0);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(49, 15);
            lblAlergias.TabIndex = 116;
            lblAlergias.Text = "Alergias";
            // 
            // cboSangre
            // 
            cboSangre.FormattingEnabled = true;
            cboSangre.Location = new Point(142, 279);
            cboSangre.Margin = new Padding(4, 3, 4, 3);
            cboSangre.Name = "cboSangre";
            cboSangre.Size = new Size(247, 23);
            cboSangre.TabIndex = 115;
            // 
            // lblTipoSangre
            // 
            lblTipoSangre.AutoSize = true;
            lblTipoSangre.Location = new Point(31, 288);
            lblTipoSangre.Margin = new Padding(4, 0, 4, 0);
            lblTipoSangre.Name = "lblTipoSangre";
            lblTipoSangre.Size = new Size(86, 15);
            lblTipoSangre.TabIndex = 114;
            lblTipoSangre.Text = "Tipo de Sangre";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(142, 249);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(247, 23);
            dtpFechaNacimiento.TabIndex = 113;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(31, 258);
            lblFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(65, 15);
            lblFechaNacimiento.TabIndex = 112;
            lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(142, 216);
            cboGenero.Margin = new Padding(4, 3, 4, 3);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(247, 23);
            cboGenero.TabIndex = 111;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(142, 155);
            txtAMaterno.Margin = new Padding(4, 3, 4, 3);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(247, 23);
            txtAMaterno.TabIndex = 110;
            // 
            // AMaterno
            // 
            AMaterno.AutoSize = true;
            AMaterno.Location = new Point(31, 157);
            AMaterno.Margin = new Padding(4, 0, 4, 0);
            AMaterno.Name = "AMaterno";
            AMaterno.Size = new Size(73, 15);
            AMaterno.TabIndex = 109;
            AMaterno.Text = "Ap. Materno";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(142, 125);
            txtAPaterno.Margin = new Padding(4, 3, 4, 3);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(247, 23);
            txtAPaterno.TabIndex = 108;
            // 
            // lblAPaterno
            // 
            lblAPaterno.AutoSize = true;
            lblAPaterno.Location = new Point(31, 127);
            lblAPaterno.Margin = new Padding(4, 0, 4, 0);
            lblAPaterno.Name = "lblAPaterno";
            lblAPaterno.Size = new Size(69, 15);
            lblAPaterno.TabIndex = 107;
            lblAPaterno.Text = "Ap. Paterno";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(142, 91);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 23);
            txtNombre.TabIndex = 106;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 93);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 105;
            lblNombre.Text = "Nombre";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(27, 22);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(277, 32);
            lblHeader.TabIndex = 104;
            lblHeader.Text = "Gestor de Pacientes";
            // 
            // cmdPrimero
            // 
            cmdPrimero.Location = new Point(964, 480);
            cmdPrimero.Margin = new Padding(4, 3, 4, 3);
            cmdPrimero.Name = "cmdPrimero";
            cmdPrimero.Size = new Size(169, 23);
            cmdPrimero.TabIndex = 103;
            cmdPrimero.Text = "Primero";
            cmdPrimero.UseVisualStyleBackColor = true;
            cmdPrimero.Click += cmdPrimero_Click;
            // 
            // cmdUltimo
            // 
            cmdUltimo.Location = new Point(408, 482);
            cmdUltimo.Margin = new Padding(4, 3, 4, 3);
            cmdUltimo.Name = "cmdUltimo";
            cmdUltimo.Size = new Size(169, 23);
            cmdUltimo.TabIndex = 102;
            cmdUltimo.Text = "Ultimo";
            cmdUltimo.UseVisualStyleBackColor = true;
            cmdUltimo.Click += cmdUltimo_Click;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(964, 450);
            cmdSiguiente.Margin = new Padding(4, 3, 4, 3);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(169, 23);
            cmdSiguiente.TabIndex = 101;
            cmdSiguiente.Text = "Siguiente";
            cmdSiguiente.UseVisualStyleBackColor = true;
            cmdSiguiente.Click += cmdSiguiente_Click;
            // 
            // cmdAnterior
            // 
            cmdAnterior.Location = new Point(408, 452);
            cmdAnterior.Margin = new Padding(4, 3, 4, 3);
            cmdAnterior.Name = "cmdAnterior";
            cmdAnterior.Size = new Size(169, 23);
            cmdAnterior.TabIndex = 100;
            cmdAnterior.Text = "Anterior";
            cmdAnterior.UseVisualStyleBackColor = true;
            cmdAnterior.Click += cmdAnterior_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(408, 539);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(726, 23);
            cmdSalir.TabIndex = 99;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(584, 482);
            cmdModificar.Margin = new Padding(4, 3, 4, 3);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(373, 23);
            cmdModificar.TabIndex = 98;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            cmdModificar.Click += cmdModificar_Click;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(408, 510);
            cmdGrabar.Margin = new Padding(4, 3, 4, 3);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(726, 23);
            cmdGrabar.TabIndex = 97;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(584, 453);
            cmdNuevo.Margin = new Padding(4, 3, 4, 3);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(373, 23);
            cmdNuevo.TabIndex = 96;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            cmdNuevo.Click += cmdNuevo_Click;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(32, 225);
            lblGenero.Margin = new Padding(4, 0, 4, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 95;
            lblGenero.Text = "Genero";
            // 
            // txtidPaciente
            // 
            txtidPaciente.Enabled = false;
            txtidPaciente.Location = new Point(142, 62);
            txtidPaciente.Margin = new Padding(4, 3, 4, 3);
            txtidPaciente.Name = "txtidPaciente";
            txtidPaciente.Size = new Size(57, 23);
            txtidPaciente.TabIndex = 94;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(31, 68);
            lblPaciente.Margin = new Padding(4, 0, 4, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(62, 15);
            lblPaciente.TabIndex = 93;
            lblPaciente.Text = "idPaciente";
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 576);
            Controls.Add(dgvData);
            Controls.Add(txtBuscar);
            Controls.Add(cmdBuscar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtEnfermedades);
            Controls.Add(lblEnfermedadCronica);
            Controls.Add(txtAlergias);
            Controls.Add(lblAlergias);
            Controls.Add(cboSangre);
            Controls.Add(lblTipoSangre);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(cboGenero);
            Controls.Add(txtAMaterno);
            Controls.Add(AMaterno);
            Controls.Add(txtAPaterno);
            Controls.Add(lblAPaterno);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblHeader);
            Controls.Add(cmdPrimero);
            Controls.Add(cmdUltimo);
            Controls.Add(cmdSiguiente);
            Controls.Add(cmdAnterior);
            Controls.Add(cmdSalir);
            Controls.Add(cmdModificar);
            Controls.Add(cmdGrabar);
            Controls.Add(cmdNuevo);
            Controls.Add(lblGenero);
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
        private MaskedTextBox txtTelefono;
        private Label lblTelefono;
        private RichTextBox txtEnfermedades;
        private Label lblEnfermedadCronica;
        private RichTextBox txtAlergias;
        private Label lblAlergias;
        private ComboBox cboSangre;
        private Label lblTipoSangre;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private ComboBox cboGenero;
        private TextBox txtAMaterno;
        private Label AMaterno;
        private TextBox txtAPaterno;
        private Label lblAPaterno;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblHeader;
        private Button cmdPrimero;
        private Button cmdUltimo;
        private Button cmdSiguiente;
        private Button cmdAnterior;
        private Button cmdSalir;
        private Button cmdModificar;
        private Button cmdGrabar;
        private Button cmdNuevo;
        private Label lblGenero;
        private TextBox txtidPaciente;
        private Label lblPaciente;
    }
}