namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class DocumentoEntrega : BaseEntity<Guid>
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
