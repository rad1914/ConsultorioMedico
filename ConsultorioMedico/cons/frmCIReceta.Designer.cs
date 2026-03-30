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
            txtIdExpediente = new TextBox();
            cboIdReceta = new ComboBox();
            label3 = new Label();
            cmdAgregar = new Button();
            txtIndicaciones = new RichTextBox();
            lblIndicaciones = new Label();
            txtMedicamento = new RichTextBox();
            cmdSalir = new Button();
            cmdRegistrar = new Button();
            lblHeader = new Label();
            dgvData = new DataGridView();
            cboIdPaciente = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtIdExpediente
            // 
            txtIdExpediente.Location = new Point(477, 33);
            txtIdExpediente.Name = "txtIdExpediente";
            txtIdExpediente.Size = new Size(100, 23);
            txtIdExpediente.TabIndex = 345;
            // 
            // cboIdReceta
            // 
            cboIdReceta.FormattingEnabled = true;
            cboIdReceta.Location = new Point(102, 69);
            cboIdReceta.Margin = new Padding(4, 3, 4, 3);
            cboIdReceta.Name = "cboIdReceta";
            cboIdReceta.Size = new Size(191, 23);
            cboIdReceta.TabIndex = 344;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 74);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 343;
            label3.Text = "Sel. Paciente";
            // 
            // cmdAgregar
            // 
            cmdAgregar.Location = new Point(32, 178);
            cmdAgregar.Margin = new Padding(4, 3, 4, 3);
            cmdAgregar.Name = "cmdAgregar";
            cmdAgregar.Size = new Size(563, 23);
            cmdAgregar.TabIndex = 342;
            cmdAgregar.Text = "Agregar";
            cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(361, 116);
            txtIndicaciones.Margin = new Padding(4, 3, 4, 3);
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(234, 57);
            txtIndicaciones.TabIndex = 341;
            txtIndicaciones.Text = "";
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Location = new Point(279, 117);
            lblIndicaciones.Margin = new Padding(4, 0, 4, 0);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new Size(73, 15);
            lblIndicaciones.TabIndex = 340;
            lblIndicaciones.Text = "Indicaciones";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(33, 116);
            txtMedicamento.Margin = new Padding(4, 3, 4, 3);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(234, 57);
            txtMedicamento.TabIndex = 339;
            txtMedicamento.Text = "";
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(33, 391);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(562, 23);
            cmdSalir.TabIndex = 338;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(33, 362);
            cmdRegistrar.Margin = new Padding(4, 3, 4, 3);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(562, 23);
            cmdRegistrar.TabIndex = 337;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(27, 23);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(254, 32);
            lblHeader.TabIndex = 336;
            lblHeader.Text = "Gestor de Recetas";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(33, 207);
            dgvData.Margin = new Padding(4, 3, 4, 3);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(562, 147);
            dgvData.TabIndex = 335;
            // 
            // cboIdPaciente
            // 
            cboIdPaciente.FormattingEnabled = true;
            cboIdPaciente.Location = new Point(335, 69);
            cboIdPaciente.Margin = new Padding(4, 3, 4, 3);
            cboIdPaciente.Name = "cboIdPaciente";
            cboIdPaciente.Size = new Size(191, 23);
            cboIdPaciente.TabIndex = 346;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(644, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 347;
            // 
            // frmCIReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(cboIdPaciente);
            Controls.Add(txtIdExpediente);
            Controls.Add(cboIdReceta);
            Controls.Add(label3);
            Controls.Add(cmdAgregar);
            Controls.Add(txtIndicaciones);
            Controls.Add(lblIndicaciones);
            Controls.Add(txtMedicamento);
            Controls.Add(cmdSalir);
            Controls.Add(cmdRegistrar);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Name = "frmCIReceta";
            Text = "frmCIReceta";
            Load += frmCIReceta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdExpediente;
        private ComboBox cboIdReceta;
        private Label label3;
        private Button cmdAgregar;
        private RichTextBox txtIndicaciones;
        private Label lblIndicaciones;
        private RichTextBox txtMedicamento;
        private Button cmdSalir;
        private Button cmdRegistrar;
        private Label lblHeader;
        private DataGridView dgvData;
        private ComboBox cboIdPaciente;
        private TextBox textBox1;
    }
}