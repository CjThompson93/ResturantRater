using ResturantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ResturantRater.Controllers
{
    public class ResturantController : Controller
    {
        private ResturantDbContext _db = new ResturantDbContext();

        // GET: Resturant
        public ActionResult Index()
        {
            return View(_db.Resturants.ToList());
        }

        // Get: Resturant/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Resturant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Resturant resturant)
        {
            if (ModelState.IsValid)
            {
                _db.Resturants.Add(resturant);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resturant);
        }

        //GET: Resturant/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Resturant resturant = _db.Resturants.Find(id);
            if (resturant == null)
            {
                return HttpNotFound();
            }
            return View(resturant);
        }

        //POST: Resturant/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Resturant resturant = _db.Resturants.Find(id);
            _db.Resturants.Remove(resturant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Get: Resturant/Edit/{id}
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resturant resturant = _db.Resturants.Find(id);
            if (resturant == null)
            {
                return HttpNotFound();
            }
            return View(resturant);
        }

        //POST: Resturant/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Resturant resturant)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(resturant).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resturant);
        }
    }
}