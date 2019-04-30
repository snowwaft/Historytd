﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newinfosoft.Historytd.Repository;

namespace Newinfosoft.Historytd.Repository.Migrations
{
    [DbContext(typeof(HistoryDbContext))]
    partial class HistoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Newinfosoft.Historytd.Entity.EventBase", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract")
                        .HasMaxLength(500);

                    b.Property<int>("BeginDate");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EndDate");

                    b.Property<DateTime>("LastUpdateTime")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("EventId");

                    b.HasIndex("BeginDate");

                    b.ToTable("T_BASIC_EVENT");
                });
#pragma warning restore 612, 618
        }
    }
}
