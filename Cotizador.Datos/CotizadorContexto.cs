using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Dominio;

namespace Cotizador.Datos
{
    public class CotizadorContexto : DbContext
    {
        public CotizadorContexto():base("name=CotizadorConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();

            modelBuilder
                .Conventions
                .Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder
                .Conventions
                .Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder
                .Entity<Cotizacion>()
                .ToTable("Cotizaciones");

            modelBuilder
                .Entity<Marca>()
                .ToTable("Marcas");
            modelBuilder
                .Ignore(new[] {typeof (Configuracion)});

            modelBuilder
                .Entity<Cotizacion>()
                .Ignore(t => t.ValorSeguro);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Marca> Marcas { get; set; }  
    }
}
