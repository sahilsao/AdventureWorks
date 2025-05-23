﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Models;

/// <summary>
/// Contains online customer orders until the order is submitted or cancelled.
/// </summary>
[Table("ShoppingCartItem", Schema = "Sales")]
[Index("ShoppingCartID", "ProductID", Name = "IX_ShoppingCartItem_ShoppingCartID_ProductID")]
public partial class ShoppingCartItem
{
    /// <summary>
    /// Primary key for ShoppingCartItem records.
    /// </summary>
    [Key]
    public int ShoppingCartItemID { get; set; }

    /// <summary>
    /// Shopping cart identification number.
    /// </summary>
    [Required]
    [StringLength(50)]
    public string ShoppingCartID { get; set; }

    /// <summary>
    /// Product quantity ordered.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Product ordered. Foreign key to Product.ProductID.
    /// </summary>
    public int ProductID { get; set; }

    /// <summary>
    /// Date the time the record was created.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("ShoppingCartItems")]
    public virtual Product Product { get; set; }
}