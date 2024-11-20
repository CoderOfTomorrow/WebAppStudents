using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using WebAppForNoobs.Common;

namespace WebAppForNoobs.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Biography> Biographies { get; set; }
    }
}