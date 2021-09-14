using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MusicApp.Domain;
using MusicApp.Domain.Models;
using System;

namespace MusicApp.DataAccess
{
    public class MusicAppDbContext : DbContext
    {
        public MusicAppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            DateTime now = DateTime.UtcNow;

            foreach (EntityEntry entry in ChangeTracker.Entries())
            {
                BaseEntity entity = entry.Entity as BaseEntity;

                if (entity == null)
                {
                    continue;
                }

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedOn = now;
                    entity.UpdatedOn = now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entity.UpdatedOn = now;
                }
            }

            return base.SaveChanges();
        }
    }
}
