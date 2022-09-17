using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Sales_And_Inventory_Management_Master.Models
{
    public enum emp_role
    {
        Manufacturer,
        Manager
    }
    public class Employee
    {
        [Key]
        [Display(Name = "Employee ID")]
        public string emp_id { get; set; }
        
        [Required, MaxLength(40, ErrorMessage = "Name Cannot Exceed 40 Characters")]
        [Display(Name = "Employee Name")]
        public string emp_name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        
        [Required]
        [Display(Name = "Empolyee Role")]
        public emp_role position { get; set; }
    }
}
