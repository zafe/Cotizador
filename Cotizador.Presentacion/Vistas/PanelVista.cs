using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cotizador.Datos;
using Cotizador.Dominio;

namespace Cotizador.Presentacion
{
    public partial class PanelVista : Form
    {
        private int _autos;
        private int _camionetas;
        private CotizarPresentador _presentador;
        public PanelVista(CotizarPresentador presentador)
        {
            InitializeComponent();
            _presentador = presentador;
            _presentador.NuevaCotizacion += _presentador_NuevaCotizacion;
        }

        private void _presentador_NuevaCotizacion(object sender, TipoCotizacionEventArgs e)
        {
            if (e.Tipo == Tipo.Auto)
            {
                _autos++;
            }
            else
            {
                _camionetas++;
            }
            lblTotalAutos.Text = _autos.ToString();
            lblTotalCamionetas.Text = _camionetas.ToString();
        }
    }
}
