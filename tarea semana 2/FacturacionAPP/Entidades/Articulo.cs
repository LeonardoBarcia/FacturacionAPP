using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAPP
{
    internal class Articulo
    {
        public int codArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public double PrecioUnitario { get; set; }

        public Articulo( int codigo,string nombreArticulo, double precioUnitario)
        {
            codArticulo = codigo;
            NombreArticulo = nombreArticulo;
            PrecioUnitario = precioUnitario;
        }
        
    }
}
