using System.Drawing;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    partial class frmCIFacturas : Form
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
            label1 = new Label();
            grpCliente = new GroupBox();
            txtDomicilio = new TextBox();
            lblDomicilio = new Label();
            txtEmail = new TextBox();
            txtCliente = new TextBox();
            lblCliente = new Label();
            lblEmail = new Label();
            lblRfc = new Label();
            txtRfc = new TextBox();
            cboIdFactura = new ComboBox();
            lblIdFactura = new Label();
            cmdBuscar = new Button();
            cmdSalir = new Button();
            lblHeader = new Label();
            dgvData = new DataGridView();
            grpPaciente = new GroupBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtPaciente = new TextBox();
            lblPaciente = new Label();
            grpPago = new GroupBox();
            txtMonto = new TextBox();
            lblMonto = new Label();
            cboTipoPago = new ComboBox();
            lblTipoPago = new Label();
            dataGridView1 = new DataGridView();
            grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            grpPaciente.SuspendLayout();
            grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 37);
            label1.TabIndex = 366;
            label1.Text = "Facturas";
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(txtDomicilio);
            grpCliente.Controls.Add(lblDomicilio);
            grpCliente.Controls.Add(txtEmail);
            grpCliente.Controls.Add(txtCliente);
            grpCliente.Controls.Add(lblCliente);
            grpCliente.Controls.Add(lblEmail);
            grpCliente.Controls.Add(lblRfc);
            grpCliente.Controls.Add(txtRfc);
            grpCliente.Location = new Point(75, 90);
            grpCliente.Margin = new Padding(3, 2, 3, 2);
            grpCliente.Name = "grpCliente";
            grpCliente.Padding = new Padding(3, 2, 3, 2);
            grpCliente.Size = new Size(301, 157);
            grpCliente.TabIndex = 364;
            grpCliente.TabStop = false;
            grpCliente.Text = "Cliente";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(94, 114);
            txtDomicilio.Margin = new Padding(4, 2, 4, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(190, 23);
            txtDomicilio.TabIndex = 357;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(19, 120);
            lblDomicilio.Margin = new Padding(4, 0, 4, 0);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(57, 12);
            lblDomicilio.TabIndex = 356;
            lblDomicilio.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 85);
            txtEmail.Margin = new Padding(4, 2, 4, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 23);
            txtEmail.TabIndex = 355;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(94, 28);
            txtCliente.Margin = new Padding(4, 2, 4, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(191, 23);
            txtCliente.TabIndex = 350;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(18, 36);
            lblCliente.Margin = new Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 12);
            lblCliente.TabIndex = 349;
            lblCliente.Text = "Cliente";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 91);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(37, 12);
            lblEmail.TabIndex = 353;
            lblEmail.Text = "Email";
            // 
            // lblRfc
            // 
            lblRfc.AutoSize = true;
            lblRfc.Location = new Point(19, 63);
            lblRfc.Margin = new Padding(4, 0, 4, 0);
            lblRfc.Name = "lblRfc";
            lblRfc.Size = new Size(28, 12);
            lblRfc.TabIndex = 351;
            lblRfc.Text = "RFC";
            // 
            // txtRfc
            // 
            txtRfc.Location = new Point(94, 56);
            txtRfc.Margin = new Padding(4, 2, 4, 2);
            txtRfc.Name = "txtRfc";
            txtRfc.Size = new Size(190, 23);
            txtRfc.TabIndex = 352;
            // 
            // cboIdFactura
            // 
            cboIdFactura.FormattingEnabled = true;
            cboIdFactura.Location = new Point(564, 70);
            cboIdFactura.Margin = new Padding(4, 2, 4, 2);
            cboIdFactura.Name = "cboIdFactura";
            cboIdFactura.Size = new Size(53, 20);
            cboIdFactura.TabIndex = 363;
            // 
            // lblIdFactura
            // 
            lblIdFactura.AutoSize = true;
            lblIdFactura.Location = new Point(499, 77);
            lblIdFactura.Margin = new Padding(4, 0, 4, 0);
            lblIdFactura.Name = "lblIdFactura";
            lblIdFactura.Size = new Size(63, 12);
            lblIdFactura.TabIndex = 362;
            lblIdFactura.Text = "Id Factura";
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(620, 71);
            cmdBuscar.Margin = new Padding(4, 2, 4, 2);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(76, 20);
            cmdBuscar.TabIndex = 361;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(75, 362);
            cmdSalir.Margin = new Padding(4, 2, 4, 2);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(621, 26);
            cmdSalir.TabIndex = 360;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = SystemColors.ControlDarkDark;
            lblHeader.Location = new Point(72, 67);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(156, 19);
            lblHeader.TabIndex = 359;
            lblHeader.Text = "Consulta Individual";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(75, 251);
            dgvData.Margin = new Padding(4, 2, 4, 2);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(621, 105);
            dgvData.TabIndex = 358;
            // 
            // grpPaciente
            // 
            grpPaciente.Controls.Add(txtTelefono);
            grpPaciente.Controls.Add(lblTelefono);
            grpPaciente.Controls.Add(txtPaciente);
            grpPaciente.Controls.Add(lblPaciente);
            grpPaciente.Location = new Point(382, 90);
            grpPaciente.Margin = new Padding(3, 2, 3, 2);
            grpPaciente.Name = "grpPaciente";
            grpPaciente.Padding = new Padding(3, 2, 3, 2);
            grpPaciente.Size = new Size(314, 90);
            grpPaciente.TabIndex = 365;
            grpPaciente.TabStop = false;
            grpPaciente.Text = "Paciente";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(76, 50);
            txtTelefono.Margin = new Padding(4, 2, 4, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 23);
            txtTelefono.TabIndex = 370;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(13, 59);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 12);
            lblTelefono.TabIndex = 369;
            lblTelefono.Text = "Telefono";
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(76, 21);
            txtPaciente.Margin = new Padding(4, 2, 4, 2);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(214, 23);
            txtPaciente.TabIndex = 368;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(13, 30);
            lblPaciente.Margin = new Padding(4, 0, 4, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(55, 12);
            lblPaciente.TabIndex = 367;
            lblPaciente.Text = "Paciente";
            // 
            // grpPago
            // 
            grpPago.Controls.Add(txtMonto);
            grpPago.Controls.Add(lblMonto);
            grpPago.Controls.Add(cboTipoPago);
            grpPago.Controls.Add(lblTipoPago);
            grpPago.Location = new Point(382, 184);
            grpPago.Margin = new Padding(3, 2, 3, 2);
            grpPago.Name = "grpPago";
            grpPago.Padding = new Padding(3, 2, 3, 2);
            grpPago.Size = new Size(314, 63);
            grpPago.TabIndex = 371;
            grpPago.TabStop = false;
            grpPago.Text = "Pago";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(76, 22);
            txtMonto.Margin = new Padding(4, 2, 4, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(65, 23);
            txtMonto.TabIndex = 377;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(14, 31);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(42, 12);
            lblMonto.TabIndex = 376;
            lblMonto.Text = "Monto";
            // 
            // cboTipoPago
            // 
            cboTipoPago.FormattingEnabled = true;
            cboTipoPago.Location = new Point(212, 24);
            cboTipoPago.Margin = new Padding(3, 2, 3, 2);
            cboTipoPago.Name = "cboTipoPago";
            cboTipoPago.Size = new Size(78, 20);
            cboTipoPago.TabIndex = 375;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(148, 27);
            lblTipoPago.Margin = new Padding(4, 0, 4, 0);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(61, 12);
            lblTipoPago.TabIndex = 374;
            lblTipoPago.Text = "Tip. Pago";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, -28);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(57, 539);
            dataGridView1.TabIndex = 372;
            // 
            // frmCIFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 417);
            Controls.Add(dataGridView1);
            Controls.Add(grpPago);
            Controls.Add(grpPaciente);
            Controls.Add(label1);
            Controls.Add(grpCliente);
            Controls.Add(cboIdFactura);
            Controls.Add(lblIdFactura);
            Controls.Add(cmdBuscar);
            Controls.Add(cmdSalir);
            Controls.Add(lblHeader);
            Controls.Add(dgvData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCIFacturas";
            Text = "frmCIFacturas";
            Load += frmCIFacturas_Load;
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            grpPaciente.ResumeLayout(false);
            grpPaciente.PerformLayout();
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpCliente;
        private TextBox txtEmail;
        private TextBox txtCliente;
        private Label lblCliente;
        private Label lblEmail;
        private Label lblRfc;
        private TextBox txtRfc;
        private ComboBox cboIdFactura;
        private Label lblIdFactura;
        private Button cmdBuscar;
        private Button cmdSalir;
        private Label lblHeader;
        private DataGridView dgvData;
        private TextBox txtDomicilio;
        private Label lblDomicilio;
        private GroupBox grpPaciente;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtPaciente;
        private Label lblPaciente;
        private GroupBox grpPago;
        private TextBox txtMonto;
        private Label lblMonto;
        private ComboBox cboTipoPago;
        private Label lblTipoPago;
        private DataGridView dataGridView1;
    }
}