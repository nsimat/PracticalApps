using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    [Table("CustomerCustomerDemo")]
    public partial class CustomerCustomerDemo
    {
        [Key]
        [Column(TypeName = "nvarchar (5)")]
        [StringLength(5)]
        [RegularExpression("[A-Z]{5}")]
        public string CustomerID { get; set; }
        [Key]
        [Column(TypeName = "nvarchar (10)")]
        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        [ForeignKey(nameof(CustomerID))]
        [InverseProperty("CustomerCustomerDemos")]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(CustomerTypeID))]
        [InverseProperty(nameof(CustomerDemographic.CustomerCustomerDemos))]
        public virtual CustomerDemographic CustomerType { get; set; }
    }
}
