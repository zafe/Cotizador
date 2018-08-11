using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Dominio;

namespace Cotizador.Presentacion
{
    public class TipoCotizacionEventArgs:EventArgs
    {
        public Tipo Tipo { get; private set; }

        public TipoCotizacionEventArgs(Tipo tipo)
        {
            Tipo = tipo;
        }
    }
}
