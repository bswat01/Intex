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
            return RedirectToAction("IndexSeattle", "WorkOrders");
        }

        public ActionResult CreateQuota()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateQuota(Compound compound)
        {
            
            if (compound.CompoundName == "Compound Test 1" || compound.CompoundName == "Compound Test 2" || compound.CompoundName == "Compound Test 3" )
            {
                ViewBag.Amount = "$11,000 - $15,000";
                ViewBag.TestsNeeded = "<li>Biochemical Pharmacology® (BP)</li>" +
                    "<li>DiscoveryScreen® (DS)</li>";
                return View("QuoteAmount");
            }
            ViewBag.NoTest = "Tests have not yet been determined";
            ViewBag.Amount = "Will soon be determined by qualified staff";
            return View("QuoteAmount");
        }

        public ActionResult NewWorkOrder()
        {
            return RedirectToAction("Create", "WorkOrders");
        }
    }
}