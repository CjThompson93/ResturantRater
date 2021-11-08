using ResturantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResturantRater.Controllers
{
    public class ResturantController : Controller
    {
        private ResturantDbContext _db = new ResturantDbContext();

        // GET: Resturant
        public ActionResult Index()
        {
            return View(_db.Resturants.ToList());
        }
    }
}