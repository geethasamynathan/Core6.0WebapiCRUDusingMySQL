using Microsoft.EntityFrameworkCore;

namespace secondAPi.Models
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Account> Accounts{get;set;}
        public DbSet<Owner> Owners{get;set;}
    }
}