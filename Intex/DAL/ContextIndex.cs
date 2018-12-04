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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
    }  
}