﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AdventureWorks.Data;
using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Configurations
{
    public partial class vJobCandidateEducationConfiguration : IEntityTypeConfiguration<vJobCandidateEducation>
    {
        public void Configure(EntityTypeBuilder<vJobCandidateEducation> entity)
        {
            entity.ToView("vJobCandidateEducation", "HumanResources");

            entity.Property(e => e.JobCandidateID).ValueGeneratedOnAdd();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<vJobCandidateEducation> entity);
    }
}
