using Microsoft.EntityFrameworkCore;

namespace Lab01
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }


        public DbSet<JoinFraction> JoinFractions { get; set; }
    }
}
