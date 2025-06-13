namespace CRUD_LayeredArchitecture.Dtos.Dtos.TaxDtos
{
    public class TaxListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Percentage { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
