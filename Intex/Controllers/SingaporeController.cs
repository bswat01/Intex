﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intex.DAL;
using Intex.Models;

namespace Intex.Controllers
{
    public class SingaporeController : Controller
    {
        private ContextIntex db = new ContextIntex();
        // GET: Singapore
        public ActionResult Home()
        {
            return View();
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

        public ActionResult AccessWorkOrders()
        {
            return RedirectToAction("Index", "WorkOrders");
        }
    }
}