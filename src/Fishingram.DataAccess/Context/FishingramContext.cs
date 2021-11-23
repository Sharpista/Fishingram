using Fishingram.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Context
{
    public class FishingramContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PhotoAlbum> PhotoAlbums { get; set; }
        public DbSet<Post> Posts { get; set; }

        public FishingramContext(DbContextOptions<FishingramContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FishingramContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
