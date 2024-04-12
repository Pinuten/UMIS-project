using Microsoft.EntityFrameworkCore;

public class MatladaContext : DbContext
{
    public MatladaContext(DbContextOptions<MatladaContext> options) : base(options)
    {
    }

    public DbSet<Matlada> Matlador { get; set; }
    public DbSet<Statistics> Statistics { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Matlada>().HasData(
        new Matlada { Id = 1, Size = Size.Normal, CreatedAt = DateTime.Now.AddDays(-1), Name = "Chicken Salad Lunchbox" }, 
        new Matlada { Id = 2, Size = Size.Small, CreatedAt = DateTime.Now.AddDays(-2), Name = "Fruit Snack Lunchbox" },  
        new Matlada { Id = 3, Size = Size.Normal, CreatedAt = DateTime.Now.AddDays(-3), Name = "Pasta Lunchbox" },       
        new Matlada { Id = 4, Size = Size.Normal, CreatedAt = DateTime.Now.AddDays(-4), Name = "Vegan Wrap Lunchbox" }   
    );
}
}
