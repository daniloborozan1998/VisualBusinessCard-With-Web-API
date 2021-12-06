using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VisualBusinessCards.Domain.Models;

namespace VisualBusinessCards.DataAccess
{
    public class VisualBusinessCardsDbContext : DbContext
    {
        public VisualBusinessCardsDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //USER
            modelBuilder.Entity<User>()
                .Property(x => x.FirstName)
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(x => x.LastName)
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(x => x.Username)
                .IsRequired() // not null
                .HasMaxLength(30);

            modelBuilder.Entity<User>()
                .Property(x => x.Age)
                .IsRequired() // not null
                .HasMaxLength(3);
        }
    }
}
