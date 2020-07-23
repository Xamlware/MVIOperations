using System;
using System.ComponentModel.DataAnnotations;

namespace MVIOperations.Models
{
    public class Region
    {
        [Key]
        [Required(ErrorMessage = "Region id is required")]
        public int PK_Region { get; set; }

        [Required(ErrorMessage = "Region name is required")]
        public string RegionName { get; set; }

    }
}
