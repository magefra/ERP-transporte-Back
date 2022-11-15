namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class EstatusContenedor : BaseEntity<Guid>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
