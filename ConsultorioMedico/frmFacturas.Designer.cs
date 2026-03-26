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
            lblIdFactura = new Label();
            cmdRegistrar = new Button();
            comboBox2 = new ComboBox();
            lblIdCliente = new Label();
            comboBox1 = new ComboBox();
            lblIdCobro = new Label();
            lblHeader = new Label();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(47, 178);
            cmdSalir.Margin = new Padding(4, 3, 4, 3);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(174, 23);
            cmdSalir.TabIndex = 309;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // lblIdFactura
            // 
            lblIdFactura.AutoSize = true;
            lblIdFactura.Location = new Point(43, 102);
            lblIdFactura.Margin = new Padding(4, 0, 4, 0);
            lblIdFactura.Name = "lblIdFactura";
            lblIdFactura.Size = new Size(59, 15);
            lblIdFactura.TabIndex = 308;
            lblIdFactura.Text = "id Factura";
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(47, 149);
            cmdRegistrar.Margin = new Padding(4, 3, 4, 3);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(174, 23);
            cmdRegistrar.TabIndex = 307;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 120);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(51, 23);
            comboBox2.TabIndex = 304;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(106, 101);
            lblIdCliente.Margin = new Padding(4, 0, 4, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(57, 15);
            lblIdCliente.TabIndex = 303;
            lblIdCliente.Text = "id Cliente";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(51, 23);
            comboBox1.TabIndex = 302;
            // 
            // lblIdCobro
            // 
            lblIdCobro.AutoSize = true;
            lblIdCobro.Location = new Point(168, 101);
            lblIdCobro.Margin = new Padding(4, 0, 4, 0);
            lblIdCobro.Name = "lblIdCobro";
            lblIdCobro.Size = new Size(53, 15);
            lblIdCobro.TabIndex = 301;
            lblIdCobro.Text = "id Cobro";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(39, 33);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(142, 64);
            lblHeader.TabIndex = 292;
            lblHeader.Text = "Gestor de\r\nFacturas";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(47, 120);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(51, 23);
            comboBox3.TabIndex = 310;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 240);
            Controls.Add(comboBox3);
            Controls.Add(cmdSalir);
            Controls.Add(lblIdFactura);
            Controls.Add(cmdRegistrar);
            Controls.Add(comboBox2);
            Controls.Add(lblIdCliente);
            Controls.Add(comboBox1);
            Controls.Add(lblIdCobro);
            Controls.Add(lblHeader);
            Name = "frmFacturas";
            Text = "frmFacturas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdSalir;
        private Label lblIdFactura;
        private Button cmdRegistrar;
        private ComboBox comboBox2;
        private Label lblIdCliente;
        private ComboBox comboBox1;
        private Label lblIdCobro;
        private Label lblHeader;
        private ComboBox comboBox3;
    }
}