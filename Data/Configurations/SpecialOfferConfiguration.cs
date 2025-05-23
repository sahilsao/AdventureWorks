﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class SpecialOfferConfiguration : IEntityTypeConfiguration<SpecialOffer>
    {
        public void Configure(EntityTypeBuilder<SpecialOffer> entity)
        {
            entity.HasKey(e => e.SpecialOfferID).HasName("PK_SpecialOffer_SpecialOfferID");

            entity.ToTable("SpecialOffer", "Sales", tb => tb.HasComment("Sale discounts lookup table."));

            entity.Property(e => e.SpecialOfferID).HasComment("Primary key for SpecialOffer records.");
            entity.Property(e => e.Category).HasComment("Group the discount applies to such as Reseller or Customer.");
            entity.Property(e => e.Description).HasComment("Discount description.");
            entity.Property(e => e.DiscountPct).HasComment("Discount precentage.");
            entity.Property(e => e.EndDate).HasComment("Discount end date.");
            entity.Property(e => e.MaxQty).HasComment("Maximum discount percent allowed.");
            entity.Property(e => e.MinQty).HasComment("Minimum discount percent allowed.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.StartDate).HasComment("Discount start date.");
            entity.Property(e => e.Type).HasComment("Discount type category.");
            entity.Property(e => e.rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SpecialOffer> entity);
    }
}
