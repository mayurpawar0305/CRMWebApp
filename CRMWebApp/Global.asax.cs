using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CRMWebApp.Models;
namespace CRMWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           /* List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 101, FirstName = "Mayur", LastName = "Pawar", Department = "ETC", Email = "mayurpawar0305@gmail.com", Location = "Amravati", ConatctNumber = "9552748845" });
            employees.Add(new Employee { Id = 102, FirstName = "Yash", LastName = "Hajare", Department = "IT", Email = "yash@gmail.com", Location = "Yavatmal", ConatctNumber = "56465465" });
            employees.Add(new Employee { Id = 103, FirstName = "Atharva", LastName = "Thakare", Department = "Civil", Email = "atharva@gmail.com", Location = "Pune", ConatctNumber = "4656735" });
            employees.Add(new Employee { Id = 104, FirstName = "Gaurav", LastName = "Kawalakar", Department = "CS", Email = "gaurav@gmail.com", Location = "Mumnai", ConatctNumber = "648976546" });
            employees.Add(new Employee { Id = 105, FirstName = "Rajesh", LastName = "Joshi", Department = "ETC", Email = "rajesh@gmail.com", Location = "Delhi", ConatctNumber = "4651654897" });
            employees.Add(new Employee { Id = 106, FirstName = "Amit", LastName = "Kulkarni", Department = "IT", Email = "amit@gmail.com", Location = "Kolkata", ConatctNumber = "546654654" });
           
            string path = @"D:\CDAC\.NET Technology\Day_7\OnlineSolution\CRMWebApp\Content\employees.dat";
            bool status = HRManager.SavaData(path, employees);
           */
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
