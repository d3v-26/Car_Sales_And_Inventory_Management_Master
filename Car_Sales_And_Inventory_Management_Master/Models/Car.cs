using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Sales_And_Inventory_Management_Master.Models
{
    public class Car
    {
        [Key]
        [Display(Name ="Car id")]
        public int car_id { get; set; }

        [Required]
        [Display(Name ="Car Name")]
        public string name { get; set; }


        [Required]
        [Display(Name ="Car Model")]
        public string car_model { get; set; }

        [Required]
        [Display(Name ="Launch Date")]
        public DateTime launch_date { get; set; }

        [Required]
        public int no_of_images { get; set; }

        [Required]
        [Display(Name ="Ratings")]
        public float rating { get; set; }

        [Required]
        public int specificationId { get; set; }
        [Required]
        public Specification specification { get; set; }

        [Required]
        public int imageId { get; set; }
        [Required]
        public ImageWraper image { get; set; }
    }
}
