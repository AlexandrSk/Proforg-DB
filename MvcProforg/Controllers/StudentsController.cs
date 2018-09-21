using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using ProforgDataEF;

namespace MvcProforg.Controllers
{
    public class StudentsController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        public ActionResult StudentsRender()
        {
            return View(db.tab_students.ToList());
        }

        public ActionResult Edit(int id)
        {
            ViewBag.CmpList = db.tab_students.ToList();
            var R = (from c in db.tab_students where c.student_ID == id select c).First();
            return View(R);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditR(int id, FormCollection collection)
        {
            var R = (from c in db.tab_students where c.student_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("Students");
            }
            catch (Exception)
            {
                return View(R);
            }
        }

        public ActionResult Create()
        {
            tab_students R = new tab_students();
            ViewBag.CmpList = db.tab_students.ToList();
            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(tab_students R)
        {
            try
            {
                if (ModelState.IsValid)
                    db.tab_students.Add(R);
                db.SaveChanges();
                return RedirectToAction("StudentsRender");
            }

            catch (Exception)
            {
                return View(R);
            }
        }
        public ActionResult Delete(int id)
        {
            var R = (from c in db.tab_students where c.student_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteR(int id, FormCollection collection)
        {
            var R = (from c in db.tab_students where c.student_ID == id select c).First();
            try
            {
                db.tab_students.Remove(R);
                db.SaveChanges();
                return RedirectToAction("StudentsRender");
            }
            catch (Exception)
            {
                return View(R);
            }
        }
    }
}