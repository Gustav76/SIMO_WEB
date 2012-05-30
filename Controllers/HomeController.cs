using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIMO_CORE.Modelo;

namespace SIMO_WEB.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            config.comprobarSesiones();
            ViewData["Message"] = "ASP.NET MVC";
            ViewData["usuarios"]  = Usuario.Listar();
            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }


     
    }
}
