namespace ERPTransporteBack.Core.Domain.Entities
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedDate { get; set; }
        public DateTime LastModifieDate { get; set; }

    }
}
