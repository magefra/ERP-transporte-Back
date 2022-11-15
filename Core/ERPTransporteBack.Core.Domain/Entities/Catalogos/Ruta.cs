namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class Ruta : BaseEntity<Guid>
    {
        public string Codigo { get; set; }
        public string Grupo { get; set; }
        public bool Autorizada { get; set; }
        public string CodigoOrigen { get; set; }
        public string LocalidadOrigen { get; set; }
        public string CodigoDestino { get; set; }
        public string LocalidadDestino { get; set; }
        public bool TramoFederal { get; set; }
        public bool TramoPatio { get; set; }
        public double DistanciaPatio { get; set; }
        public string TiempoNormal1OP { get; set; }
        public string TiempoFull1OP { get; set; }
        public string TiempoNormal2OP { get; set; }
        public string TiempoFull2OP { get; set; }
        public double RendimientoSenc { get; set; }
        public double RendiemientoFull { get; set; }
        public bool EsRutaCritica { get; set; }
        public double KilometrosRutaCritica { get; set; }
        public string Nota { get; set; }
    }
}
