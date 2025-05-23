﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class TransactionHistoryConfiguration : IEntityTypeConfiguration<TransactionHistory>
    {
        public void Configure(EntityTypeBuilder<TransactionHistory> entity)
        {
            entity.HasKey(e => e.TransactionID).HasName("PK_TransactionHistory_TransactionID");

            entity.ToTable("TransactionHistory", "Production", tb => tb.HasComment("Record of each purchase order, sales order, or work order transaction year to date."));

            entity.Property(e => e.TransactionID).HasComment("Primary key for TransactionHistory records.");
            entity.Property(e => e.ActualCost).HasComment("Product cost.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.ProductID).HasComment("Product identification number. Foreign key to Product.ProductID.");
            entity.Property(e => e.Quantity).HasComment("Product quantity.");
            entity.Property(e => e.ReferenceOrderID).HasComment("Purchase order, sales order, or work order identification number.");
            entity.Property(e => e.ReferenceOrderLineID).HasComment("Line number associated with the purchase order, sales order, or work order.");
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time of the transaction.");
            entity.Property(e => e.TransactionType)
                .IsFixedLength()
                .HasComment("W = WorkOrder, S = SalesOrder, P = PurchaseOrder");

            entity.HasOne(d => d.Product).WithMany(p => p.TransactionHistories).OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TransactionHistory> entity);
    }
}
