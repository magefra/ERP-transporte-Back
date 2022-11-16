namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class TipoCarga : BaseEntity
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Estatus { get; set; }
        public string Descripcion { get; set; }
        public string Referencia { get; set; }
        public string ClaveSAT { get; set; }
        public string Clasificacion { get; set; }
        public string TipoMaterialPeligroso { get; set; }
        public string Presentacion { get; set; }
        public string FraccionArancelaria { get; set; }
    }
}
