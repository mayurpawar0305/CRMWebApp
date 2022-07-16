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
            List<Customer> customers = CustomerManager.LoadData();            

            return View(customers);
        }
    }
}