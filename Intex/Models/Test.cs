using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int TestID { get; set; }

        [Required]
        [Display(Name ="Test Name")]
        public string TestDescription { get; set; }

        [Required]
        [Display(Name = "Test Cost")]
        public decimal TestCost { get; set; }

        [Required]
        [Display(Name = "Base Customer Price")]
        public decimal BasePrice { get; set; }

        //Number od Days to complete the test
        [Required]
        [Display(Name = "Days to Complete")]
        public int NumberDays { get; set; }
    }
}