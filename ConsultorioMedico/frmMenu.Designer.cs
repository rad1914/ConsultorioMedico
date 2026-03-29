using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            catalgosToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            medicosToolStripMenuItem = new ToolStripMenuItem();
            movimientosToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            recetasToolStripMenuItem = new ToolStripMenuItem();
            cobrosToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            consIndivCobrosIdCobroToolStripMenuItem = new ToolStripMenuItem();
            consIndivCobrosIdCobroToolStripMenuItem1 = new ToolStripMenuItem();
            consIndivFactuasIdFacturaToolStripMenuItem = new ToolStripMenuItem();
            consGralCobrosPorFechaToolStripMenuItem = new ToolStripMenuItem();
            consGralFacturasPorFechaToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalgosToolStripMenuItem, movimientosToolStripMenuItem, toolStripMenuItem1, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalgosToolStripMenuItem
            // 
            catalgosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, clientesToolStripMenuItem, medicosToolStripMenuItem });
            catalgosToolStripMenuItem.Name = "catalgosToolStripMenuItem";
            catalgosToolStripMenuItem.Size = new Size(72, 20);
            catalgosToolStripMenuItem.Text = "Catalogos";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(124, 22);
            pacientesToolStripMenuItem.Text = "Pacientes";
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click_1;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(124, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click_1;
            // 
            // medicosToolStripMenuItem
            // 
            medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            medicosToolStripMenuItem.Size = new Size(124, 22);
            medicosToolStripMenuItem.Text = "Medicos";
            medicosToolStripMenuItem.Click += medicosToolStripMenuItem_Click_1;
            // 
            // movimientosToolStripMenuItem
            // 
            movimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { citasToolStripMenuItem, eToolStripMenuItem, recetasToolStripMenuItem, cobrosToolStripMenuItem, facturasToolStripMenuItem });
            movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            movimientosToolStripMenuItem.Size = new Size(89, 20);
            movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(180, 22);
            citasToolStripMenuItem.Text = "Citas";
            citasToolStripMenuItem.Click += citasToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(180, 22);
            eToolStripMenuItem.Text = "Expedientes";
            eToolStripMenuItem.Click += eToolStripMenuItem_Click;
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { consIndivCobrosIdCobroToolStripMenuItem, consIndivCobrosIdCobroToolStripMenuItem1, consIndivFactuasIdFacturaToolStripMenuItem, consGralCobrosPorFechaToolStripMenuItem, consGralFacturasPorFechaToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 20);
            toolStripMenuItem1.Text = "Consultas";
            // 
            // consIndivCobrosIdCobroToolStripMenuItem
            // 
            consIndivCobrosIdCobroToolStripMenuItem.Name = "consIndivCobrosIdCobroToolStripMenuItem";
            consIndivCobrosIdCobroToolStripMenuItem.Size = new Size(233, 22);
            consIndivCobrosIdCobroToolStripMenuItem.Text = "Cons. Indiv. Receta idReceta";
            consIndivCobrosIdCobroToolStripMenuItem.Click += consIndivCobrosIdCobroToolStripMenuItem_Click;
            // 
            // consIndivCobrosIdCobroToolStripMenuItem1
            // 
            consIndivCobrosIdCobroToolStripMenuItem1.Name = "consIndivCobrosIdCobroToolStripMenuItem1";
            consIndivCobrosIdCobroToolStripMenuItem1.Size = new Size(233, 22);
            consIndivCobrosIdCobroToolStripMenuItem1.Text = "Cons. Indiv. Cobros IdCobro";
            // 
            // consIndivFactuasIdFacturaToolStripMenuItem
            // 
            consIndivFactuasIdFacturaToolStripMenuItem.Name = "consIndivFactuasIdFacturaToolStripMenuItem";
            consIndivFactuasIdFacturaToolStripMenuItem.Size = new Size(233, 22);
            consIndivFactuasIdFacturaToolStripMenuItem.Text = "Cons. Indiv. Factuas idFactura";
            // 
            // consGralCobrosPorFechaToolStripMenuItem
            // 
            consGralCobrosPorFechaToolStripMenuItem.Name = "consGralCobrosPorFechaToolStripMenuItem";
            consGralCobrosPorFechaToolStripMenuItem.Size = new Size(233, 22);
            consGralCobrosPorFechaToolStripMenuItem.Text = "Cons. Gral. Cobros por Fecha";
            // 
            // consGralFacturasPorFechaToolStripMenuItem
            // 
            consGralFacturasPorFechaToolStripMenuItem.Name = "consGralFacturasPorFechaToolStripMenuItem";
            consGralFacturasPorFechaToolStripMenuItem.Size = new Size(233, 22);
            consGralFacturasPorFechaToolStripMenuItem.Text = "Cons. Gral. Facturas por Fecha";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMenu";
            Text = "Menu";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalgosToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem medicosToolStripMenuItem;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem recetasToolStripMenuItem;
        private ToolStripMenuItem cobrosToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem consIndivCobrosIdCobroToolStripMenuItem;
        private ToolStripMenuItem consIndivCobrosIdCobroToolStripMenuItem1;
        private ToolStripMenuItem consIndivFactuasIdFacturaToolStripMenuItem;
        private ToolStripMenuItem consGralCobrosPorFechaToolStripMenuItem;
        private ToolStripMenuItem consGralFacturasPorFechaToolStripMenuItem;
    }
}
