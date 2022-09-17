using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Sales_And_Inventory_Management_Master.Models
{
    public class Dimensions
    {
        [Key]
        public int dimesion_id { get; set; }

        [Required]
        [Display(Name = "Height in cm")]
        public float height { get; set; }

        [Required]
        [Display(Name = "Width in cm")]
        public float width { get; set; }

        [Required]
        [Display(Name = "Length in cm")]
        public float length { get; set; }
    }

}
