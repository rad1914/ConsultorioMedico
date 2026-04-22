namespace ConsultorioMedico
{
    partial class frmClientes
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
            cmdNuevo = new Button();
            txtBuscar = new TextBox();
            cmdBuscar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtEmail = new TextBox();
            lblHeader = new Label();
            dgvData = new DataGridView();
            cmdPrimero = new Button();
            cmdUltimo = new Button();
            cmdSiguiente = new Button();
            cmdAnterior = new Button();
            cmdSalir = new Button();
            cmdModificar = new Button();
            cmdGrabar = new Button();
            lblEmail = new Label();
            txtDomicilioFiscal = new TextBox();
            lblDomicilioFiscal = new Label();
            txtRfc = new TextBox();
            lblRfc = new Label();
            txtIdCliente = new TextBox();
            lblIdCliente = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(147, 169);
            cmdNuevo.Margin = new Padding(4, 2, 4, 2);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(128, 23);
            cmdNuevo.TabIndex = 67;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            cmdNuevo.Click += cmdNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(656, 32);
            txtBuscar.Margin = new Padding(4, 2, 4, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(97, 23);
            txtBuscar.TabIndex = 66;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(757, 33);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(78, 21);
            cmdBuscar.TabIndex = 65;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 60);
            txtNombre.Margin = new Padding(4, 2, 4, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 64;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(76, 68);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 12);
            lblNombre.TabIndex = 63;
            lblNombre.Text = "Nombre";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 142);
            txtEmail.Margin = new Padding(4, 2, 4, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 62;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblHeader.Location = new Point(68, 24);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(257, 32);
            lblHeader.TabIndex = 61;
            lblHeader.Text = "Gestor de Clientes";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(354, 60);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(481, 208);
            dgvData.TabIndex = 60;
            // 
            // cmdPrimero
            // 
            cmdPrimero.Location = new Point(277, 194);
            cmdPrimero.Margin = new Padding(4, 2, 4, 2);
            cmdPrimero.Name = "cmdPrimero";
            cmdPrimero.Size = new Size(69, 23);
            cmdPrimero.TabIndex = 59;
            cmdPrimero.Text = "Primero";
            cmdPrimero.UseVisualStyleBackColor = true;
            cmdPrimero.Click += cmdPrimero_Click;
            // 
            // cmdUltimo
            // 
            cmdUltimo.Location = new Point(76, 194);
            cmdUltimo.Margin = new Padding(4, 2, 4, 2);
            cmdUltimo.Name = "cmdUltimo";
            cmdUltimo.Size = new Size(68, 23);
            cmdUltimo.TabIndex = 58;
            cmdUltimo.Text = "Ultimo";
            cmdUltimo.UseVisualStyleBackColor = true;
            cmdUltimo.Click += cmdUltimo_Click;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(277, 169);
            cmdSiguiente.Margin = new Padding(4, 2, 4, 2);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(69, 22);
            cmdSiguiente.TabIndex = 57;
            cmdSiguiente.Text = "Siguiente";
            cmdSiguiente.UseVisualStyleBackColor = true;
            cmdSiguiente.Click += cmdSiguiente_Click;
            // 
            // cmdAnterior
            // 
            cmdAnterior.Location = new Point(76, 169);
            cmdAnterior.Margin = new Padding(4, 2, 4, 2);
            cmdAnterior.Name = "cmdAnterior";
            cmdAnterior.Size = new Size(68, 23);
            cmdAnterior.TabIndex = 56;
            cmdAnterior.Text = "Anterior";
            cmdAnterior.UseVisualStyleBackColor = true;
            cmdAnterior.Click += cmdAnterior_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(76, 245);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(270, 23);
            cmdSalir.TabIndex = 55;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(147, 194);
            cmdModificar.Margin = new Padding(4, 2, 4, 2);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(128, 23);
            cmdModificar.TabIndex = 54;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            cmdModificar.Click += cmdModificar_Click;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(76, 220);
            cmdGrabar.Margin = new Padding(4, 2, 4, 2);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(270, 23);
            cmdGrabar.TabIndex = 53;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 153);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(37, 12);
            lblEmail.TabIndex = 52;
            lblEmail.Text = "Email";
            // 
            // txtDomicilioFiscal
            // 
            txtDomicilioFiscal.Location = new Point(147, 114);
            txtDomicilioFiscal.Margin = new Padding(4, 2, 4, 2);
            txtDomicilioFiscal.Name = "txtDomicilioFiscal";
            txtDomicilioFiscal.Size = new Size(197, 23);
            txtDomicilioFiscal.TabIndex = 51;
            // 
            // lblDomicilioFiscal
            // 
            lblDomicilioFiscal.AutoSize = true;
            lblDomicilioFiscal.Location = new Point(76, 122);
            lblDomicilioFiscal.Margin = new Padding(4, 0, 4, 0);
            lblDomicilioFiscal.Name = "lblDomicilioFiscal";
            lblDomicilioFiscal.Size = new Size(72, 12);
            lblDomicilioFiscal.TabIndex = 50;
            lblDomicilioFiscal.Text = "Dom. Fiscal";
            // 
            // txtRfc
            // 
            txtRfc.Location = new Point(147, 87);
            txtRfc.Margin = new Padding(4, 2, 4, 2);
            txtRfc.Name = "txtRfc";
            txtRfc.Size = new Size(197, 23);
            txtRfc.TabIndex = 49;
            // 
            // lblRfc
            // 
            lblRfc.AutoSize = true;
            lblRfc.Location = new Point(76, 95);
            lblRfc.Margin = new Padding(4, 0, 4, 0);
            lblRfc.Name = "lblRfc";
            lblRfc.Size = new Size(28, 12);
            lblRfc.TabIndex = 48;
            lblRfc.Text = "RFC";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(413, 33);
            txtIdCliente.Margin = new Padding(4, 2, 4, 2);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(47, 23);
            txtIdCliente.TabIndex = 47;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(353, 41);
            lblIdCliente.Margin = new Padding(4, 0, 4, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(55, 12);
            lblIdCliente.TabIndex = 46;
            lblIdCliente.Text = "IdCliente";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, -28);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 328);
            dataGridView1.TabIndex = 68;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 291);
            Controls.Add(dataGridView1);
            Controls.Add(cmdNuevo);
            Controls.Add(txtBuscar);
            Controls.Add(cmdBuscar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtEmail);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Controls.Add(cmdPrimero);
            Controls.Add(cmdUltimo);
            Controls.Add(cmdSiguiente);
            Controls.Add(cmdAnterior);
            Controls.Add(cmdSalir);
            Controls.Add(cmdModificar);
            Controls.Add(cmdGrabar);
            Controls.Add(lblEmail);
            Controls.Add(txtDomicilioFiscal);
            Controls.Add(lblDomicilioFiscal);
            Controls.Add(txtRfc);
            Controls.Add(lblRfc);
            Controls.Add(txtIdCliente);
            Controls.Add(lblIdCliente);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmClientes";
            Text = "frmCliente";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdNuevo;
        private TextBox txtBuscar;
        private Button cmdBuscar;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtEmail;
        private Label lblHeader;
        private DataGridView dgvData;
        private Button cmdPrimero;
        private Button cmdUltimo;
        private Button cmdSiguiente;
        private Button cmdAnterior;
        private Button cmdSalir;
        private Button cmdModificar;
        private Button cmdGrabar;
        private Label lblEmail;
        private TextBox txtDomicilioFiscal;
        private Label lblDomicilioFiscal;
        private TextBox txtRfc;
        private Label lblRfc;
        private TextBox txtIdCliente;
        private Label lblIdCliente;
        private DataGridView dataGridView1;
    }
}