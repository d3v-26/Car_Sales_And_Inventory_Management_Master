using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Sales_And_Inventory_Management_Master.Models
{
    public enum car_type
    {
        sedan,
        coupe,
        sport,
        station_wagon,
        hatchback,
        convertible,
        suv,
        minivan,
        pickup_truck
    }

    public enum fuel_consumption_type
    {
        diesel,
        petrol,
        CNG,
        electric
    }

    public class Specification
    {
        [Key]
        public int specification_id { get; set; }

        [Required]
        [Display(Name = "Car Type")]
        public car_type type { get; set; }

        [Required]
        [Display(Name = "Average")]
        public float average { get; set; }

        [Required]
        [Display(Name ="Max Speed")]
        public float max_speed { get; set; }

        [Required]
        [Display(Name ="Price")]
        public long price { get; set; }

        [Required]
        public int dimensionsId { get; set; }
        [Required]
        public Dimensions dimensions { get; set; }

        [Required]
        [Display(Name ="Number of seats")]
        public int no_of_seats { get; set; }

        [Required]
        [Display(Name ="Free space in cm")]
        public int free_space { get; set; }

        [Required]
        public int engineId { get; set; }
        [Required]
        public Engine engine { get; set; }

        [Required]
        [Display(Name ="Number of airbags.")]
        public int airbags { get; set; }

        [Required]
        [Display(Name ="Fuel Consumption type")]
        public fuel_consumption_type fuel_Consumption_Type { get; set; }

        public string additional_description { get; set; }
    }
}
