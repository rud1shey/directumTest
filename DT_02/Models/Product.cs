using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DT_02.Models
{
    public class Product : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}