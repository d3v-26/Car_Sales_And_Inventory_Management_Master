using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Sales_And_Inventory_Management_Master.Models
{
    public class ImageWraper
    {
        [Key]
        public int imageId { get; set; }
        [Required]
        public string path { get; set; }
    }
}
