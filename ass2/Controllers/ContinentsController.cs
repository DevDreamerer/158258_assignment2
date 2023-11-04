using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ass2.Data;
using ass2.Models;

namespace ass2.Controllers
{
    public class ContinentsController : Controller
    {
        private ass2Context db = new ass2Context();

        // GET: Continents
        public ActionResult Index()
        {
            //return View(db.Continents.ToList());
            return View(db.Continents.OrderBy(c => c.Name).ToList());
        }

        // GET: Continents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Continent continent = db.Continents.Find(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        // GET: Continents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Continents/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Continent continent)
        {
            if (ModelState.IsValid)
            {
                db.Continents.Add(continent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(continent);
        }

        // GET: Continents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Continent continent = db.Continents.Find(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        // POST: Continents/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Continent continent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(continent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(continent);
        }

        // GET: Continents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Continent continent = db.Continents.Find(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        // POST: Continents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Continent continent = db.Continents.Find(id);
            foreach (var p in continent.Endangereds)
            {
                p.ContinentID = null;
            }
            db.Continents.Remove(continent);
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
