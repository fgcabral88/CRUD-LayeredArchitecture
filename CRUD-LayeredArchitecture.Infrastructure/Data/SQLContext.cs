using Microsoft.EntityFrameworkCore;
using CRUD_LayeredArchitecture.Domain.Entities;

public class SQLContext : DbContext
{
    public SQLContext() { }

    public SQLContext(DbContextOptions<SQLContext> options)
        : base(options) { }

    public DbSet<TaxEntity> Taxes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TaxEntity>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(e => e.Percentage)
                .IsRequired();

            entity.Property(e => e.CreatedAt)
                .IsRequired();
        });
    }
}