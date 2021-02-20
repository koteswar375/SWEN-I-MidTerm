using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidTermProject.Controllers
{
    public class Level1Controller : Controller
    {
        class Capcacity
        {
            public int CapacityOfBigBucket { get; set; }
            public int CapacityOfSmallBucket { get; set; }

            public void Capacity()
            {
                CapacityOfBigBucket = 5;
                CapacityOfSmallBucket = 3;
            }
        }
        
    
        // GET: Level1Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Level1Controller/Bucket
        public ActionResult Bucket()
        {
            ViewData["CapacityOfBigBucket"] = 5;
            ViewData["CapacityOfSmallBucket"] = 3;
            return View("Bucket");
        }

        // GET: Level1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Level1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Level1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Level1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Level1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Level1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
