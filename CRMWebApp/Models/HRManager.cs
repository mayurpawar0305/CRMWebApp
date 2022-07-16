using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace CRMWebApp.Models
{
    public class HRManager
    {
        public static List<Employee> GetAll() 
        {
            string path = @"D:\CDAC\.NET Technology\Day_7\OnlineSolution\CRMWebApp\Content\employees.dat";
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            return employees;
        }
        public static bool Insert(Employee emp) 
        {
            bool status = false;
            try
            {
                string path = @"D:\CDAC\.NET Technology\Day_7\OnlineSolution\CRMWebApp\Content\employees.dat";
                List<Employee> employees = new List<Employee>();
                employees = LoadData(path);
                employees.Add(emp);
                SavaData(path, employees);
                status = true;
            }
            catch(Exception ex)
            {
                string exMessage = ex.Message;
            }            
            return status;
        }
        public static bool Update(Employee empToUpdate) 
        {
            bool status = false;
            string path = @"D:\CDAC\.NET Technology\Day_7\OnlineSolution\CRMWebApp\Content\employees.dat";
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            var employee = from e in employees
                           where e.Id == empToUpdate.Id
                           select e;
            Employee theEmp = employee as Employee;
            theEmp.FirstName = empToUpdate.FirstName;
            theEmp.LastName = empToUpdate.LastName;
            theEmp.Email = empToUpdate.Email;
            theEmp.ConatctNumber = empToUpdate.ConatctNumber;
            theEmp.Department = empToUpdate.Department;
            theEmp.Location = empToUpdate.Location;
            status = SavaData(path,employees);
            return status;
        }
        public static bool Delete(int id) 
        {
            bool status = false;
            string path = @"D:\CDAC\.NET Technology\Day_7\OnlineSolution\CRMWebApp\Content\employees.dat";
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            var employee = from e in employees
                           where e.Id == id
                           select e;
            status =employees.Remove(employee as Employee);
            status = true;
            return status;
        }
        public static Employee GetByID(int id) 
        {
            Employee emp = new Employee();
            string path = @"D:\CDAC\.NET Technology\Day_7\OnlineSolution\CRMWebApp\Content\employees.dat";
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            var employee = employees.Find(e => e.Id == id);
            return employee as Employee;
        }
        public static List<Employee> LoadData(string path) 
        {
            //Deserialization
            List<Employee> employees = new List<Employee>();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            employees = bf.Deserialize(fs) as List<Employee>;
            fs.Close();
            return employees;
        }
        public static bool SavaData(string path,List<Employee>employees) 
        {
            //serialization
            bool status = false;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, employees);
            fs.Close();
            status = true;
            return status;
        }
    }
}