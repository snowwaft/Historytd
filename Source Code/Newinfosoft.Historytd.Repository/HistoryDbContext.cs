using Microsoft.EntityFrameworkCore;
using Newinfosoft.Historytd.Entity;
using System;

namespace Newinfosoft.Historytd.Repository
{
    public class HistoryDbContext : DbContext
    {
        public DbSet<Person> PersonSet;
        public DbSet<EventBase> EventBaseSet;

        public HistoryDbContext(DbContextOptions<HistoryDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Person
            //索引
            modelBuilder.Entity<Person>().HasIndex(p => new { p.Birthday, p.Deathday }).HasName("IDX_BASIC_PERSON_DATE");
            modelBuilder.Entity<Person>().HasIndex(p => p.FamilyName).HasName("IDX_BASIC_PERSON_NAME");

            //日期映射
            modelBuilder.Entity<Person>()
                .Property(p => p.Birthday)
                .HasConversion<int>(convertToProviderExpression: (date) => date.ToInt32(), convertFromProviderExpression: (i) => Date.Parse(i));
            modelBuilder.Entity<Person>()
                .Property(p => p.Deathday)
                .HasConversion<int>(convertToProviderExpression: (date) => date.ToInt32(), convertFromProviderExpression: (i) => Date.Parse(i));

            #endregion

            #region EventBase

            //索引
            modelBuilder.Entity<EventBase>().HasIndex(e => e.BeginDate).HasName("IDX_BASIC_EVENT_DATE");

            //日期映射
            modelBuilder.Entity<EventBase>()
                .Property(e => e.BeginDate)
                .HasConversion<int>(convertToProviderExpression: (date) => date.ToInt32(), convertFromProviderExpression: (i) => Date.Parse(i));
            modelBuilder.Entity<EventBase>()
                .Property(e => e.EndDate)
                .HasConversion<int>(convertToProviderExpression: (date) => date.ToInt32(), convertFromProviderExpression: (i) => Date.Parse(i));

            #endregion
        }
    }
}
