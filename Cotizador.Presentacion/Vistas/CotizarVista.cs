using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cotizador.Dominio;
using Cotizador.Presentacion.Interfaces;

namespace Cotizador.Presentacion
{
    public partial class CotizarVista : Form, ICotizarVista
    {
        private CotizarPresentador _presentador;
        private PanelVista _panel;
        public CotizarVista()
        {
            InitializeComponent();
            _presentador = new CotizarPresentador(this);
            _panel = new PanelVista(_presentador);
            _panel.Show();
        }

        public void Iniciar(Cotizacion cotizacion)
        {
            bindingSource1.DataSource = cotizacion;
        }

        public void ListarMarcas(List<Marca> marcas)
        {
            cbTipo.DataSource = Enum.GetValues(typeof (Tipo));
            bindingSource2.DataSource = marcas.ToList();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _presentador.GuardarCotizacion(bindingSource1.Current as Cotizacion);
        }
    }
}
