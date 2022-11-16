namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class Embalaje : BaseEntity
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Leyenda { get; set; }
        public string ClaveUnidadMedidaSAT { get; set; }
        public string ClaveEmbalajeSAT { get; set; }
        public string DescripcionEmbalajeSAT { get; set; }
    }
}
