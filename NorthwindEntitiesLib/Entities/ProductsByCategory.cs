using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    [Keyless]
    public partial class ProductsByCategory
    {
        [Required]
        [Column(TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string CategoryName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(20)]
        public string QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
