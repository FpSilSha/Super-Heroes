﻿using System;
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
            return View();
        }

        // POST: HeroesNHeroines/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HeroesNHeroines HeroOrHeroine)
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