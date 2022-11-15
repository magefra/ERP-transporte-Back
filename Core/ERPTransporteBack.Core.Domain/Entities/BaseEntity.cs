namespace ERPTransporteBack.Core.Domain.Entities
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? LastModifiedAtUtc { get; set; }
    }
}
