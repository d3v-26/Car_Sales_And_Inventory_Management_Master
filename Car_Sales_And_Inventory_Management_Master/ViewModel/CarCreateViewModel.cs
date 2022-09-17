using Car_Sales_And_Inventory_Management_Master.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Sales_And_Inventory_Management_Master.ViewModel
{
    public class CarCreateViewModel
    {
        [Key]
        [Display(Name = "Car id")]
        public string car_id { get; set; }

        [Required]
        [Display(Name = "Car Name")]
        public string name { get; set; }


        [Required]
        [Display(Name = "Car Model")]
        public string car_model { get; set; }

        [Required]
        [Display(Name = "Launch Date")]
        public DateTime launch_date { get; set; }

        [Required]
        public int no_of_images { get; set; }

        [Required]
        [Display(Name = "Ratings")]
        public float rating { get; set; }

        public string specification_id { get; set; }

        [Required]
        [Display(Name = "Car Type")]
        public car_type type { get; set; }

        [Required]
        [Display(Name = "Average")]
        public float average { get; set; }

        [Required]
        [Display(Name = "Max Speed")]
        public float max_speed { get; set; }

        [Required]
        [Display(Name = "Price")]
        public long price { get; set; }

        [Required]
        public string dimensionsId { get; set; }
        [Required]
        public Dimensions dimensions { get; set; }

        [Required]
        [Display(Name = "Number of seats")]
        public int no_of_seats { get; set; }

        [Required]
        [Display(Name = "Free space in cm")]
        public int free_space { get; set; }

        
        [Required]
        [Display(Name = "Number of airbags.")]
        public int airbags { get; set; }

        [Required]
        [Display(Name = "Fuel Consumption type")]

        public fuel_consumption_type fuel_Consumption_Type { get; set; }

        public string additional_description { get; set; }

        [Required]
        [Display(Name = "Engine Model")]
        public string engine_model { get; set; }

        [Required]
        [Display(Name = "Performance")]
        public string performance { get; set; }

        [Required]
        [Display(Name = "Efficiency")]
        public float efficiency { get; set; }
    }
}
