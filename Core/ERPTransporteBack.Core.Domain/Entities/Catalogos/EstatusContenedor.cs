namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class EstatusContenedor : BaseEntity
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
