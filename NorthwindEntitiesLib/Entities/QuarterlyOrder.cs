using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    [Keyless]
    public partial class QuarterlyOrder
    {
        [Column(TypeName = "nvarchar (5)")]        
        [StringLength(5)]
        [RegularExpression("[A-Z]{5}")]
        public string CustomerID { get; set; }
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string City { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string Country { get; set; }
    }
}
