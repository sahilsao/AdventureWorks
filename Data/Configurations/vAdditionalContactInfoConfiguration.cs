﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class vAdditionalContactInfoConfiguration : IEntityTypeConfiguration<vAdditionalContactInfo>
    {
        public void Configure(EntityTypeBuilder<vAdditionalContactInfo> entity)
        {
            entity.ToView("vAdditionalContactInfo", "Person");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<vAdditionalContactInfo> entity);
    }
}
