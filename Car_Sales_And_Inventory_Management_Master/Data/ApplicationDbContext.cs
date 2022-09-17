using Car_Sales_And_Inventory_Management_Master.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;
using Car_Sales_And_Inventory_Management_Master.ViewModel;

namespace Car_Sales_And_Inventory_Management_Master.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Employee> employees { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }

        public DbSet<Specification> Specifications { get; set; }

        public DbSet<ImageWraper> Images { get; set; }

        public DbSet<Car_Sales_And_Inventory_Management_Master.ViewModel.CarCreateViewModel> CarCreateViewModel { get; set; }
    }
}
