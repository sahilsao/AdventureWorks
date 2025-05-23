﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class AWBuildVersionConfiguration : IEntityTypeConfiguration<AWBuildVersion>
    {
        public void Configure(EntityTypeBuilder<AWBuildVersion> entity)
        {
            entity.HasKey(e => e.SystemInformationID).HasName("PK_AWBuildVersion_SystemInformationID");

            entity.ToTable("AWBuildVersion", tb => tb.HasComment("Current version number of the AdventureWorks 2014 sample database. "));

            entity.Property(e => e.SystemInformationID)
                .ValueGeneratedOnAdd()
                .HasComment("Primary key for AWBuildVersion records.");
            entity.Property(e => e.Database_Version).HasComment("Version number of the database in 9.yy.mm.dd.00 format.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.VersionDate).HasComment("Date and time the record was last updated.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AWBuildVersion> entity);
    }
}
