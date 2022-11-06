namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class Gasolinera
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string RFC { get; set; }
        public string Estado { get; set; }
        public string CodigoExterno { get; set; }
        public string TipoValle { get; set; }
        public bool Contabiliza { get; set; }
        public bool ContabilizaCargoOperador { get; set; }
        public double TasaIVA { get; set; }
        public bool Activo { get; set; }
        public string Proveedor { get; set; }
        public string NombreProveedor { get; set; }
    }
}
