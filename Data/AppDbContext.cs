using Microsoft.EntityFrameworkCore;
using InventarioApp.Models;

namespace InventarioApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Producto> Productos { get; set; }
}


