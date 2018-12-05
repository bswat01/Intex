using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("Material")]
    public class Material
    {
        [Key]
        public int MaterialID { get; set; }

        [Required]
        [Display(Name ="Material Name")]
        public string MaterialName { get; set; }

        [Required]
        [Display(Name = "Material Cost")]
        public decimal MaterialCost { get; set; }
    }
}