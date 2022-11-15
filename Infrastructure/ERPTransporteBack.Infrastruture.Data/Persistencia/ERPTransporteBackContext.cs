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



    }
}
