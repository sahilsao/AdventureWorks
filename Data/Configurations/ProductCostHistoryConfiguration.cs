﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class ProductCostHistoryConfiguration : IEntityTypeConfiguration<ProductCostHistory>
    {
        public void Configure(EntityTypeBuilder<ProductCostHistory> entity)
        {
            entity.HasKey(e => new { e.ProductID, e.StartDate }).HasName("PK_ProductCostHistory_ProductID_StartDate");

            entity.ToTable("ProductCostHistory", "Production", tb => tb.HasComment("Changes in the cost of a product over time."));

            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID");
            entity.Property(e => e.StartDate).HasComment("Product cost start date.");
            entity.Property(e => e.EndDate).HasComment("Product cost end date.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.StandardCost).HasComment("Standard cost of the product.");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCostHistories).OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProductCostHistory> entity);
    }
}
