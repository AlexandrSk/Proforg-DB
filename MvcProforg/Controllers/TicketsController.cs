using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProforgDataEF;

namespace MvcProforg.Controllers
{
    public class TicketsController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        public ActionResult TicketsRender()
        {
            return View(db.tab_tickets.ToList());
        }

        public ActionResult Edit(int id)
        {
            ViewBag.CmpList = db.tab_tickets.ToList();
            var R = (from c in db.tab_tickets where c.ticket_ID == id select c).First();
            return View(R);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditR(int id, FormCollection collection)
        {
            var R = (from c in db.tab_tickets where c.ticket_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("Tickets");
            }
            catch (Exception)
            {
                return View(R);
            }
        }

        public ActionResult Create()
        {
            tab_tickets R = new tab_tickets();
            ViewBag.CmpList = db.tab_tickets.ToList();
            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(tab_tickets R)
        {
            try
            {
                if (ModelState.IsValid)
                    db.tab_tickets.Add(R);
                db.SaveChanges();
                return RedirectToAction("TicketsAdmin");
            }

            catch (Exception)
            {
                return View(R);
            }
        }
        public ActionResult Delete(int id)
        {
            var R = (from c in db.tab_tickets where c.ticket_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteR(int id, FormCollection collection)
        {
            var R = (from c in db.tab_tickets where c.ticket_ID == id select c).First();
            try
            {
                db.tab_tickets.Remove(R);
                db.SaveChanges();
                return RedirectToAction("TicketsAdmin");
            }
            catch (Exception)
            {
                return View(R);
            }
        }
    }
}