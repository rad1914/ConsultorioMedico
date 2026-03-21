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

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmPacientes = new frmPacientes();
            FrmPacientes.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmClientes = new frmClientes();
            FrmClientes.Show();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmMedicos = new frmMedicos();
            FrmMedicos.Show();
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
    }
}
