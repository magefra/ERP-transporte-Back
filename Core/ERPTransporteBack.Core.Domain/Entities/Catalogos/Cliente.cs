namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class Cliente : BaseEntity<Guid>
    {
        public string Clave { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Activo { get; set; }
        public string CP { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Colonia { get; set; }
        public string Delegacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string TipoPersona { get; set; }
        public string LineaNegocio { get; set; }
        public string Moneda { get; set; }
        public string MonedaDescripcion { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Referencia { get; set; }
        public string DescripcionAdicionalPDF { get; set; }
        public double LineaCredito { get; set; }
        public string TipoServicio { get; set; }
        public string TipoServicioDescripcion { get; set; }
        public bool AutorizadaCobranzas { get; set; }
        public bool EsFilial { get; set; }
        public string TipoBeneficiario { get; set; }

    }
}
