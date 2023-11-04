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
using ass2.ViewModels;
using PagedList;

namespace ass2.Controllers
{
    public class EndangeredsController : Controller
    {
        private ass2Context db = new ass2Context();

        // GET: Endangereds
        public ActionResult Index(string continent,string search, string sortBy, int? page)
        {
            
            EndangeredIndexViewModel viewModel = new EndangeredIndexViewModel();
            var endangereds = db.Endangereds.Include(p => p.Continent);

            if (!String.IsNullOrEmpty(search))
            {
                endangereds = endangereds.Where(p => p.Name.Contains(search) ||
                p.Description.Contains(search) ||
                p.Continent.Name.Contains(search));
                //ViewBag.Search = search;
                viewModel.Search = search;
            }

            viewModel.CatsWithCount = from matchingProducts in endangereds
                                      where
                                      matchingProducts.ContinentID != null
                                      group matchingProducts by
                                      matchingProducts.Continent.Name into
                                      catGroup
                                      select new ContinentWithCount()
                                      {
                                          CategoryName = catGroup.Key,
                                          ProductCount = catGroup.Count()
                                      };

            //var continents = endangereds.OrderBy(p => p.Continent.Name).Select(p => p.Continent.Name).Distinct();

            if (!String.IsNullOrEmpty(continent))
            {
                endangereds = endangereds.Where(p => p.Continent.Name == continent);
                viewModel.Continent = continent;
            }

            //sort the results
            switch (sortBy)
            {
                case "numbers_lowest":
                    endangereds = endangereds.OrderBy(p => p.Number);
                    break;
                case "numbers_highest":
                    endangereds = endangereds.OrderByDescending(p => p.Number);
                    break;
                default:
                    endangereds = endangereds.OrderBy(p => p.Name);
                    break;
            }

            viewModel.SortBy = sortBy;
            viewModel.Sorts = new Dictionary<string, string>
 {
 {"Survival quantity low to high", "numbers_lowest" },
 {"Survival quantity high to low", "numbers_highest" }
 };

            const int PageItems = 10;
            int currentPage = (page ?? 1);
            viewModel.Endangereds = endangereds.ToPagedList(currentPage, PageItems);

            //ViewBag.Continent = new SelectList(continents);
            //viewModel.Endangereds = endangereds;
            //return View(endangereds.ToList());
            
            return View(viewModel);
        }

        // GET: Endangereds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endangered endangered = db.Endangereds.Find(id);
            if (endangered == null)
            {
                return HttpNotFound();
            }
            return View(endangered);
        }

        // GET: Endangereds/Create
        public ActionResult Create()
        {
            ViewBag.ContinentID = new SelectList(db.Continents, "ID", "Name");
            return View();
        }

        // POST: Endangereds/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Number,Description,ContinentID")] Endangered endangered)
        {
            if (ModelState.IsValid)
            {
                db.Endangereds.Add(endangered);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContinentID = new SelectList(db.Continents, "ID", "Name", endangered.ContinentID);
            return View(endangered);
        }

        // GET: Endangereds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endangered endangered = db.Endangereds.Find(id);
            if (endangered == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContinentID = new SelectList(db.Continents, "ID", "Name", endangered.ContinentID);
            return View(endangered);
        }

        // POST: Endangereds/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Number,Description,ContinentID")] Endangered endangered)
        {
            if (ModelState.IsValid)
            {
                db.Entry(endangered).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContinentID = new SelectList(db.Continents, "ID", "Name", endangered.ContinentID);
            return View(endangered);
        }

        // GET: Endangereds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endangered endangered = db.Endangereds.Find(id);
            if (endangered == null)
            {
                return HttpNotFound();
            }
            return View(endangered);
        }

        // POST: Endangereds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Endangered endangered = db.Endangereds.Find(id);
            db.Endangereds.Remove(endangered);
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
