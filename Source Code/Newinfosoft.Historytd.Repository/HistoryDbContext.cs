using Microsoft.EntityFrameworkCore;
using Newinfosoft.Historytd.Entity;
using System;

namespace Newinfosoft.Historytd.Repository
{
    public class HistoryDbContext : DbContext
    {
        public DbSet<EventBase> EventBaseSet;

        public HistoryDbContext(DbContextOptions<HistoryDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventBase>()
                .HasIndex(e => e.BeginDate);

            modelBuilder.Entity<EventBase>()
                .Property(e => e.BeginDate)
                .HasConversion<int>(convertToProviderExpression: (date) => date.ToInt32(),
                    convertFromProviderExpression: (i) => Date.Parse(i));
            modelBuilder.Entity<EventBase>()
                .Property(e => e.EndDate)
                .HasConversion<int>(convertToProviderExpression: (date) => date.ToInt32(),
                    convertFromProviderExpression: (i) => Date.Parse(i));
        }
    }
}
