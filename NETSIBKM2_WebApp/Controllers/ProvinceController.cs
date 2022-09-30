using Jint.Runtime.Debugger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NETSIBKM2_WebApp.Context;
using NETSIBKM2_WebApp.Models;
using System.Linq;

namespace NETSIBKM2_WebApp.Controllers
{
    public class ProvinceController : Controller
    {
        MyContext myContext;

        public ProvinceController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        // GET ALL
        // GET
        public IActionResult Index()
        {
            var data = myContext.Provinces.Include(x => x.Region).ToList();
            return View(data);

        }

        // GET BY ID
        // GET
        public IActionResult Details(int id)
        {
            //var data = myContext.Provinces.Find(id);
            var data = myContext.Provinces.Include(x => x.Region).FirstOrDefault(x => x.Id.Equals(id));
            return View(data);

        }

        // CREATE
        // GET
        public IActionResult Create()
        {
            return View();

        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Province country)
        {
            if (ModelState.IsValid)
            {
                myContext.Provinces.Add(country);
                var result = myContext.SaveChanges();
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();

        }

        // Edit
        // GET
        public IActionResult Update()
        {
            return View();

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Province country)
        {
            if (ModelState.IsValid)
            {
                //myContext.Update(country).State = EntityState.Modified;
                //myContext.SaveChanges();
                //return RedirectToAction("Index");
                myContext.Provinces.UpdateRange(country);
                var result = myContext.SaveChanges();
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
            }

        // Hapus
        // GET
        public IActionResult Delete(Province country)
        {
            if (ModelState.IsValid)
            {
                myContext.Provinces.Remove(country);
                var result = myContext.SaveChanges();
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();

        }
    }

}
