﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class vVendorWithContactConfiguration : IEntityTypeConfiguration<vVendorWithContact>
    {
        public void Configure(EntityTypeBuilder<vVendorWithContact> entity)
        {
            entity.ToView("vVendorWithContacts", "Purchasing");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<vVendorWithContact> entity);
    }
}
