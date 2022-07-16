using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //Models has been use

using CRMWebApp.Models;
namespace CRMWebApp.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        //List of Action Method
        public ActionResult Index()
        {            
            return View();
        }
        public ActionResult AboutUs()
        {
            return this.View();
        }
        public ActionResult Contact()
        {
            return this.View();
        }
    }
}