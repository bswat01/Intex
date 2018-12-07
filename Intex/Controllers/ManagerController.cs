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
    public class ManagerController : Controller
    {
        private ContextIntex db = new ContextIntex();
        // GET: Manager
        public ActionResult Home(Login login)
        {

            int Employee = db.Database.SqlQuery<int>(
                    "SELECT EmployeeID " +
                    "FROM Employee " +
                    "WHERE Username = '" + login.Username + "' AND " +
                    "Password = '" + login.Password + "'").FirstOrDefault();
            var EmployeeModel = db.Employees.Find(Employee);
            return View(EmployeeModel);
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

        public ActionResult EditEmployee()
        {
            return RedirectToAction("Index", "Employees");
        }

        public ActionResult GetWorkOrders()
        {
            return RedirectToAction("Index", "Employees");
        }

        public ActionResult AddDiscount()
        {
            return RedirectToAction("Index", "Discounts");
        }
    }
}