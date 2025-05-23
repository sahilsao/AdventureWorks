﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class TransactionHistoryArchiveConfiguration : IEntityTypeConfiguration<TransactionHistoryArchive>
    {
        public void Configure(EntityTypeBuilder<TransactionHistoryArchive> entity)
        {
            entity.HasKey(e => e.TransactionID).HasName("PK_TransactionHistoryArchive_TransactionID");

            entity.ToTable("TransactionHistoryArchive", "Production", tb => tb.HasComment("Transactions for previous years."));

            entity.Property(e => e.TransactionID)
                .ValueGeneratedNever()
                .HasComment("Primary key for TransactionHistoryArchive records.");
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
                .HasComment("W = Work Order, S = Sales Order, P = Purchase Order");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TransactionHistoryArchive> entity);
    }
}
