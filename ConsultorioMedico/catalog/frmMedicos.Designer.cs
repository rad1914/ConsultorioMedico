namespace ConsultorioMedico
{
    partial class frmMedicos
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
            txtBuscar = new TextBox();
            cmdBuscar = new Button();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblMedicos = new Label();
            dgvData = new DataGridView();
            txtDomicilio = new TextBox();
            lblDomicilio = new Label();
            txtCedulaProfesional = new TextBox();
            lblCedulaProfesional = new Label();
            txtIdMedico = new TextBox();
            lblidMedico = new Label();
            txtTelefono = new TextBox();
            cmdNuevo = new Button();
            cmdPrimero = new Button();
            cmdUltimo = new Button();
            cmdSiguiente = new Button();
            cmdAnterior = new Button();
            cmdSalir = new Button();
            cmdModificar = new Button();
            cmdGrabar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(656, 31);
            txtBuscar.Margin = new Padding(4, 2, 4, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(117, 23);
            txtBuscar.TabIndex = 111;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(776, 33);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(78, 20);
            cmdBuscar.TabIndex = 110;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(78, 144);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 12);
            lblTelefono.TabIndex = 108;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 59);
            txtNombre.Margin = new Padding(4, 2, 4, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 107;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(78, 63);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 12);
            lblNombre.TabIndex = 106;
            lblNombre.Text = "Nombre";
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblMedicos.Location = new Point(72, 25);
            lblMedicos.Margin = new Padding(4, 0, 4, 0);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(258, 32);
            lblMedicos.TabIndex = 105;
            lblMedicos.Text = "Gestor de Medicos";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(355, 57);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(499, 209);
            dgvData.TabIndex = 104;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(153, 113);
            txtDomicilio.Margin = new Padding(4, 2, 4, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(194, 23);
            txtDomicilio.TabIndex = 95;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(78, 117);
            lblDomicilio.Margin = new Padding(4, 0, 4, 0);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(60, 12);
            lblDomicilio.TabIndex = 94;
            lblDomicilio.Text = "Domicilio";
            // 
            // txtCedulaProfesional
            // 
            txtCedulaProfesional.Location = new Point(153, 86);
            txtCedulaProfesional.Margin = new Padding(4, 2, 4, 2);
            txtCedulaProfesional.Name = "txtCedulaProfesional";
            txtCedulaProfesional.Size = new Size(194, 23);
            txtCedulaProfesional.TabIndex = 93;
            // 
            // lblCedulaProfesional
            // 
            lblCedulaProfesional.AutoSize = true;
            lblCedulaProfesional.Location = new Point(78, 90);
            lblCedulaProfesional.Margin = new Padding(4, 0, 4, 0);
            lblCedulaProfesional.Name = "lblCedulaProfesional";
            lblCedulaProfesional.Size = new Size(62, 12);
            lblCedulaProfesional.TabIndex = 92;
            lblCedulaProfesional.Text = "Ced. Prof.";
            // 
            // txtIdMedico
            // 
            txtIdMedico.Enabled = false;
            txtIdMedico.Location = new Point(411, 30);
            txtIdMedico.Margin = new Padding(4, 2, 4, 2);
            txtIdMedico.Name = "txtIdMedico";
            txtIdMedico.Size = new Size(36, 23);
            txtIdMedico.TabIndex = 91;
            // 
            // lblidMedico
            // 
            lblidMedico.AutoSize = true;
            lblidMedico.Location = new Point(354, 38);
            lblidMedico.Margin = new Padding(4, 0, 4, 0);
            lblidMedico.Name = "lblidMedico";
            lblidMedico.Size = new Size(59, 12);
            lblidMedico.TabIndex = 90;
            lblidMedico.Text = "idMedico";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(153, 140);
            txtTelefono.Margin = new Padding(4, 2, 4, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(194, 23);
            txtTelefono.TabIndex = 112;
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(149, 167);
            cmdNuevo.Margin = new Padding(4, 2, 4, 2);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(128, 23);
            cmdNuevo.TabIndex = 121;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            cmdNuevo.Click += cmdNuevo_Click;
            // 
            // cmdPrimero
            // 
            cmdPrimero.Location = new Point(279, 192);
            cmdPrimero.Margin = new Padding(4, 2, 4, 2);
            cmdPrimero.Name = "cmdPrimero";
            cmdPrimero.Size = new Size(69, 23);
            cmdPrimero.TabIndex = 120;
            cmdPrimero.Text = "Primero";
            cmdPrimero.UseVisualStyleBackColor = true;
            cmdPrimero.Click += cmdPrimero_Click;
            // 
            // cmdUltimo
            // 
            cmdUltimo.Location = new Point(78, 192);
            cmdUltimo.Margin = new Padding(4, 2, 4, 2);
            cmdUltimo.Name = "cmdUltimo";
            cmdUltimo.Size = new Size(68, 23);
            cmdUltimo.TabIndex = 119;
            cmdUltimo.Text = "Ultimo";
            cmdUltimo.UseVisualStyleBackColor = true;
            cmdUltimo.Click += cmdUltimo_Click;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(279, 167);
            cmdSiguiente.Margin = new Padding(4, 2, 4, 2);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(69, 22);
            cmdSiguiente.TabIndex = 118;
            cmdSiguiente.Text = "Siguiente";
            cmdSiguiente.UseVisualStyleBackColor = true;
            cmdSiguiente.Click += cmdSiguiente_Click;
            // 
            // cmdAnterior
            // 
            cmdAnterior.Location = new Point(78, 167);
            cmdAnterior.Margin = new Padding(4, 2, 4, 2);
            cmdAnterior.Name = "cmdAnterior";
            cmdAnterior.Size = new Size(68, 23);
            cmdAnterior.TabIndex = 117;
            cmdAnterior.Text = "Anterior";
            cmdAnterior.UseVisualStyleBackColor = true;
            cmdAnterior.Click += cmdAnterior_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(78, 243);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(270, 23);
            cmdSalir.TabIndex = 116;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(149, 192);
            cmdModificar.Margin = new Padding(4, 2, 4, 2);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(128, 23);
            cmdModificar.TabIndex = 115;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            cmdModificar.Click += cmdModificar_Click;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(78, 218);
            cmdGrabar.Margin = new Padding(4, 2, 4, 2);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(270, 23);
            cmdGrabar.TabIndex = 114;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-6, -28);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 328);
            dataGridView1.TabIndex = 122;
            // 
            // frmMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 290);
            Controls.Add(dataGridView1);
            Controls.Add(cmdNuevo);
            Controls.Add(cmdPrimero);
            Controls.Add(cmdUltimo);
            Controls.Add(cmdSiguiente);
            Controls.Add(cmdAnterior);
            Controls.Add(cmdSalir);
            Controls.Add(cmdModificar);
            Controls.Add(cmdGrabar);
            Controls.Add(txtTelefono);
            Controls.Add(txtBuscar);
            Controls.Add(cmdBuscar);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblMedicos);
            Controls.Add(dgvData);
            Controls.Add(txtDomicilio);
            Controls.Add(lblDomicilio);
            Controls.Add(txtCedulaProfesional);
            Controls.Add(lblCedulaProfesional);
            Controls.Add(txtIdMedico);
            Controls.Add(lblidMedico);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMedicos";
            Text = "frmMedico";
            Load += frmMedicos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button cmdBuscar;
        private Label lblTelefono;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblMedicos;
        private DataGridView dgvData;
        private TextBox txtDomicilio;
        private Label lblDomicilio;
        private TextBox txtCedulaProfesional;
        private Label lblCedulaProfesional;
        private TextBox txtIdMedico;
        private Label lblidMedico;
        private TextBox txtTelefono;
        private Button cmdNuevo;
        private Button cmdPrimero;
        private Button cmdUltimo;
        private Button cmdSiguiente;
        private Button cmdAnterior;
        private Button cmdSalir;
        private Button cmdModificar;
        private Button cmdGrabar;
        private DataGridView dataGridView1;
    }
}