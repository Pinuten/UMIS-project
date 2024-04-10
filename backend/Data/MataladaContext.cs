using Microsoft.EntityFrameworkCore;

public class MatladaContext : DbContext
{
    public MatladaContext(DbContextOptions<MatladaContext> options) : base(options)
    {
    }

    public DbSet<Matlada> Matlador { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Matlada>().HasData(
            new Matlada
            {
                Guid = Guid.NewGuid().ToString(),
                Size = Size.Normal,
                CreatedAt = DateTime.Now,
                Name = "My First Matlada"
            },
            new Matlada
            {
                Guid = Guid.NewGuid().ToString(),
                Size = Size.Small,
                CreatedAt = DateTime.Now,
                Name = "My Second Matlada"
            }
        );
    }
}
