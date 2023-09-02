using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionAPP.DataBase
{
    internal class parametro
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }

        public parametro(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }

    }
}
