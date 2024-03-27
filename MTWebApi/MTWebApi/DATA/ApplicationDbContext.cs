using Microsoft.EntityFrameworkCore;
using MTWebApi.DATA.MODEL;

namespace MTWebApi.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> students { get; set; }
        public DbSet<Lector> Lectors { get; set; }
    }
}
