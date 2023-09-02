using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacturacionAPP.DataBase;

namespace FacturacionAPP.Formularios
{
    public partial class frmConsultaFactura : Form
    {
        public frmConsultaFactura()
        {
            InitializeComponent();
        }

        private void frmConsultaFactura_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
            dtpFechaHasta.Value = DateTime.Today;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<parametro> lista= new List<parametro>();
            lista.Add(new parametro("@fecha_desde",dtpFechaDesde.Value));
            lista.Add(new parametro("@fecha_hasta", dtpFechaHasta.Value));
            lista.Add(new parametro("@cliente", txtCliente.Text));
            dgvConsultaFactura.Rows.Clear();

            DataTable tabla = new BDhelper().consultarFacturas("SP_CONSULTAR_FACTURAS", lista);
            foreach (DataRow fila in tabla.Rows)
            {
                dgvConsultaFactura.Rows.Add(new object[] {fila["id_factura"].ToString(),
                                                        ((DateTime)fila["fecha"]).ToShortDateString(),
                                                          fila["cliente"].ToString(),
                                                            fila["total"].ToString()});
            }


        }

        private void dgvConsultaFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaFactura.CurrentCell.ColumnIndex == 4)
            {
                int nro = int.Parse(dgvConsultaFactura.CurrentRow.Cells["ColID"].Value.ToString());
                new frmDetalleFacturas(nro).ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
