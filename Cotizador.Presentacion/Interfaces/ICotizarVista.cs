using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Dominio;

namespace Cotizador.Presentacion.Interfaces
{
    public interface ICotizarVista
    {
        void Iniciar(Cotizacion cotizacion);
        void ListarMarcas(List<Marca> marcas);
    }
}
