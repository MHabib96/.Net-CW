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
            var model = db.Products.LastOrDefault();
            return View(model);
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
