using Microsoft.EntityFrameworkCore;
using Myproject.Models;

namespace Myproject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }
    }
}