using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    public partial class EmployeeTerritory
    {
        [Key]        
        public int EmployeeID { get; set; }
        [Key]
        [Column(TypeName = "nvarchar (20)")]
        [StringLength(20)]
        public string TerritoryID { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        [InverseProperty("EmployeeTerritories")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(TerritoryID))]
        [InverseProperty("EmployeeTerritories")]
        public virtual Territory Territory { get; set; }
    }
}
