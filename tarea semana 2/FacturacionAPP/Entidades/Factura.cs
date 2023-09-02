using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAPP
{
    internal class Factura
    {

        public int NroFactura { get; set; }
        public DateTime fecha { get; set; }
        public FormasPago FormasPago { get; set; }
        public string Cliente { get; set; }
        public double total { get; set; }

        public Factura(int nroFactura, DateTime fecha, FormasPago formasPago, string cliente,double total)
        {
            NroFactura = nroFactura;
            this.fecha = fecha;
            FormasPago = formasPago;
            Cliente = cliente;
            this.total = total;
        }
        public List<DetalleFactura> detalles { get; set; }
        public Factura()
        {
            detalles = new List<DetalleFactura>();
        }
        public void AgregarDetalle(DetalleFactura detalle)
        {
            detalles.Add(detalle);
        }
        public void QuitarDetalle(int possicion)
        {
            detalles.RemoveAt(possicion);
        }
        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura detalle in detalles)
            {
                total += detalle.CalcularTotal();
            }
            return total;
        }
    

    }
}
