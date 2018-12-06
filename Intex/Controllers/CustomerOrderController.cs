using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Intex.DAL;
using Intex.Models;

namespace Intex.Controllers
{
    public class CustomerOrderController : Controller
    {
        private ContextIntex db = new ContextIntex();
        // GET: CustomerOrder
        public ActionResult Home(Login login)
        {
            int Customer = db.Database.SqlQuery<int>(
                    "SELECT CustomerID " +
                    "FROM CUSTOMER " +
                    "WHERE Username = '" + login.Username + "' AND " +
                    "Password = '" + login.Password + "'").FirstOrDefault();
            var CustomerModel = db.Customers.Find(Customer);

            return View(CustomerModel);
        }

        public ActionResult Catalog()
        {
            //Summary information on Assay's run
            //More detailed information
            return RedirectToAction("Index", "Catalog");
        }
        [HttpGet]
        public ActionResult EditCustomer(int CustID)
        {
            var CustomerModel = db.Customers.Find(CustID);
            return View(CustomerModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCustomer([Bind(Include = "CustomerID,FirstName,LastName,CompanyName,Phone,Email,Note,Username,Password,BillingID")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BillingID = new SelectList(db.Billings, "BillingID", "AddressOne", customer.BillingID);
            return View(customer);
        }

        public ActionResult EditBilling(int id)
        {
            var Billings = db.Billings.Find(id);
            return View(Billings);
        }

        public ActionResult GetCustomerWorkOrder(int CustID)
        {
            var CheckCust = db.Database.SqlQuery<WorkOrder>(
                      "SELECT * " +
                      "FROM WorkOrder " +
                      "WHERE CustomerID = '" + CustID + "'");
            return View("CustomerWorkOrder",CheckCust);
        }
    }
}