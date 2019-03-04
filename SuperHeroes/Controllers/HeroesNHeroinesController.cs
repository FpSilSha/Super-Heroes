using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroes.Controllers
{
    public class HeroesNHeroinesController : Controller
    {
        // GET: HeroesNHeroines
        public ActionResult Index()
        {
            return View();
        }

        // GET: HeroesNHeroines/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HeroesNHeroines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroesNHeroines/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroesNHeroines/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HeroesNHeroines/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroesNHeroines/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HeroesNHeroines/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
