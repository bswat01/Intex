using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    public class CompoundSample
    {
        public Compound Compounds { get; set; }
        public Sample Samples { get; set; }
    }
}