using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intex.DAL;
using Intex.Models;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private ContextIntex db = new ContextIntex();
        
        public static bool? bLoggedin;
        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Error = " ";
            return View();
        }

        public ActionResult Login(Login login)
        {

            if (ModelState.IsValid)
            {
                var CheckSeattle = db.Database.SqlQuery<Employee>(
                      "SELECT * " +
                      "FROM EMPLOYEE " +
                      "WHERE Username = '" + login.Username + "' AND " +
                      "Password = '" + login.Password + "' " +
                      "AND LocationID = 1");
                var CheckSing = db.Database.SqlQuery<Employee>(
                      "SELECT * " +
                      "FROM EMPLOYEE " +
                      "WHERE Username = '" + login.Username + "' AND " +
                      "Password = '" + login.Password + "' " +
                      "AND LocationID = 2");

                var CheckCustomer = db.Database.SqlQuery<Customer>(
                    "SELECT * " +
                    "FROM CUSTOMER " +
                    "WHERE Username = '" + login.Username + "' AND " +
                    "Password = '" + login.Password + "'");

                //View for Employee in Seattle
                if (CheckSeattle.Count() > 0)
                {
                    return RedirectToAction("Home", "Seattle");
                }
                //View for Employee in Singapore
                if (CheckSing.Count() > 0)
                {
                    return RedirectToAction("Home", "Singapore");
                }
                //View for Customer
                if (CheckCustomer.Count() > 0)
                {
                    return RedirectToAction("Home", "CustomerOrder");
                }
                ViewBag.Error = "<p>Login Error. Please check your:" +
                "<ul> <li>Username</li>" +
                "<li>Password</li></ul>";
                return View(login);
            }
            return View(login);
        }
    }
}