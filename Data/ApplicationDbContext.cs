    using GameDevPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace GameDevPortfolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
