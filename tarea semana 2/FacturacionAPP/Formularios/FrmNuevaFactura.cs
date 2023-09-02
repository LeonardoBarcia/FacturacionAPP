using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FacturacionAPP.DataBase;

namespace FacturacionAPP
{
    public partial class FrmNuevaFactura : Form
    {
        BDhelper gestor;
        Factura nueva;
        public FrmNuevaFactura()
        {
            InitializeComponent();
            gestor = new BDhelper();
            nueva = new Factura();
        }


        private void FrmNuevaFactura_Load(object sender, EventArgs e)
        {
            ProximaFacturacion();
            txtFecha.Text = DateTime.Today.ToShortDateString();
            txtcliente.Text = "Consumidor final";
            txtCantidad.Text = "1";
            CargarFomarPago();
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            DataTable tabla = gestor.ConsultarFormaPago("SP_ARTICULOS");
            if (tabla != null)
            {
                cboArticulos.DataSource = tabla;
                cboArticulos.ValueMember = tabla.Columns[0].ColumnName;
                cboArticulos.DisplayMember = tabla.Columns[1].ColumnName;
            }
        }

        private void CargarFomarPago()
        {
            DataTable tabla = gestor.ConsultarFormaPago("SP_FORMAS_PAGO");
            if (tabla != null)
            {
                cboFormaPago.DataSource = tabla;
                cboFormaPago.ValueMember = tabla.Columns[0].ColumnName;
                cboFormaPago.DisplayMember = tabla.Columns[1].ColumnName;
             }
        }

        private void ProximaFacturacion()
        {
            
            int next = gestor.ProximaFactura();
            if (next > 0)
            {
                lblNrofactura.Text=lblNrofactura.Text + next.ToString();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("debe elegir una forma de pago", "control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (cboArticulos.SelectedIndex == -1)
            {
                MessageBox.Show("debe seleccionar un articulo", "control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            foreach (DataGridViewRow fila in dgvDetalles.Rows)

            {
                if (fila.Cells["ColNomArticulo"].Value.ToString().Equals(cboArticulos.Text))
                {
                    MessageBox.Show("este articulo ya esta cargado");
                    return;
                }

            }
            DataRowView item = (DataRowView)cboArticulos.SelectedItem;
            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom= item.Row.ItemArray[1].ToString();
            double pre= Convert.ToDouble(item.Row.ItemArray[2]);
            Articulo A = new Articulo(nro,nom,pre);

            int cant = Convert.ToInt32(txtCantidad.Text);
            DetalleFactura detalle = new DetalleFactura(A, cant);
            nueva.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(detalle.articulo.codArticulo,
                                 detalle.articulo.NombreArticulo,
                                 detalle.articulo.PrecioUnitario,
                                 detalle.Cantidad,"Quitar");
            CalcularTotales();


        }

        private void CalcularTotales()
        {
            txttotal.Text = nueva.CalcularTotal().ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nueva.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                CalcularTotales();
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcliente.Text))
            {
                MessageBox.Show("debe ingresar un cliente");
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("debe seleccionar un articulo");
                return;
            }
            GrabarFactura();
        }

        private void GrabarFactura()
        {
            nueva.fecha = Convert.ToDateTime(txtFecha.Text);
            nueva.Cliente = txtcliente.Text;
            if (gestor.ConfirmarFactura(nueva))
            {
                MessageBox.Show("se realizo una factura");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("NO se pudo facturar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
