using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_Demo_Entity_FrameWork.Models;

namespace WebSite_Demo_Entity_FrameWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDbContext db = new ProductDbContext();
        // GET: Home
        public ActionResult Index()
        {
            db.Products.ToList();
            return View();
        }
    }
}