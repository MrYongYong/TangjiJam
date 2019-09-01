using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TangjinJam.Infrastructure.Ef.Configurations;
using TangjinJam.Infrastructure.Model;

namespace TangjinJam.Infrastructure.Ef
{
    public class TangjinJamDbContext : DbContext
    {
        public TangjinJamDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<ItemDetail> ItemDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ItemConfiguration());
        }
    }
}
