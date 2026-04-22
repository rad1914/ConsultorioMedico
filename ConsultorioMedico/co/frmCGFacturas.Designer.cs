namespace ConsultorioMedico
{
    partial class frmCGFacturas
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
            lblFechaFinal = new Label();
            dtpFechaFinal = new DateTimePicker();
            lblFechaInicial = new Label();
            dtpFechaInicial = new DateTimePicker();
            lblFacturas = new Label();
            cmdBuscar = new Button();
            cmdSalir = new Button();
            lblHeader = new Label();
            dgvData = new DataGridView();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Location = new Point(76, 149);
            lblFechaFinal.Margin = new Padding(4, 0, 4, 0);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(70, 12);
            lblFechaFinal.TabIndex = 379;
            lblFechaFinal.Text = "Fecha Final";
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(77, 164);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(210, 23);
            dtpFechaFinal.TabIndex = 378;
            // 
            // lblFechaInicial
            // 
            lblFechaInicial.AutoSize = true;
            lblFechaInicial.Location = new Point(76, 106);
            lblFechaInicial.Margin = new Padding(4, 0, 4, 0);
            lblFechaInicial.Name = "lblFechaInicial";
            lblFechaInicial.Size = new Size(76, 12);
            lblFechaInicial.TabIndex = 377;
            lblFechaInicial.Text = "Fecha Inicial";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Location = new Point(77, 121);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(210, 23);
            dtpFechaInicial.TabIndex = 376;
            // 
            // lblFacturas
            // 
            lblFacturas.AutoSize = true;
            lblFacturas.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFacturas.ForeColor = SystemColors.ActiveCaptionText;
            lblFacturas.Location = new Point(68, 43);
            lblFacturas.Margin = new Padding(4, 0, 4, 0);
            lblFacturas.Name = "lblFacturas";
            lblFacturas.Size = new Size(161, 41);
            lblFacturas.TabIndex = 375;
            lblFacturas.Text = "Facturas";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(77, 192);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(211, 22);
            cmdBuscar.TabIndex = 374;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(77, 218);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(210, 26);
            cmdSalir.TabIndex = 373;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = SystemColors.ControlDarkDark;
            lblHeader.Location = new Point(72, 81);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(141, 19);
            lblHeader.TabIndex = 372;
            lblHeader.Text = "Consulta General";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(295, 56);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(731, 188);
            dgvData.TabIndex = 371;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, -30);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 328);
            dataGridView1.TabIndex = 380;
            // 
            // frmCGFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 277);
            Controls.Add(dataGridView1);
            Controls.Add(lblFechaFinal);
            Controls.Add(dtpFechaFinal);
            Controls.Add(lblFechaInicial);
            Controls.Add(dtpFechaInicial);
            Controls.Add(lblFacturas);
            Controls.Add(cmdBuscar);
            Controls.Add(cmdSalir);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Name = "frmCGFacturas";
            Text = "frmCGFacturas";
            Load += frmCGFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaFinal;
        private DateTimePicker dtpFechaFinal;
        private Label lblFechaInicial;
        private DateTimePicker dtpFechaInicial;
        private Label lblFacturas;
        private Button cmdBuscar;
        private Button cmdSalir;
        private Label lblHeader;
        private DataGridView dgvData;
        private DataGridView dataGridView1;
    }
}