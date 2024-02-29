using Microsoft.EntityFrameworkCore;
using WinformsBasic.Models.Entities;

namespace WinformsBasic.Data
{
    public class WinformsBasicContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1401;Database=WinformBasicContext;User Id=SA;Password=3563949Zx");
        }
    }
}
