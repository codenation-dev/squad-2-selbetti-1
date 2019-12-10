using Codenation.ErrorCenter.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Codenation.ErrorCenter.Models
{
    public class ErrorCenterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=errorLog;Trusted_Connection=True");
        }

        public DbSet<Log> Logs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
