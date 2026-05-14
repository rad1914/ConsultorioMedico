namespace ConsultorioMedico
{
    partial class frmAyuda
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
            menuStrip1 = new MenuStrip();
            ayudaCatalogosToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            ayudToolStripMenuItem = new ToolStripMenuItem();
            medicosToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            expedientesToolStripMenuItem = new ToolStripMenuItem();
            recetasToolStripMenuItem = new ToolStripMenuItem();
            cobrosToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            ayudaReportesToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ayudaCatalogosToolStripMenuItem, ayudToolStripMenuItem, ayudaReportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(733, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ayudaCatalogosToolStripMenuItem
            // 
            ayudaCatalogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, clientesToolStripMenuItem, medicosToolStripMenuItem });
            ayudaCatalogosToolStripMenuItem.Name = "ayudaCatalogosToolStripMenuItem";
            ayudaCatalogosToolStripMenuItem.Size = new Size(117, 20);
            ayudaCatalogosToolStripMenuItem.Text = "Ayuda Catalogos";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(180, 22);
            pacientesToolStripMenuItem.Text = "Pacientes";
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // ayudToolStripMenuItem
            // 
            ayudToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { citasToolStripMenuItem, expedientesToolStripMenuItem, recetasToolStripMenuItem, cobrosToolStripMenuItem, facturasToolStripMenuItem });
            ayudToolStripMenuItem.Name = "ayudToolStripMenuItem";
            ayudToolStripMenuItem.Size = new Size(132, 20);
            ayudToolStripMenuItem.Text = "Ayuda Movimientos";
            // 
            // medicosToolStripMenuItem
            // 
            medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            medicosToolStripMenuItem.Size = new Size(180, 22);
            medicosToolStripMenuItem.Text = "Medicos";
            medicosToolStripMenuItem.Click += medicosToolStripMenuItem_Click;
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(180, 22);
            citasToolStripMenuItem.Text = "Citas";
            citasToolStripMenuItem.Click += citasToolStripMenuItem_Click;
            // 
            // expedientesToolStripMenuItem
            // 
            expedientesToolStripMenuItem.Name = "expedientesToolStripMenuItem";
            expedientesToolStripMenuItem.Size = new Size(180, 22);
            expedientesToolStripMenuItem.Text = "Expedientes";
            expedientesToolStripMenuItem.Click += expedientesToolStripMenuItem_Click;
            // 
            // recetasToolStripMenuItem
            // 
            recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            recetasToolStripMenuItem.Size = new Size(180, 22);
            recetasToolStripMenuItem.Text = "Recetas";
            recetasToolStripMenuItem.Click += recetasToolStripMenuItem_Click;
            // 
            // cobrosToolStripMenuItem
            // 
            cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            cobrosToolStripMenuItem.Size = new Size(180, 22);
            cobrosToolStripMenuItem.Text = "Cobros";
            cobrosToolStripMenuItem.Click += cobrosToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(180, 22);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // ayudaReportesToolStripMenuItem
            // 
            ayudaReportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesToolStripMenuItem });
            ayudaReportesToolStripMenuItem.Name = "ayudaReportesToolStripMenuItem";
            ayudaReportesToolStripMenuItem.Size = new Size(111, 20);
            ayudaReportesToolStripMenuItem.Text = "Ayuda Reportes";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(180, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // frmAyuda
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 290);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAyuda";
            Text = "help";
            Load += frmAyuda_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ayudaCatalogosToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ayudToolStripMenuItem;
        private ToolStripMenuItem medicosToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private ToolStripMenuItem expedientesToolStripMenuItem;
        private ToolStripMenuItem recetasToolStripMenuItem;
        private ToolStripMenuItem cobrosToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem ayudaReportesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}