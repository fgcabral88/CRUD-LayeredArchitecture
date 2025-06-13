namespace CRUD_LayeredArchitecture.Domain.Entities
{
    public class TaxEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Percentage { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
