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
            cmdPrimero = new Button();
            cmdUltimo = new Button();
            cmdSiguiente = new Button();
            cmdAnterior = new Button();
            cmdSalir = new Button();
            cmdModificar = new Button();
            cmdGrabar = new Button();
            cmdNuevo = new Button();
            txtDomicilio = new TextBox();
            lblDomicilio = new Label();
            txtCedulaProfesional = new TextBox();
            lblCedulaProfesional = new Label();
            txtIdMedico = new TextBox();
            lblidMedico = new Label();
            txtTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(615, 39);
            txtBuscar.Margin = new Padding(4, 3, 4, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(117, 23);
            txtBuscar.TabIndex = 111;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(735, 39);
            cmdBuscar.Margin = new Padding(4, 3, 4, 3);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(78, 23);
            cmdBuscar.TabIndex = 110;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(38, 158);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 108;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 65);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 107;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 70);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 106;
            lblNombre.Text = "Nombre";
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedicos.Location = new Point(31, 30);
            lblMedicos.Margin = new Padding(4, 0, 4, 0);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(258, 32);
            lblMedicos.TabIndex = 105;
            lblMedicos.Text = "Gestor de Medicos";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(314, 65);
            dgvData.Margin = new Padding(4, 3, 4, 3);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(499, 230);
            dgvData.TabIndex = 104;
            // 
            // cmdPrimero
            // 
            cmdPrimero.Location = new Point(234, 214);
            cmdPrimero.Margin = new Padding(4, 3, 4, 3);
            cmdPrimero.Name = "cmdPrimero";
            cmdPrimero.Size = new Size(72, 23);
            cmdPrimero.TabIndex = 103;
            cmdPrimero.Text = "Primero";
            cmdPrimero.UseVisualStyleBackColor = true;
            // 
            // cmdUltimo
            // 
            cmdUltimo.Location = new Point(36, 214);
            cmdUltimo.Margin = new Padding(4, 3, 4, 3);
            cmdUltimo.Name = "cmdUltimo";
            cmdUltimo.Size = new Size(72, 23);
            cmdUltimo.TabIndex = 102;
            cmdUltimo.Text = "Ultimo";
            cmdUltimo.UseVisualStyleBackColor = true;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(234, 185);
            cmdSiguiente.Margin = new Padding(4, 3, 4, 3);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(72, 23);
            cmdSiguiente.TabIndex = 101;
            cmdSiguiente.Text = "Siguiente";
            cmdSiguiente.UseVisualStyleBackColor = true;
            // 
            // cmdAnterior
            // 
            cmdAnterior.Location = new Point(36, 185);
            cmdAnterior.Margin = new Padding(4, 3, 4, 3);
            cmdAnterior.Name = "cmdAnterior";
            cmdAnterior.Size = new Size(72, 23);
            cmdAnterior.TabIndex = 100;
            cmdAnterior.Text = "Anterior";
            cmdAnterior.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(36, 272);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(270, 23);
            cmdSalir.TabIndex = 99;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(114, 214);
            cmdModificar.Margin = new Padding(4, 3, 4, 3);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(115, 23);
            cmdModificar.TabIndex = 98;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(36, 243);
            cmdGrabar.Margin = new Padding(4, 3, 4, 3);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(270, 23);
            cmdGrabar.TabIndex = 97;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(114, 185);
            cmdNuevo.Margin = new Padding(4, 3, 4, 3);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(115, 23);
            cmdNuevo.TabIndex = 96;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(112, 124);
            txtDomicilio.Margin = new Padding(4, 3, 4, 3);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(194, 23);
            txtDomicilio.TabIndex = 95;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(37, 129);
            lblDomicilio.Margin = new Padding(4, 0, 4, 0);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(58, 15);
            lblDomicilio.TabIndex = 94;
            lblDomicilio.Text = "Domicilio";
            // 
            // txtCedulaProfesional
            // 
            txtCedulaProfesional.Location = new Point(112, 95);
            txtCedulaProfesional.Margin = new Padding(4, 3, 4, 3);
            txtCedulaProfesional.Name = "txtCedulaProfesional";
            txtCedulaProfesional.Size = new Size(194, 23);
            txtCedulaProfesional.TabIndex = 93;
            // 
            // lblCedulaProfesional
            // 
            lblCedulaProfesional.AutoSize = true;
            lblCedulaProfesional.Location = new Point(36, 100);
            lblCedulaProfesional.Margin = new Padding(4, 0, 4, 0);
            lblCedulaProfesional.Name = "lblCedulaProfesional";
            lblCedulaProfesional.Size = new Size(72, 15);
            lblCedulaProfesional.TabIndex = 92;
            lblCedulaProfesional.Text = "Cedula Prof.";
            // 
            // txtIdMedico
            // 
            txtIdMedico.Enabled = false;
            txtIdMedico.Location = new Point(371, 38);
            txtIdMedico.Margin = new Padding(4, 3, 4, 3);
            txtIdMedico.Name = "txtIdMedico";
            txtIdMedico.Size = new Size(36, 23);
            txtIdMedico.TabIndex = 91;
            // 
            // lblidMedico
            // 
            lblidMedico.AutoSize = true;
            lblidMedico.Location = new Point(314, 46);
            lblidMedico.Margin = new Padding(4, 0, 4, 0);
            lblidMedico.Name = "lblidMedico";
            lblidMedico.Size = new Size(57, 15);
            lblidMedico.TabIndex = 90;
            lblidMedico.Text = "idMedico";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(112, 153);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(194, 23);
            txtTelefono.TabIndex = 112;
            // 
            // frmMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 323);
            Controls.Add(txtTelefono);
            Controls.Add(txtBuscar);
            Controls.Add(cmdBuscar);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblMedicos);
            Controls.Add(dgvData);
            Controls.Add(cmdPrimero);
            Controls.Add(cmdUltimo);
            Controls.Add(cmdSiguiente);
            Controls.Add(cmdAnterior);
            Controls.Add(cmdSalir);
            Controls.Add(cmdModificar);
            Controls.Add(cmdGrabar);
            Controls.Add(cmdNuevo);
            Controls.Add(txtDomicilio);
            Controls.Add(lblDomicilio);
            Controls.Add(txtCedulaProfesional);
            Controls.Add(lblCedulaProfesional);
            Controls.Add(txtIdMedico);
            Controls.Add(lblidMedico);
            Name = "frmMedicos";
            Text = "frmMedico";
            Load += frmMedicos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
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
        private Button cmdPrimero;
        private Button cmdUltimo;
        private Button cmdSiguiente;
        private Button cmdAnterior;
        private Button cmdSalir;
        private Button cmdModificar;
        private Button cmdGrabar;
        private Button cmdNuevo;
        private TextBox txtDomicilio;
        private Label lblDomicilio;
        private TextBox txtCedulaProfesional;
        private Label lblCedulaProfesional;
        private TextBox txtIdMedico;
        private Label lblidMedico;
        private TextBox txtTelefono;
    }
}