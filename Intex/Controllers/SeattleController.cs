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
    }
}