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
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Id = 23, Name = "Mayur", ContactNo = "9552030714"});
            customers.Add(new Customer() { Id = 24, Name = "Gaurav", ContactNo = "364897522" });
            customers.Add(new Customer() { Id = 25, Name = "Yash", ContactNo = "2156485456" });
            customers.Add(new Customer() { Id = 26, Name = "Rajesh", ContactNo = "9878421657" });
            customers.Add(new Customer() { Id = 27, Name = "Yogesh", ContactNo = "7654314788" });

            return this.Json(customers,JsonRequestBehavior.AllowGet);
            //return View();
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