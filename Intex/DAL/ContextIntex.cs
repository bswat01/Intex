using Intex.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Intex.DAL
{
    public class ContextIntex : DbContext
    {
        public ContextIntex()
            : base("ContextIntex")
        {

        }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Compound> Compounds { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
    }  
}