﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Models;

[Keyless]
public partial class vEmployeeDepartment
{
    public int BusinessEntityID { get; set; }

    [StringLength(8)]
    public string Title { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; }

    [StringLength(50)]
    public string MiddleName { get; set; }

    [Required]
    [StringLength(50)]
    public string LastName { get; set; }

    [StringLength(10)]
    public string Suffix { get; set; }

    [Required]
    [StringLength(50)]
    public string JobTitle { get; set; }

    [Required]
    [StringLength(50)]
    public string Department { get; set; }

    [Required]
    [StringLength(50)]
    public string GroupName { get; set; }

    [Column(TypeName = "date")]
    public DateTime StartDate { get; set; }
}