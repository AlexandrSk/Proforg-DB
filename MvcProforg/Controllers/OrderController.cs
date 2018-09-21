using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProforgDataEF;

namespace MvcProforg.Controllers
{
    public class OrderController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        public ActionResult OrderRender()
        {
            return View(db.tab_order.ToList());
        }
        public ActionResult Edit(int id)
        {
            ViewBag.CmpList = db.tab_order.ToList();
            var R = (from c in db.tab_order where c.order_ID == id select c).First();
            return View(R);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditR(int id, FormCollection collection)
        {
            var R = (from c in db.tab_order where c.order_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("Order");
            }
            catch (Exception)
            {
                return View(R);
            }
        }

        public ActionResult Create()
        {
            tab_order R = new tab_order();
            ViewBag.CmpList = db.tab_order.ToList();
            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(tab_order R)
        {
            try
            {
                if (ModelState.IsValid)
                    db.tab_order.Add(R);
                db.SaveChanges();
                return RedirectToAction("OrderAdmin");
            }
            
            catch (Exception)
            {
                return View(R);
            }
        }
        public ActionResult Delete(int id)
        {
            var R = (from c in db.tab_order where c.order_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteR(int id, FormCollection collection)
        {
            var R = (from c in db.tab_order where c.order_ID == id select c).First();
            try
            {
                db.tab_order.Remove(R);
                db.SaveChanges();
                return RedirectToAction("OrderRender");
            }
            catch(Exception)
            {
                return View(R);
            }
        }

       
            
        }
    }

