using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    public class OrderCompound
    {
        public WorkOrder WorkOrders { get; set; }
        public Compound Compounds { get; set; }
    }
}