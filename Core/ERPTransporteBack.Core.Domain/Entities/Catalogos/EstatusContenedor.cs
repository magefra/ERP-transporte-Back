namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class EstatusContenedor : BaseEntity<Guid>
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
