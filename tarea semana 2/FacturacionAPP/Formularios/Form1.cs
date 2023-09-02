using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacturacionAPP.Formularios;

namespace FacturacionAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaFactura nuevo= new FrmNuevaFactura();
            nuevo.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea salir?", "confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.Yes)
            {
                Close();
            }
        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFactura nuevo = new frmConsultaFactura();
            nuevo.ShowDialog();
        }
    }
}
