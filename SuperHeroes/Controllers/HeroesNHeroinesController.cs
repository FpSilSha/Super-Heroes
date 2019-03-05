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
        
        public ActionResult Index()
        {
            List<HeroesNHeroines> heroesNHeroinesList = new List<HeroesNHeroines>();
            foreach(var heroOrHeroine in db.HeroesNHeroines)
            {
                heroesNHeroinesList.Add(heroOrHeroine);
            }
            return View(heroesNHeroinesList);
        }

        
        public ActionResult Read(int id)
        {
            var beingToView = db.HeroesNHeroines.Where(h => h.Id == id).FirstOrDefault();
            return View(beingToView);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
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

        
        public ActionResult Update(int id)
        {
            var heroOrHeroine = db.HeroesNHeroines.Where(h => h.Id == id).FirstOrDefault();
            return View(heroOrHeroine);
        }

        
        [HttpPost]
        public ActionResult Update(HeroesNHeroines HeroOrHeroine)
        {
            try
            {
                var beingToEdit = db.HeroesNHeroines.Where(h => h.Id == HeroOrHeroine.Id).FirstOrDefault();
                beingToEdit.SuperName = HeroOrHeroine.SuperName;
                beingToEdit.Alter_Ego_Name = HeroOrHeroine.Alter_Ego_Name;
                beingToEdit.Primary_SuperAbility = HeroOrHeroine.Primary_SuperAbility;
                beingToEdit.Secondary_SuperAbility = HeroOrHeroine.Secondary_SuperAbility;
                beingToEdit.CatchPhrase = HeroOrHeroine.CatchPhrase;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var beingToDelete = db.HeroesNHeroines.Where(h => h.Id == id).Single();
            return View(beingToDelete);
        }

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
