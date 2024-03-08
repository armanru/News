using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

namespace News.Models.DataBase
{
    public class Appdbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ARMAN\SQLEXPRESS;Database=News;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Newses> News { get; set; }
            
    }
}
