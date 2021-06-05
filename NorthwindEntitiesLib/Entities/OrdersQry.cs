using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    [Keyless]
    public partial class OrdersQry
    {        
        public int OrderID { get; set; }   
        [Column(TypeName = "nvarchar (5)")]     
        [StringLength(5)]
        [RegularExpression("[A-Z]{5}")]
        public string CustomerID { get; set; }        
        public int? EmployeeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequiredDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }
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
        [Required]
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string CompanyName { get; set; }
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
    }
}
