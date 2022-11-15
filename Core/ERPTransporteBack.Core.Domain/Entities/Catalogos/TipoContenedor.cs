﻿namespace ERPTransporteBack.Core.Domain.Entities.Catalogos
{
    public class TipoContenedor : BaseEntity<Guid>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Longitud { get; set; }
        public string Abreviado { get; set; }
    }
}
