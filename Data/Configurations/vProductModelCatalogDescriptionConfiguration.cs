﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class vProductModelCatalogDescriptionConfiguration : IEntityTypeConfiguration<vProductModelCatalogDescription>
    {
        public void Configure(EntityTypeBuilder<vProductModelCatalogDescription> entity)
        {
            entity.ToView("vProductModelCatalogDescription", "Production");

            entity.Property(e => e.ProductModelID).ValueGeneratedOnAdd();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<vProductModelCatalogDescription> entity);
    }
}
