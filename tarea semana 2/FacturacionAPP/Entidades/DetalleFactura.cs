using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAPP
{
    internal class DetalleFactura
    {

        public Articulo articulo { get; set; }
        public int Cantidad { get; set; }
        public DetalleFactura(Articulo articulo, int cantidad)
        {
            this.articulo = articulo;
            Cantidad = cantidad;
        }
        public double CalcularTotal()
        {
            return articulo.PrecioUnitario * Cantidad;
        }
            
    
    }
}
