namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class TipoCarga
    {
        public string Codigo { get; set; }
        public string Status { get; set; }
        public string Descripcion { get; set; }
        public string Referencia { get; set; }
        public string ClaveSAT { get; set; }
        public string Clasificacion { get; set; }
        public string TipoMaterialPeligroso { get; set; }
        public string Presentacion { get; set; }
        public string FraccionArancelaria { get; set; }
    }
}
