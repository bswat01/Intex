using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        [Display(Name = "Employee First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Employee Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Employee Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Employee Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Hourly Wage")]
        public decimal HourlyWage { get; set; }

        //Foreign Keys
        [Required]
        [ForeignKey("Location")]
        public virtual int LocationID { get; set; }
        public virtual Location Location { get; set; }

        [Required]
        [ForeignKey("EmployeeType")]
        public virtual int EmployeeTypeID { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }

    }
}