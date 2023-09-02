using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAPP
{
    internal class FormasPago
    {
        public string NombreFormaPago { get; set; }
        public FormasPago(string nombreFormaPago)
        {
            NombreFormaPago = nombreFormaPago;
        }

    }
}
