using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("Quote")]
    public class Quote
    {
        [Key]
        public int QuoteID { get; set; }

        [Required]
        [Display(Name = "Quote Amount")]
        public float QuoteAmount { get; set; }
    }
}