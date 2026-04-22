using ConsultorioMedico;
using ConsultorioMedico;
using System;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmCitas = new frmCitas();
            FrmCitas.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmExpedientes = new frmExpedientes();
            FrmExpedientes.Show();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmRecetas = new frmRecetas();
            FrmRecetas.Show();
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmCobros = new frmCobros();
            FrmCobros.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmFacturas = new frmFacturas();
            FrmFacturas.Show();
        }

        private void pacientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var FrmPacientes = new frmPacientes();
            FrmPacientes.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var FrmClientes = new frmClientes();
            FrmClientes.Show();
        }

        private void medicosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var FrmMedicos = new frmMedicos();
            FrmMedicos.Show();
        }

        private void consIndivCobrosIdCobroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var FrmCICobros = new frmCICobros();
            FrmCICobros.Show();
        }

        private void consIndivRecetaIdRecetaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var FrmCIRecetas = new frmCIRecetas();
            FrmCIRecetas.Show();
        }

        private void consGralCobrosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmCGCobros = new frmCGCobros();
            FrmCGCobros.Show();
        }

        private void consIndivFactuasIdFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmCIFacturas = new frmCIFacturas();
            FrmCIFacturas.Show();
        }

        private void consGralFacturasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmCGFacturas = new frmCGFacturas();
            FrmCGFacturas.Show();
        }

        private void gestorDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmReportes = new frmReportes();
            FrmReportes.Show();
        }
    }
}