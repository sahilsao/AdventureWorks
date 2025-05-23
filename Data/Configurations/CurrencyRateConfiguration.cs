﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class CurrencyRateConfiguration : IEntityTypeConfiguration<CurrencyRate>
    {
        public void Configure(EntityTypeBuilder<CurrencyRate> entity)
        {
            entity.HasKey(e => e.CurrencyRateID).HasName("PK_CurrencyRate_CurrencyRateID");

            entity.ToTable("CurrencyRate", "Sales", tb => tb.HasComment("Currency exchange rates."));

            entity.Property(e => e.CurrencyRateID).HasComment("Primary key for CurrencyRate records.");
            entity.Property(e => e.AverageRate).HasComment("Average exchange rate for the day.");
            entity.Property(e => e.CurrencyRateDate).HasComment("Date and time the exchange rate was obtained.");
            entity.Property(e => e.EndOfDayRate).HasComment("Final exchange rate for the day.");
            entity.Property(e => e.FromCurrencyCode)
                .IsFixedLength()
                .HasComment("Exchange rate was converted from this currency code.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.ToCurrencyCode)
                .IsFixedLength()
                .HasComment("Exchange rate was converted to this currency code.");

            entity.HasOne(d => d.FromCurrencyCodeNavigation).WithMany(p => p.CurrencyRateFromCurrencyCodeNavigations).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToCurrencyCodeNavigation).WithMany(p => p.CurrencyRateToCurrencyCodeNavigations).OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CurrencyRate> entity);
    }
}
