using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CRMWebApp.Models;

namespace CRMWebApp.Controllers
{
    //customer/index
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Id = 23, Name = "Mayur", ContactNo = "9552030714" });
            customers.Add(new Customer() { Id = 24, Name = "Gaurav", ContactNo = "364897522" });
            customers.Add(new Customer() { Id = 25, Name = "Yash", ContactNo = "2156485456" });
            customers.Add(new Customer() { Id = 26, Name = "Rajesh", ContactNo = "9878421657" });
            customers.Add(new Customer() { Id = 27, Name = "Yogesh", ContactNo = "7654314788" });
            customers.Add(new Customer() { Id = 28, Name = "Atharva", ContactNo = "13468768" });

            return View(customers);
        }
    }
}