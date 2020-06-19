using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreKom.Models;

namespace StoreKom.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> _products = new List<Product>
        {
            new Product {Id = 1, Name = "Procesor", Description = "Jednostka obliczeniowa", Price = 300},
             new Product {Id = 2, Name = "Mysz", Description = "Myszka", Price = 50},
             new Product {Id = 3, Name = "Karta graficzna", Description = "Wyświetla obiekty 3D", Price = 1500},
             new Product {Id = 4, Name = "Kamera", Description = "Nagrywa", Price = 150},
        };


        // GET: Product
        public ActionResult Index()
        {
            var model = _products;
            return View(model);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var model = _products.FirstOrDefault(p => p.Id == id);
            if (model == null)
                return RedirectToAction("Index");

            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
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

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
