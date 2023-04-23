using OnlineCloth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace OnlineCloth.Controllers
{
    public class HomeController : Controller
    {
        private ShopEntities _db = new ShopEntities();
        // GET: Home
        public ActionResult Index()
        {

            // ShopDBEntities db =  new ShopDBEntities();

            // return View(_db.Shops.ToList());
            return View();
        }

        // GET: Home/Details/5

        public ActionResult Details(int id)
        {
            return View();

        }
        //public ActionResult SaveRecord(Shop model)
        //{
        //private ShopEntities db = new ShopEntities();

        //Design pattern = new Design();
        //pattern.Color = new


        // return View();


        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "DesignId")] Shop DesignToCreate)
    {
            //_db.Shops.Add(DesignToCreate);
            //_db.SaveChanges();
        if (ModelState.IsValid)
            {
              
                ViewData["Message"] = "Success";

                //_db.SaveChanges();
                //TempData["Success"] = "Data Saved Successfully.";
                //return RedirectToAction("Index");

            }
        else
            {
                ViewData["Error"] = "Please try again.";
                return View();

            }

            return View();
           // _ = _db.Shops.Add(DesignToCreate);
            

       // return RedirectToAction("Index");
    }


        public ActionResult SaveRecord(Shop model)
        {
            try
            {
                ShopDBEntities db = new ShopDBEntities();

                Shop shop1 = new Shop();
                shop1.Color = model.Color;
                shop1.Size = model.Size;
                shop1.DesignData = model.DesignData;
                shop1.CreatedDate = model.CreatedDate;

                db.Shops.Add(shop1);
                db.SaveChanges();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }
}




 }

