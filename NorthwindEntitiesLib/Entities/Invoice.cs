using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    [Keyless]
    public partial class Invoice
    {
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string ShipName { get; set; }
        [Column(TypeName = "nvarchar (60)")]
        [StringLength(60)]
        public string ShipAddress { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string ShipCity { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string ShipRegion { get; set; }
        [Column(TypeName = "nvarchar (10)")]
        [StringLength(10)]
        public string ShipPostalCode { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string ShipCountry { get; set; }        
        [Column(TypeName = "nvarchar (5)")]
        [StringLength(5)]
        [RegularExpression("[A-Z]{5}")]
        public string CustomerID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string CustomerName { get; set; }
        [Column(TypeName = "nvarchar (60)")]
        [StringLength(60)]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string City { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string Region { get; set; }
        [Column(TypeName = "nvarchar (10)")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string Country { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (31)")]
        [StringLength(31)]
        public string Salesperson { get; set; }        
        public int OrderID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequiredDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string ShipperName { get; set; }        
        public int ProductID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        [Column(TypeName = "money")]
        public decimal? ExtendedPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }
    }
}
