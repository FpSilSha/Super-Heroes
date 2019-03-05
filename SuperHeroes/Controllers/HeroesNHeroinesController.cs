using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperHeroes.Models;

namespace SuperHeroes.Controllers
{
    public class HeroesNHeroinesController : Controller
    {
        ApplicationDbContext db;
        public HeroesNHeroinesController()
        {
            db = new ApplicationDbContext();
        }
        // GET: HeroesNHeroines
        public ActionResult Index()
        {
            List<HeroesNHeroines> heroesNHeroinesList = new List<HeroesNHeroines>();
            foreach(var heroOrHeroine in db.HeroesNHeroines)
            {
                heroesNHeroinesList.Add(heroOrHeroine);
            }
            return View(heroesNHeroinesList);
        }

        // GET: HeroesNHeroines/Details/5
        public ActionResult Details(int id)
        {
            var beingToView = db.HeroesNHeroines.Where(h => h.Id == id).FirstOrDefault();
            return View(beingToView);
        }

        // GET: HeroesNHeroines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroesNHeroines/Create
        [HttpPost]
        public ActionResult Create(HeroesNHeroines HeroOrHeroine)
        {
            try
            {
               
                db.HeroesNHeroines.Add(HeroOrHeroine);
                db.SaveChanges();
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
            var heroOrHeroine = db.HeroesNHeroines.Where(h => h.Id == id).FirstOrDefault();
            return View(heroOrHeroine);
        }

        // POST: HeroesNHeroines/Edit/5
        [HttpPost]
        public ActionResult Edit(HeroesNHeroines HeroOrHeroine)
        {
            try
            {

                var superName = HeroOrHeroine.SuperName;
                var alter_Ego = HeroOrHeroine.Alter_Ego_Name;
                var primary_Ability = HeroOrHeroine.Primary_SuperAbility;
                var secondary_Ability = HeroOrHeroine.Secondary_SuperAbility;
                var catch_Phrase = HeroOrHeroine.CatchPhrase;
                // TODO: Add update logic here
                db.SaveChanges();
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
            HeroesNHeroines beingToDelete = db.HeroesNHeroines.Where(h => h.Id == id).Single();
            return View(beingToDelete);
        }

        // POST: HeroesNHeroines/Delete/5
        [HttpPost]
        public ActionResult Delete(HeroesNHeroines HeroOrHeroine)
        {
            try
            {
                db.HeroesNHeroines.Remove(HeroOrHeroine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
