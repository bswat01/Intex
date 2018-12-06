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

        [Display(Name = "Order Final Price")]
        public decimal? OrderFinalPrice { get; set; }

        [Display(Name = "Order Due Date")]
        public string OrderDueDate { get; set; }

        //Foreign Keys
        [ForeignKey("Customer")]
        public virtual int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Discount")]
        public virtual int DiscountID { get; set; }
        public virtual Discount Discount { get; set; }

        [ForeignKey("Employee")]
        public virtual int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Quote")]
        public virtual int QuoteID { get; set; }
        public virtual Quote Quote { get; set; }

    }
}