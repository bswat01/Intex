using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace Intex.Models
{
    [Table("Sample")]
    public class Sample
    {
        [Key]
        public int SampleID { get; set; }
        [Display(Name = "Date Sample Collected")]
        public string SampleDateCollected { get; set; }

        [Display(Name ="Sample Active Status")]
        public bool? SampleActive { get; set; }

        [Display(Name = "Sample Concentration")]
        public decimal SampleConcentration { get; set; }

        [Display(Name = "Sample Results")]
        public string SampleResults { get; set; }
        
        [ForeignKey("Test")]
        public virtual int TestID { get; set; }
        public virtual Test Test { get; set; }

        [ForeignKey("Compound")]
        public virtual int CompoundID { get; set; }
        public virtual Compound Compound { get; set; }
    }
}