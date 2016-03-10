using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
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
        }

        public virtual DbSet<GuestResponse> GuestResponses { get; set; }
    }
}