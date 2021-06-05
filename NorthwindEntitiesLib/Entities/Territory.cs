using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NorthwindEntitiesLib.Entities
{
    public partial class Territory
    {
        public Territory()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritory>();
        }

        [Key]  
        [Column(TypeName = "nvarchar (20)")]      
        [StringLength(20)]
        public string TerritoryID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar (50)")]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }        
        public int RegionID { get; set; }

        [ForeignKey(nameof(RegionID))]
        [InverseProperty("Territories")]
        public virtual Region Region { get; set; }
        [InverseProperty(nameof(EmployeeTerritory.Territory))]
        public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
