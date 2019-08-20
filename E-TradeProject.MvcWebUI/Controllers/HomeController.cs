using E_TradeProject.MvcWebUI.Data;
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
            var products = db.Products.Where(x=>x.IsHome == false && x.IsApproved == true).ToList();
            return View(products);
        }

        public ActionResult List()
        {
            var products = db.Products.Where(x => x.IsApproved == true).ToList();
            return View();
        }

        public ActionResult Details(int id)
        {
            var products = db.Products.Where(x =>x.Id == id).FirstOrDefault();
            return View();
        }


    }
}