namespace ConsultorioMedico
{
    public partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            cmdGetPacientes = new Button();
            cmdGetClientes = new Button();
            cmdGetCitasPorEstadoFecha = new Button();
            cmdGetCobrosPorPeriodo = new Button();
            cmdGetFacturasPorPeriodo = new Button();
            cmdGetExpedientePorPaciente = new Button();
            cmdSalir = new Button();
            dataGridView1 = new DataGridView();
            lblHeader = new Label();
            label1 = new Label();
            grpConsultas1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            grpConsultas2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            grpConsultas3 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            grpConsultas0 = new GroupBox();
            label17 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpConsultas1.SuspendLayout();
            grpConsultas2.SuspendLayout();
            grpConsultas3.SuspendLayout();
            grpConsultas0.SuspendLayout();
            SuspendLayout();
            // 
            // cmdGetPacientes
            // 
            cmdGetPacientes.Location = new Point(278, 49);
            cmdGetPacientes.Name = "cmdGetPacientes";
            cmdGetPacientes.Size = new Size(138, 25);
            cmdGetPacientes.TabIndex = 0;
            cmdGetPacientes.Text = "Ejecutar";
            cmdGetPacientes.UseVisualStyleBackColor = true;
            cmdGetPacientes.Click += cmdGetPacientes_Click;
            // 
            // cmdGetClientes
            // 
            cmdGetClientes.Location = new Point(278, 108);
            cmdGetClientes.Name = "cmdGetClientes";
            cmdGetClientes.Size = new Size(138, 23);
            cmdGetClientes.TabIndex = 1;
            cmdGetClientes.Text = "Ejecutar";
            cmdGetClientes.UseVisualStyleBackColor = true;
            cmdGetClientes.Click += cmdGetClientes_Click;
            // 
            // cmdGetCitasPorEstadoFecha
            // 
            cmdGetCitasPorEstadoFecha.Location = new Point(277, 50);
            cmdGetCitasPorEstadoFecha.Name = "cmdGetCitasPorEstadoFecha";
            cmdGetCitasPorEstadoFecha.Size = new Size(138, 25);
            cmdGetCitasPorEstadoFecha.TabIndex = 2;
            cmdGetCitasPorEstadoFecha.Text = "Ejecutar";
            cmdGetCitasPorEstadoFecha.UseVisualStyleBackColor = true;
            cmdGetCitasPorEstadoFecha.Click += cmdCitasPorEstadoFecha_Click;
            // 
            // cmdGetCobrosPorPeriodo
            // 
            cmdGetCobrosPorPeriodo.Location = new Point(277, 49);
            cmdGetCobrosPorPeriodo.Name = "cmdGetCobrosPorPeriodo";
            cmdGetCobrosPorPeriodo.Size = new Size(138, 23);
            cmdGetCobrosPorPeriodo.TabIndex = 3;
            cmdGetCobrosPorPeriodo.Text = "Ejecutar";
            cmdGetCobrosPorPeriodo.UseVisualStyleBackColor = true;
            cmdGetCobrosPorPeriodo.Click += cmdCobrosPorPeriodo_Click;
            // 
            // cmdGetFacturasPorPeriodo
            // 
            cmdGetFacturasPorPeriodo.Location = new Point(277, 106);
            cmdGetFacturasPorPeriodo.Name = "cmdGetFacturasPorPeriodo";
            cmdGetFacturasPorPeriodo.Size = new Size(138, 23);
            cmdGetFacturasPorPeriodo.TabIndex = 4;
            cmdGetFacturasPorPeriodo.Text = "Ejecutar";
            cmdGetFacturasPorPeriodo.UseVisualStyleBackColor = true;
            cmdGetFacturasPorPeriodo.Click += cmdFacturasPorPeriodo_Click;
            // 
            // cmdGetExpedientePorPaciente
            // 
            cmdGetExpedientePorPaciente.Location = new Point(277, 100);
            cmdGetExpedientePorPaciente.Name = "cmdGetExpedientePorPaciente";
            cmdGetExpedientePorPaciente.Size = new Size(138, 23);
            cmdGetExpedientePorPaciente.TabIndex = 5;
            cmdGetExpedientePorPaciente.Text = "Ejecutar";
            cmdGetExpedientePorPaciente.UseVisualStyleBackColor = true;
            cmdGetExpedientePorPaciente.Click += cmdExpedientePorPaciente_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(433, 426);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(209, 24);
            cmdSalir.TabIndex = 6;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-8, -38);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 560);
            dataGridView1.TabIndex = 72;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblHeader.Location = new Point(69, 42);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(269, 32);
            lblHeader.TabIndex = 69;
            lblHeader.Text = "Gestor de Reportes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 16);
            label1.TabIndex = 73;
            label1.Text = "Reporte de Pacientes:";
            // 
            // grpConsultas1
            // 
            grpConsultas1.Controls.Add(label3);
            grpConsultas1.Controls.Add(label4);
            grpConsultas1.Controls.Add(label2);
            grpConsultas1.Controls.Add(cmdGetClientes);
            grpConsultas1.Controls.Add(label1);
            grpConsultas1.Controls.Add(cmdGetPacientes);
            grpConsultas1.Location = new Point(75, 254);
            grpConsultas1.Name = "grpConsultas1";
            grpConsultas1.Size = new Size(457, 162);
            grpConsultas1.TabIndex = 74;
            grpConsultas1.TabStop = false;
            grpConsultas1.Text = "Consultas Generales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 24);
            label2.TabIndex = 75;
            label2.Text = "Generar reporte general con todos\r\nlos datos de los pacientes del sistema.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 111);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(214, 24);
            label3.TabIndex = 77;
            label3.Text = "Generar reporte general con todos\r\nlos datos de los clientes del sistema.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 92);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 16);
            label4.TabIndex = 76;
            label4.Text = "Reporte de Clientes";
            // 
            // grpConsultas2
            // 
            grpConsultas2.Controls.Add(label13);
            grpConsultas2.Controls.Add(label7);
            grpConsultas2.Controls.Add(label8);
            grpConsultas2.Controls.Add(label14);
            grpConsultas2.Controls.Add(cmdGetCitasPorEstadoFecha);
            grpConsultas2.Controls.Add(cmdGetExpedientePorPaciente);
            grpConsultas2.Location = new Point(538, 77);
            grpConsultas2.Name = "grpConsultas2";
            grpConsultas2.Size = new Size(457, 171);
            grpConsultas2.TabIndex = 78;
            grpConsultas2.TabStop = false;
            grpConsultas2.Text = "Consultas Citas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 54);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(217, 24);
            label5.TabIndex = 77;
            label5.Text = "Generar reporte con todos los datos\r\nde los cobros en un periodo.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(204, 16);
            label6.TabIndex = 76;
            label6.Text = "Reporte de Cobros por Periodo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 56);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(217, 24);
            label7.TabIndex = 75;
            label7.Text = "Generar reporte integral con todas\r\nlas citas con un estado determinado.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 37);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(187, 16);
            label8.TabIndex = 73;
            label8.Text = "Reporte de Citas por Estado:";
            // 
            // grpConsultas3
            // 
            grpConsultas3.Controls.Add(label5);
            grpConsultas3.Controls.Add(label11);
            grpConsultas3.Controls.Add(label6);
            grpConsultas3.Controls.Add(label12);
            grpConsultas3.Controls.Add(cmdGetCobrosPorPeriodo);
            grpConsultas3.Controls.Add(cmdGetFacturasPorPeriodo);
            grpConsultas3.Location = new Point(538, 254);
            grpConsultas3.Name = "grpConsultas3";
            grpConsultas3.Size = new Size(457, 162);
            grpConsultas3.TabIndex = 78;
            grpConsultas3.TabStop = false;
            grpConsultas3.Text = "Consultas Pagos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 111);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(172, 24);
            label11.TabIndex = 77;
            label11.Text = "Generar reporte de todas las\r\nfacturas durante periodos.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(24, 92);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(209, 16);
            label12.TabIndex = 76;
            label12.Text = "Reporte de Factuas por Periodo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 119);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(200, 24);
            label13.TabIndex = 75;
            label13.Text = "Generar reporte específico con el\r\nexpediente de un paciente.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(24, 100);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(238, 16);
            label14.TabIndex = 73;
            label14.Text = "Reporte de Expediente por Paciente";
            // 
            // grpConsultas0
            // 
            grpConsultas0.Controls.Add(label17);
            grpConsultas0.Controls.Add(label18);
            grpConsultas0.Location = new Point(75, 77);
            grpConsultas0.Name = "grpConsultas0";
            grpConsultas0.Size = new Size(457, 171);
            grpConsultas0.TabIndex = 79;
            grpConsultas0.TabStop = false;
            grpConsultas0.Text = "Instrucciones";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(24, 54);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(407, 96);
            label17.TabIndex = 75;
            label17.Text = resources.GetString("label17.Text");
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(24, 35);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(186, 16);
            label18.TabIndex = 73;
            label18.Text = "Instrucciones e Indicaciones";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 468);
            Controls.Add(grpConsultas0);
            Controls.Add(grpConsultas3);
            Controls.Add(grpConsultas2);
            Controls.Add(grpConsultas1);
            Controls.Add(dataGridView1);
            Controls.Add(lblHeader);
            Controls.Add(cmdSalir);
            Name = "frmReportes";
            Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpConsultas1.ResumeLayout(false);
            grpConsultas1.PerformLayout();
            grpConsultas2.ResumeLayout(false);
            grpConsultas2.PerformLayout();
            grpConsultas3.ResumeLayout(false);
            grpConsultas3.PerformLayout();
            grpConsultas0.ResumeLayout(false);
            grpConsultas0.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdGetPacientes;
        private Button cmdGetClientes;
        private Button cmdGetCitasPorEstadoFecha;
        private Button cmdGetCobrosPorPeriodo;
        private Button cmdGetFacturasPorPeriodo;
        private Button cmdGetExpedientePorPaciente;
        private Button cmdSalir;
        private DataGridView dataGridView1;
        private Label lblHeader;
        private Label label1;
        private GroupBox grpConsultas1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox grpConsultas2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox grpConsultas3;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button1;
        private Label label14;
        private GroupBox grpConsultas0;
        private Label label17;
        private Label label18;
    }
}