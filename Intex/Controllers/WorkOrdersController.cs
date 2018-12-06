using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Intex.DAL;
using Intex.Models;

namespace Intex.Controllers
{
    public class WorkOrdersController : Controller
    {
        private ContextIntex db = new ContextIntex();

        // GET: WorkOrders
        public ActionResult Index()
        {
            var workOrders = db.WorkOrders.Include(w => w.Customer).Include(w => w.Discount).Include(w => w.Employee).Include(w => w.Quote);
            return View(workOrders.ToList());
        }

        public ActionResult IndexSeattle()
        {
            var workOrders = db.WorkOrders.Include(w => w.Customer).Include(w => w.Discount).Include(w => w.Employee).Include(w => w.Quote);
            return View(workOrders.ToList());
        }

        // GET: WorkOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // GET: WorkOrders/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "FirstName");
            ViewBag.DiscountID = new SelectList(db.Discounts, "DiscountID", "DiscountID");
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName");
            ViewBag.QuoteID = new SelectList(db.Quotes, "QuoteID", "QuoteID");
            return View();
        }

        // POST: WorkOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkOrderID,OrderCompleteDate,OrderFinalPrice,OrderDueDate,CustomerID,DiscountID,EmployeeID,QuoteID")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                db.WorkOrders.Add(workOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "FirstName", workOrder.CustomerID);
            ViewBag.DiscountID = new SelectList(db.Discounts, "DiscountID", "DiscountID", workOrder.DiscountID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", workOrder.EmployeeID);
            ViewBag.QuoteID = new SelectList(db.Quotes, "QuoteID", "QuoteID", workOrder.QuoteID);
            return View(workOrder);
        }

        // GET: WorkOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "FirstName", workOrder.CustomerID);
            ViewBag.DiscountID = new SelectList(db.Discounts, "DiscountID", "DiscountID", workOrder.DiscountID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", workOrder.EmployeeID);
            ViewBag.QuoteID = new SelectList(db.Quotes, "QuoteID", "QuoteID", workOrder.QuoteID);
            return View(workOrder);
        }

        // POST: WorkOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkOrderID,OrderCompleteDate,OrderFinalPrice,OrderDueDate,CustomerID,DiscountID,EmployeeID,QuoteID")] WorkOrder workOrder)
        {


            if (ModelState.IsValid)
            {
                db.Entry(workOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "FirstName", workOrder.CustomerID);
            ViewBag.DiscountID = new SelectList(db.Discounts, "DiscountID", "DiscountID", workOrder.DiscountID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", workOrder.EmployeeID);
            ViewBag.QuoteID = new SelectList(db.Quotes, "QuoteID", "QuoteID", workOrder.QuoteID);
            return View(workOrder);
        }

        // GET: WorkOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // POST: WorkOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkOrder workOrder = db.WorkOrders.Find(id);
            db.WorkOrders.Remove(workOrder);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
