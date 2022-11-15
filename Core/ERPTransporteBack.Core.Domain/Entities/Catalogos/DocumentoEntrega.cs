namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class DocumentoEntrega : BaseEntity<Guid>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
