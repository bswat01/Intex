using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("Billing")]
    public class Billing
    {
        [Key]
        public int BillingID { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressOne { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressTwo { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "ZIP")]
        public string ZIP { get; set; }

        [Required]
        [Display(Name = "Credit Card Number")]
        public string CCNumber { get; set; }

        [Required]
        [Display(Name = "Expiration Date")]
        public string ExpirationDate { get; set; }

        [Required]
        [Display(Name = "CVC Code")]
        public int CVCCode { get; set; }

    }
}