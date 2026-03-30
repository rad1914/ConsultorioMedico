namespace ConsultorioMedico.cons
{
    partial class frmCICobros
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
            lblTitulo = new Label();
            cmdBuscar = new Button();
            cmdSalir = new Button();
            lblHeader = new Label();
            dgvData = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            lblFechaInicial = new Label();
            lblFechaFinal = new Label();
            dtpFechaFinal = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(44, 44);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(139, 41);
            lblTitulo.TabIndex = 366;
            lblTitulo.Text = "Cobros";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(51, 193);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(211, 22);
            cmdBuscar.TabIndex = 361;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(51, 219);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(210, 26);
            cmdSalir.TabIndex = 360;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(48, 82);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(156, 19);
            lblHeader.TabIndex = 359;
            lblHeader.Text = "Consulta Individual";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(274, 57);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(461, 188);
            dgvData.TabIndex = 358;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(52, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 367;
            // 
            // lblFechaInicial
            // 
            lblFechaInicial.AutoSize = true;
            lblFechaInicial.Location = new Point(51, 107);
            lblFechaInicial.Margin = new Padding(4, 0, 4, 0);
            lblFechaInicial.Name = "lblFechaInicial";
            lblFechaInicial.Size = new Size(76, 12);
            lblFechaInicial.TabIndex = 368;
            lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Location = new Point(51, 150);
            lblFechaFinal.Margin = new Padding(4, 0, 4, 0);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(70, 12);
            lblFechaFinal.TabIndex = 370;
            lblFechaFinal.Text = "Fecha Final";
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(52, 165);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(210, 23);
            dtpFechaFinal.TabIndex = 369;
            // 
            // frmCICobros
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 286);
            Controls.Add(lblFechaFinal);
            Controls.Add(dtpFechaFinal);
            Controls.Add(lblFechaInicial);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTitulo);
            Controls.Add(cmdBuscar);
            Controls.Add(cmdSalir);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Name = "frmCICobros";
            Text = "frmCICobros";
            Load += frmCICobros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button cmdBuscar;
        private Button cmdSalir;
        private Label lblHeader;
        private DataGridView dgvData;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaInicial;
        private Label lblFechaFinal;
        private DateTimePicker dtpFechaFinal;
    }
}