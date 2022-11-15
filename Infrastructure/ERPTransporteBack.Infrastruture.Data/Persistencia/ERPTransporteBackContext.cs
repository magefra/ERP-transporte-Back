using ERPTransporteBack.Core.Domain.Entities.Catalogos;
using Microsoft.EntityFrameworkCore;

namespace ERPTransporteBack.Infrastruture.Data.Persistencia
{
    public class ERPTransporteBackContext : DbContext
    {
        public ERPTransporteBackContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Localidad> Localidades { get; set; }
        public virtual DbSet<Caseta> Casetas { get; set; }
        public virtual DbSet<Gasolinera> Gasolineras { get; set; }
        public virtual DbSet<TipoContenedor> TipoContenedores { get; set; }
        public virtual DbSet<EstatusContenedor> EstatusContenedores { get; set; }
        public virtual DbSet<Ruta> Rutas { get; set; }
        public virtual DbSet<TipoCarga> TipoCarga { get; set; }
        public virtual DbSet<Embalaje> Embalajes { get; set; }
        public virtual DbSet<DocumentoEntrega> DocumentosEntrega { get; set; }


    }
}
