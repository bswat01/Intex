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

        public ActionResult Login()
        {
            return RedirectToAction("Login", "Home");
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
                return RedirectToAction("Home", customer);
            }
            ViewBag.BillingID = new SelectList(db.Billings, "BillingID", "AddressOne", customer.BillingID);
            return View(customer);
        }

        public ActionResult EditBilling(int? CustID)
        {
            int Billing = db.Database.SqlQuery<int>(
                    "SELECT BillingID " +
                    "FROM Customer " +
                    "WHERE CustomerID = '" + CustID + "'").FirstOrDefault();

            var Billings = db.Billings.Find(Billing);
            return View(Billings);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBilling([Bind(Include = "BillingID,AddressOne,AddressTwo,City,State,ZIP,CCNumber,ExpirationDate,CVCCode")] Billing billing)
        {
            int Customer = db.Database.SqlQuery<int>(
                    "SELECT CustomerID " +
                    "FROM CUSTOMER " +
                    "WHERE BillingID = '" + billing.BillingID + "'").FirstOrDefault();

            var customers = db.Customers.Find(Customer);

            if (ModelState.IsValid)
            {
                db.Entry(billing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Home", customers);
            }
            return View(billing);
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