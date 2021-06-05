using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    [Keyless]
    public partial class CurrentProductList
    {        
        public int ProductID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string ProductName { get; set; }
    }
}
