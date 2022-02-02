using Microsoft.EntityFrameworkCore;
using Rstagram.Entities;

namespace Rstagram.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<SimpleUser> SimpleUsers { get; set; }
        public DbSet<SuperUser> SuperUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Friendship> Friendships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friendship>()
                .HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
