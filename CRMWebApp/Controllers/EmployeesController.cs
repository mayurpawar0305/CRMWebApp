using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CRMWebApp.Models;
namespace CRMWebApp.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            List<Employee> employees = HRManager.GetAll();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            Employee employee = HRManager.GetByID(id);
            return View(employee);
        }
        public ActionResult Delete (int id)
        {
            bool status = HRManager.Delete(id);
            if(status)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(int id, string firstname, string lastname, string email, string department, string location, string contactno)
        {
            Employee emp = new Employee
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Department = department,
                Location = location,
                ConatctNumber = contactno
            };
            HRManager.Insert(emp);
            return RedirectToAction("index");
        }

        public ActionResult Update(int id)
        {
            Employee employee = HRManager.GetByID(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Update(int id, string firstname, string lastname,
                                    string email, string department,
                                    string location, string contactnumber)
        {
            Employee emp = new Employee
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Department = department,
                Location = location,
                ConatctNumber = contactnumber
            };
            HRManager.Update(emp);
            return RedirectToAction("index");
        }
    }
}