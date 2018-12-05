using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("WorkOrder")]
    public class WorkOrder
    {
        [Key]
        public int WorkOrderID { get; set; }

        [Display(Name = "Date of Order Completion")]
        public string OrderCompleteDate { get; set; }

        public float? OrderFinalPrice { get; set; }

        public string OrderDueDate { get; set; }

        //Foreign Keys
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Discount")]
        public int DiscountID { get; set; }
        public virtual Discount Discount { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Quote")]
        public int QuoteID { get; set; }
        public virtual Quote Quote { get; set; }

    }
}