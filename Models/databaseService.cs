using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace HOS.Models
{
    public class databaseService : DbContext
    {
        public databaseService(DbContextOptions<databaseService> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; } = null!;
    }
}
