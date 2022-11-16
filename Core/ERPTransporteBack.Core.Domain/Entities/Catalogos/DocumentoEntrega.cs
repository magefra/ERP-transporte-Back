namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class DocumentoEntrega : BaseEntity
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
