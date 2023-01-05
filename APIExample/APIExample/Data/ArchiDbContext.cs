using APIExample.Models;
using Microsoft.EntityFrameworkCore;

namespace APIExample.Data
{
    public class ArchiDbContext : DbContext
    {
        public ArchiDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
