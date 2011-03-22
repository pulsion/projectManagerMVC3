using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projectManagerMVC3.Models;

namespace projectManagerMVC3.Controllers
{   
    public class StaffHolidaysController : Controller
    {
        projectManager projManager = new projectManager();

        //
        // GET: /StaffHolidays/

        public ViewResult Index()
        {

            var staffHolidays = from s in projManager.StaffHolidays
                                select s;
            return View(staffHolidays.ToList());
        }

        ////
        //// GET: /StaffHolidays/Details/5

        public ViewResult Details(int id)
        {
            var staffHolidays = projManager.StaffHolidays.Single(x => x.id == id);
            return View(staffHolidays);
        }

        ////
        //// GET: /StaffHolidays/Create

        public ActionResult Create()
        {
            return View();
        } 

        ////
        //// POST: /StaffHolidays/Create

        [HttpPost]
        public ActionResult Create(t_staff_holiday staffholidays)
        {
            if (ModelState.IsValid)
            {
                projManager.StaffHolidays.Add(staffholidays);
                projManager.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(staffholidays);
        }
        
        ////
        //// GET: /StaffHolidays/Edit/5

        public ActionResult Edit(int id)
        {
            var staffHolidays = projManager.StaffHolidays.Single(x => x.id == id);
            return View(staffHolidays);
        }

        ////
        //// POST: /StaffHolidays/Edit/5

        [HttpPost]
        public ActionResult Edit(t_staff_holiday staffholidays)
        {
            if (ModelState.IsValid)
            {
                projManager.Entry(staffholidays).State = EntityState.Modified;
                projManager.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(staffholidays);
        }

        ////
        //// GET: /StaffHolidays/Delete/5

        public ActionResult Delete(int id)
        {
            var staffHolidays = projManager.StaffHolidays.Single(x => x.id == id);
            return View(staffHolidays);
        }

        ////
        //// POST: /StaffHolidays/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var staffHolidays = projManager.StaffHolidays.Single(x => x.id == id);
            projManager.StaffHolidays.Remove(staffHolidays);
            projManager.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}