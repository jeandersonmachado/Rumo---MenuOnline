using MenuOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuOnline.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Prato> Pratos { get; set; }

    }
}
