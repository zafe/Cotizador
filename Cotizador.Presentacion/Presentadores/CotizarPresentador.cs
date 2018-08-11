using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Datos;
using Cotizador.Dominio;
using Cotizador.Presentacion.Interfaces;

namespace Cotizador.Presentacion
{
    public class CotizarPresentador
    {
        private ICotizarVista _vista;
        public event EventHandler<TipoCotizacionEventArgs> NuevaCotizacion;


        public CotizarPresentador(ICotizarVista vista)
        {
            _vista = vista;
            ListarMarcas();
            Iniciar();
        }

        private void Iniciar()
        {
            _vista.Iniciar(new Cotizacion());
        }

        private void ListarMarcas()
        {
            using (var db = new CotizadorContexto())
            {
                _vista.ListarMarcas(db.Marcas.ToList());
            }
        }

        public void GuardarCotizacion(Cotizacion cotizacion)
        {
            using (var db = new CotizadorContexto())
            {
                db.Cotizaciones.Add(cotizacion);
                db.SaveChanges();
            }
            OnNuevaCotizacion(new TipoCotizacionEventArgs(cotizacion.Tipo));
            Iniciar();
        }

        protected virtual void OnNuevaCotizacion(TipoCotizacionEventArgs e)
        {
            NuevaCotizacion?.Invoke(this, e);
        }
    }
}
