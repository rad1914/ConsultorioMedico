namespace ConsultorioMedico
{
    partial class frmFacturas
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
            cboIdCliente = new ComboBox();
            lblIdCliente = new Label();
            cboIdCobro = new ComboBox();
            lblIdCobro = new Label();
            lblHeader = new Label();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(42, 183);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(182, 21);
            cmdSalir.TabIndex = 309;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click_1;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(42, 157);
            cmdRegistrar.Margin = new Padding(4, 2, 4, 2);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(182, 23);
            cmdRegistrar.TabIndex = 307;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // cboIdCliente
            // 
            cboIdCliente.FormattingEnabled = true;
            cboIdCliente.Location = new Point(108, 133);
            cboIdCliente.Margin = new Padding(3, 2, 3, 2);
            cboIdCliente.Name = "cboIdCliente";
            cboIdCliente.Size = new Size(114, 20);
            cboIdCliente.TabIndex = 304;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(37, 138);
            lblIdCliente.Margin = new Padding(4, 0, 4, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(44, 12);
            lblIdCliente.TabIndex = 303;
            lblIdCliente.Text = "Cliente";
            // 
            // cboIdCobro
            // 
            cboIdCobro.FormattingEnabled = true;
            cboIdCobro.Location = new Point(108, 109);
            cboIdCobro.Margin = new Padding(3, 2, 3, 2);
            cboIdCobro.Name = "cboIdCobro";
            cboIdCobro.Size = new Size(64, 20);
            cboIdCobro.TabIndex = 302;
            // 
            // lblIdCobro
            // 
            lblIdCobro.AutoSize = true;
            lblIdCobro.Location = new Point(38, 114);
            lblIdCobro.Margin = new Padding(4, 0, 4, 0);
            lblIdCobro.Name = "lblIdCobro";
            lblIdCobro.Size = new Size(53, 12);
            lblIdCobro.TabIndex = 301;
            lblIdCobro.Text = "idCobro";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblHeader.Location = new Point(34, 43);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(142, 64);
            lblHeader.TabIndex = 292;
            lblHeader.Text = "Gestor de\r\nFacturas";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(231, 43);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(500, 161);
            dgvData.TabIndex = 314;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 248);
            Controls.Add(dgvData);
            Controls.Add(cmdSalir);
            Controls.Add(cmdRegistrar);
            Controls.Add(cboIdCliente);
            Controls.Add(lblIdCliente);
            Controls.Add(cboIdCobro);
            Controls.Add(lblIdCobro);
            Controls.Add(lblHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFacturas";
            Text = "frmFacturas";
            Load += frmFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdSalir;
        private Button cmdRegistrar;
        private ComboBox cboIdCliente;
        private Label lblIdCliente;
        private ComboBox comboBox1;
        private Label lblIdCobro;
        private Label lblHeader;
        private ComboBox cboIdCobro;
        private DataGridView dgvData;
    }
}