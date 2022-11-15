﻿namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class Localidad : BaseEntity<Guid>
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }
        public string Estado { get; set; }
        public string Terminal { get; set; }
        public string Abreviado { get; set; }
    }
}
