using Microsoft.EntityFrameworkCore;
using Lab4NET.Models;

namespace Lab4NET.Data
{
    public class SportsDbContext : DbContext
    {
        public SportsDbContext(DbContextOptions<SportsDbContext> options) : base(options) { }
        public DbSet<SportClub> SportClubs { get; set; }
        public DbSet<Fan> Fans { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SportClub>().ToTable("sportclub");
            modelBuilder.Entity<Fan>().ToTable("fan");
            modelBuilder.Entity<Subscription>().HasKey(e => new {e.SportClubId, e.FanId});
        }
    }
}
