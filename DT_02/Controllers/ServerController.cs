using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using DT_02.Models;

namespace DT_02.Controllers
{
    public class ServerController : Controller
    {
        // GET: Server
        public ActionResult Index()
        {
            FormGenerator fg = new FormGenerator();
            FormBlock fb = new FormBlock();
            string path = fg.GetJsonFile(HostingEnvironment.MapPath("~/Content/data/form1.json"));
            fb.div = fg.ParseJsonFile(path);
            return View(fb);
        }
        public ActionResult Index2()
        {
            FormGenerator fg = new FormGenerator();
            FormBlock fb = new FormBlock();
            string path = fg.GetJsonFile(HostingEnvironment.MapPath("~/Content/data/form2.json"));
            fb.div = fg.ParseJsonFile(path);
            return View(fb);
        }
    }
}