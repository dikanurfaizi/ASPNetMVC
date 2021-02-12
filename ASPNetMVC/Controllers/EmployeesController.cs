using ASPNetMVC.Context;
using ASPNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        private MyContext myContext = new MyContext();
        public ActionResult Index()
        {
            return View(myContext.Employees.ToList());
        }

        public ActionResult Details(int Id)
        {
            return View(myContext.Employees.Find(Id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            myContext.Employees.Add(employee);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            return View(myContext.Employees.Find(Id));
        }
        
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            myContext.Entry(employee).State = EntityState.Modified;
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            return View(myContext.Employees.Find(Id));
        }
        
        [HttpPost]
        public ActionResult Delete(Employee employee, int Id)
        {
            var delete = myContext.Employees.Find(Id);
            myContext.Employees.Remove(delete);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}