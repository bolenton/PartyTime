using System.Data.Entity;
using RsvpApp.Models;

namespace RsvpApp.Entities
{
    public class RsvpDbContext : DbContext
    {
        public RsvpDbContext() : base("name=RsvpEntities")
        {
            Database.SetInitializer<RsvpDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestResponse>()
                .ToTable("GuestResponses")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Comments>()
              .ToTable("Comments")
              .HasKey(c => c.CommentId);
        }
        public virtual DbSet<GuestResponse> GuestResponses { get; set; }

        public virtual DbSet<Comments> Comments { get; set; }
    }
}