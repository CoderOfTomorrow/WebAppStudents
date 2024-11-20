using Microsoft.EntityFrameworkCore;
using WebAppForNoobs.Common;

namespace WebAppForNoobs.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Biography> Biographies { get; set; }
    }
}