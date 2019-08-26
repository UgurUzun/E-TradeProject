using E_TradeProject.MvcWebUI.Data;
using E_TradeProject.MvcWebUI.Models;
using E_TradeProject.MvcWebUI.SelectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TradeProject.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var products = db.Products
                             .Where(x => x.IsHome == true && x.IsApproved == true)
                             .Select(i => new ProductModel()
                             {
                                 Id = i.Id,
                                 Name = i.Name,
                                 Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                                 Price = i.Price,
                                 Stock = i.Stock,
                                 Image = i.Image == null ? "HuaweiP20.jpg" : i.Image,
                                 CategoryId = i.CategoryId

                             }).ToList();

            return View(products);
        }

        public ActionResult List(int? id)
        {
            var products = db.Products
                             .Where(x => x.IsApproved == true)
                             .Select(i => new ProductModel()
                             {
                                 Id = i.Id,
                                 Name = i.Name,
                                 Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                                 Price = i.Price,
                                 Stock = i.Stock,
                                 Image = i.Image == null ? "HuaweiP20.jpg" : i.Image,
                                 CategoryId = i.CategoryId

                             }).AsQueryable();

            if (id != null)
            {
                products = products.Where(x => x.CategoryId == id);
            }

            return View(products.ToList());
        }

        public ActionResult Details(int id)
        {
            var products = db.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(products);
        }

        public PartialViewResult GetCategories()
        {
            var categories = db.Categories.ToList();
            return PartialView(categories);
        }

    }
}