﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class vSalesPersonSalesByFiscalYearConfiguration : IEntityTypeConfiguration<vSalesPersonSalesByFiscalYear>
    {
        public void Configure(EntityTypeBuilder<vSalesPersonSalesByFiscalYear> entity)
        {
            entity.ToView("vSalesPersonSalesByFiscalYears", "Sales");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<vSalesPersonSalesByFiscalYear> entity);
    }
}
