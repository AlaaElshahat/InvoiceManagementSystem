﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class StoreContext : DbContext
    {
        public StoreContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StoreDB_503;Integrated Security=True;TrustServerCertificate=true");
           
            base.OnConfiguring(optionsBuilder);
        }
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }
        

        public virtual DbSet<InvoiceSell> InvoiceSells { get; set; }
        public virtual DbSet<InvoiceSellUnit> InvoiceSellUnits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Arabic_CI_AS");

            modelBuilder.Entity<InvoiceSell>(entity =>
            {
                entity.HasKey(e => new { e.invoiceNo, e.buildingNo });

                entity.Property(e => e.row_timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<InvoiceSellUnit>(entity =>
            {
                entity.HasKey(e => new { e.invoiceNo, e.buildingNo, e.orderNo });

                entity.Property(e => e.row_timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.InvoiceSell)
                    .WithMany(p => p.InvoiceSellUnits)
                    .HasForeignKey(d => new { d.invoiceNo, d.buildingNo })
                    .HasConstraintName("FK_InvoiceSellUnit_R_150_InvoiceSell");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}