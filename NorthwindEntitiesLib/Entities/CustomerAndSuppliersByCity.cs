using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    [Keyless]
    public partial class CustomerAndSuppliersByCity
    {
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string City { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [Column(TypeName = "nvarchar (30)")]
        [StringLength(30)]
        public string ContactName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (9)")]
        [StringLength(9)]
        public string Relationship { get; set; }
    }
}
