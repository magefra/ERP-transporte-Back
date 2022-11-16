namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class TipoContenedor : BaseEntity
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Longitud { get; set; }
        public string Abreviado { get; set; }
    }
}
