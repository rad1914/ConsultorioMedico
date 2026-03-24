using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class frmRecetas : Form
    {
        public frmRecetas()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            // dgvRows.add
        }
    }
}
diff--git a/frmRecetas.cs b/frmRecetas.cs
index 1234567..89abcde 100644
--- a/frmRecetas.cs
+++ b/frmRecetas.cs
@@ -44,6 +44,8 @@ namespace ConsultorioMedico
         private void cboCitas_SelectedIndexChanged(object sender, EventArgs e)
{
    +            if (citasBS.Current == null) return;
    +
                 DataRowView row = (DataRowView)citasBS.Current;

    int idCita = Convert.ToInt32(row["IdCita"]);
@@ -119,6 + 121,10 @@ namespace ConsultorioMedico
             adapterCitas.Fill(tablaCitas);
conn.Close();

+            if (tablaCitas.Rows.Count == 0)
+            {
+                MessageBox.Show("No hay citas para esa fecha");
+                return;
+            }

citasBS.DataSource = tablaCitas;

@@ -126,6 +132,10 @@ namespace ConsultorioMedico
             cboCitas.DisplayMember = "IdCita";
             cboCitas.ValueMember = "IdCita";
