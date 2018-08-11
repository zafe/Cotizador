using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Dominio
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public string Titular { get; set; }
        public long Documento { get; set; }
        public string Domicilio { get; set; }
        public Tipo Tipo { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public string Dominio { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public double Precio { get; set; }
        public double ValorSeguro => Precio*Configuracion.Porcentaje;
    }
}
