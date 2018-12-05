using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        public int CompoundID { get; set; }
        
        [Required]
        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; }

        [Required]
        [Display(Name = "Compound Quantity (mg)")]
        public int CompoundQuantity { get; set; }

        [Required]
        [Display(Name = "Date Compound Arrived")]
        public string CompoundDateArrived { get; set; }

        [Required]
        [Display(Name = "Compound Received By")]
        public string CompoundReceivedBy { get; set; }

        [Required]
        [Display(Name = "Date Compound Due")]
        public string CompoundDateDue { get; set; }

        [Required]
        [Display(Name = "Compound Appearance")]
        public string CompoundAppearance { get; set; }

        [Required]
        [Display(Name = "Compound Weight")]
        public float CompoundWeight { get; set; }

        [Required]
        [Display(Name = "Compound Molecular Mass")]
        public float CompoundMolecularMass { get; set; }

        [Required]
        [Display(Name = "Compound Max Tolerated Dose")]
        public float CompoundMaxToleratedDose { get; set; }



    }
}