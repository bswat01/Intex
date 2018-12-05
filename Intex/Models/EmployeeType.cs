using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("EmployeeType")]
    public class EmployeeType
    {
        [Key]
        public int EmployeeTypeID { get; set; }

        [Required]
        [Display(Name = "Employee Role")]
        public string EmployeeTypeName { get; set; }
    }
}