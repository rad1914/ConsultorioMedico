using System;
using System.IO;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmAyuda : Form
    {
        private readonly string helpFile;

        public frmAyuda()
        {
            InitializeComponent();

            helpFile = Path.Combine(
                Application.StartupPath,
                @"a\ConsultorioMedico.chm");
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            if (!File.Exists(helpFile))
            {
                MessageBox.Show(
                    "Archivo de ayuda no encontrado:\n\n" + helpFile,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }

        private void AbrirTema(string archivo)
        {
            Help.ShowHelp(
                this,
                helpFile,
                HelpNavigator.Topic,
                archivo);
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("PRINCIPAL.HTML");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("CLIENTES.HTML");
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("PACIENTES.HTML");
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("MEDICOS.HTML");
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("CITAS.HTML");
        }

        private void expedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("EXPEDIENTES.HTML");
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("RECETAS.HTML");
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("COBROS.HTML");
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("FACTURAS.HTML");
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTema("REPORTES.HTML");
        }

        private void contenidoCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(
                this,
                helpFile,
                HelpNavigator.TableOfContents);
        }

        private void indiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(
                this,
                helpFile,
                HelpNavigator.Index);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(
                this,
                helpFile,
                HelpNavigator.Find);
        }
    }
}