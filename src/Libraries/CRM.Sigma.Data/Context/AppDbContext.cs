using CRM.Sigma.Data.Domain.Candidates;
using Microsoft.EntityFrameworkCore;

namespace CRM.Sigma.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasIndex(x => x.Email)
                .IsUnique(true);
        }   
    }
}
