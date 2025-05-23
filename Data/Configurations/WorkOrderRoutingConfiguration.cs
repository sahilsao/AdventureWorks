﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class WorkOrderRoutingConfiguration : IEntityTypeConfiguration<WorkOrderRouting>
    {
        public void Configure(EntityTypeBuilder<WorkOrderRouting> entity)
        {
            entity.HasKey(e => new { e.WorkOrderID, e.ProductID, e.OperationSequence }).HasName("PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence");

            entity.ToTable("WorkOrderRouting", "Production", tb => tb.HasComment("Work order details."));

            entity.Property(e => e.WorkOrderID).HasComment("Primary key. Foreign key to WorkOrder.WorkOrderID.");
            entity.Property(e => e.ProductID).HasComment("Primary key. Foreign key to Product.ProductID.");
            entity.Property(e => e.OperationSequence).HasComment("Primary key. Indicates the manufacturing process sequence.");
            entity.Property(e => e.ActualCost).HasComment("Actual manufacturing cost.");
            entity.Property(e => e.ActualEndDate).HasComment("Actual end date.");
            entity.Property(e => e.ActualResourceHrs).HasComment("Number of manufacturing hours used.");
            entity.Property(e => e.ActualStartDate).HasComment("Actual start date.");
            entity.Property(e => e.LocationID).HasComment("Manufacturing location where the part is processed. Foreign key to Location.LocationID.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.");
            entity.Property(e => e.PlannedCost).HasComment("Estimated manufacturing cost.");
            entity.Property(e => e.ScheduledEndDate).HasComment("Planned manufacturing end date.");
            entity.Property(e => e.ScheduledStartDate).HasComment("Planned manufacturing start date.");

            entity.HasOne(d => d.Location).WithMany(p => p.WorkOrderRoutings).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderRoutings).OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkOrderRouting> entity);
    }
}
