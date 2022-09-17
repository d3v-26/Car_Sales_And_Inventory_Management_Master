using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Sales_And_Inventory_Management_Master.Models
{
    public class Engine
    {
        [Key]
        public int engineId { get; set; }

        [Required]
        [Display(Name ="Model")]
        public string engine_model { get; set; }

        [Required]
        [Display(Name ="Performance")]
        public string performance { get; set; }

        [Required]
        [Display(Name ="Efficiency")]
        public float efficiency { get; set; }
    }
}
