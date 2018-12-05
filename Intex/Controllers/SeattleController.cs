using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intex.DAL;
using Intex.Models;

namespace Intex.Controllers
{
    public class SeattleController : Controller
    {
        private ContextIntex db = new ContextIntex();
        // GET: Seattle
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FindCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FindCustomer(Customer customer)
        {
            var CheckCustomer = db.Database.SqlQuery<Customer>(
                   "SELECT * " +
                   "FROM CUSTOMER " +
                   "WHERE Username = '" + customer.Username + "'");

            if (CheckCustomer.Count() > 0)
            {
                return View("CustomerFound", CheckCustomer);
            }
            return View();
        }

        public ActionResult FindWorkOrder()
        {
            return View();
        }

        public ActionResult FindCustomerWorkOrder(int custID)
        {
            var FindCustomer = db.Database.SqlQuery<WorkOrder>(
                   "SELECT * " +
                   "FROM WorkOrder " +
                   "WHERE CustomerID = '" + custID + "'");

            return View(FindCustomer);
        }

        public ActionResult CreateQuota()
        {
            return View();
        }
    }
}