using Microsoft.EntityFrameworkCore;
using Routing.Models; //namespacei yazmamız lazım classla yazma


namespace Routing.Data;


public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
}