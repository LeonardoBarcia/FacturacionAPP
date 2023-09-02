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
    public partial class frmDetalleFacturas : Form
    {
        private int facturaNro;
        public frmDetalleFacturas(int facturaNro)
        {
            InitializeComponent();
            this.facturaNro = facturaNro;
            
        }

        private void frmDetalleFacturas_Load(object sender, EventArgs e)
        {
            //incompleto
            //this.Text = this.Text + facturaNro.ToString();
            //List <parametro> lista= new List<parametro> ();
            //lista.Add(new parametro("factura_numero", facturaNro));

            //DataTable tabla = new BDhelper().consultarFacturas("", lista);

        }
    }
}
