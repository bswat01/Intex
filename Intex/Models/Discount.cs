using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("Discount")]
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }

        [Display(Name ="Discount Amount")]
        public float DiscountAmount { get; set; }
    }
}