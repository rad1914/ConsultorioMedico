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
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // cmdNuevo
            // 
            cmdNuevo.Location = new Point(109, 190);
            cmdNuevo.Margin = new Padding(4, 3, 4, 3);
            cmdNuevo.Name = "cmdNuevo";
            cmdNuevo.Size = new Size(121, 23);
            cmdNuevo.TabIndex = 67;
            cmdNuevo.Text = "Nuevo";
            cmdNuevo.UseVisualStyleBackColor = true;
            cmdNuevo.Click += cmdNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(652, 23);
            txtBuscar.Margin = new Padding(4, 3, 4, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(97, 23);
            txtBuscar.TabIndex = 66;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(753, 23);
            cmdBuscar.Margin = new Padding(4, 3, 4, 3);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(78, 23);
            cmdBuscar.TabIndex = 65;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 73);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 64;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 75);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 63;
            lblNombre.Text = "Nombre";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 159);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 62;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(30, 37);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(257, 32);
            lblHeader.TabIndex = 61;
            lblHeader.Text = "Gestor de Clientes";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(316, 52);
            dgvData.Margin = new Padding(4, 3, 4, 3);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(515, 246);
            dgvData.TabIndex = 60;
            // 
            // cmdPrimero
            // 
            cmdPrimero.Location = new Point(238, 219);
            cmdPrimero.Margin = new Padding(4, 3, 4, 3);
            cmdPrimero.Name = "cmdPrimero";
            cmdPrimero.Size = new Size(68, 23);
            cmdPrimero.TabIndex = 59;
            cmdPrimero.Text = "Primero";
            cmdPrimero.UseVisualStyleBackColor = true;
            cmdPrimero.Click += cmdPrimero_Click;
            // 
            // cmdUltimo
            // 
            cmdUltimo.Location = new Point(36, 219);
            cmdUltimo.Margin = new Padding(4, 3, 4, 3);
            cmdUltimo.Name = "cmdUltimo";
            cmdUltimo.Size = new Size(68, 23);
            cmdUltimo.TabIndex = 58;
            cmdUltimo.Text = "Ultimo";
            cmdUltimo.UseVisualStyleBackColor = true;
            cmdUltimo.Click += cmdUltimo_Click;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(238, 189);
            cmdSiguiente.Margin = new Padding(4, 3, 4, 3);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(68, 23);
            cmdSiguiente.TabIndex = 57;
            cmdSiguiente.Text = "Siguiente";
            cmdSiguiente.UseVisualStyleBackColor = true;
            cmdSiguiente.Click += cmdSiguiente_Click;
            // 
            // cmdAnterior
            // 
            cmdAnterior.Location = new Point(36, 190);
            cmdAnterior.Margin = new Padding(4, 3, 4, 3);
            cmdAnterior.Name = "cmdAnterior";
            cmdAnterior.Size = new Size(68, 23);
            cmdAnterior.TabIndex = 56;
            cmdAnterior.Text = "Anterior";
            cmdAnterior.UseVisualStyleBackColor = true;
            cmdAnterior.Click += cmdAnterior_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(36, 276);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(270, 23);
            cmdSalir.TabIndex = 55;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(109, 218);
            cmdModificar.Margin = new Padding(4, 3, 4, 3);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(121, 23);
            cmdModificar.TabIndex = 54;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            cmdModificar.Click += cmdModificar_Click;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(36, 247);
            cmdGrabar.Margin = new Padding(4, 3, 4, 3);
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
            lblEmail.Location = new Point(36, 162);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 52;
            lblEmail.Text = "Email";
            // 
            // txtDomicilioFiscal
            // 
            txtDomicilioFiscal.Location = new Point(109, 130);
            txtDomicilioFiscal.Margin = new Padding(4, 3, 4, 3);
            txtDomicilioFiscal.Name = "txtDomicilioFiscal";
            txtDomicilioFiscal.Size = new Size(197, 23);
            txtDomicilioFiscal.TabIndex = 51;
            // 
            // lblDomicilioFiscal
            // 
            lblDomicilioFiscal.AutoSize = true;
            lblDomicilioFiscal.Location = new Point(36, 133);
            lblDomicilioFiscal.Margin = new Padding(4, 0, 4, 0);
            lblDomicilioFiscal.Name = "lblDomicilioFiscal";
            lblDomicilioFiscal.Size = new Size(68, 15);
            lblDomicilioFiscal.TabIndex = 50;
            lblDomicilioFiscal.Text = "Dom. Fiscal";
            // 
            // txtRfc
            // 
            txtRfc.Location = new Point(109, 101);
            txtRfc.Margin = new Padding(4, 3, 4, 3);
            txtRfc.Name = "txtRfc";
            txtRfc.Size = new Size(197, 23);
            txtRfc.TabIndex = 49;
            // 
            // lblRfc
            // 
            lblRfc.AutoSize = true;
            lblRfc.Location = new Point(36, 104);
            lblRfc.Margin = new Padding(4, 0, 4, 0);
            lblRfc.Name = "lblRfc";
            lblRfc.Size = new Size(28, 15);
            lblRfc.TabIndex = 48;
            lblRfc.Text = "RFC";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(369, 25);
            txtIdCliente.Margin = new Padding(4, 3, 4, 3);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(47, 23);
            txtIdCliente.TabIndex = 47;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(313, 30);
            lblIdCliente.Margin = new Padding(4, 0, 4, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(54, 15);
            lblIdCliente.TabIndex = 46;
            lblIdCliente.Text = "IdCliente";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 325);
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
            Name = "frmClientes";
            Text = "frmCliente";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
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
    }
}