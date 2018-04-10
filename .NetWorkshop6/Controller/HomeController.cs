using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetWorkshop5.Models;

namespace NetWorkshop5.Controllers
{
    public class HomeController : Controller
    {
        SportsDB db = new SportsDB();

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public PartialViewResult Search(string q)
        {
            var _searchResult = db.Products.Where(r => r.Name.Contains(q) || string.IsNullOrEmpty(q)).Take(10);
            return PartialView("_ProductList", _searchResult);
        }

        [HttpGet] //Adding AddProduct() Controller
        public ViewResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                return RedirectToAction("ProductList");
            }
            else
            {
                return View();
            }
        }

        public ViewResult ProductList()
        {
            var model = db.Products.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}