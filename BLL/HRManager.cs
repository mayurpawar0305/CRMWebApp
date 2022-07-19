using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DAL;
using BOL;
namespace BLL
{
    //AllCommented Part is by serialiaztion i.e by file read and write
    //new database connection method has been implemented
    public class HRManager
    {
        public static string path = @"D:\CDAC\.NET Technology\Day_7\OnlineSolution\CRMWebApp\Content\employees.dat";
        public static List<Employee> GetAll() 
        {
            /*List<Employee> employees = new List<Employee>();
             employees = LoadData(path);
             return employees;
            */
            return EmployeeDAL.GetAll();
        }
        public static bool Insert(Employee emp) 
        {
            /* bool status = false;
             try
             {
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
             return status;*/
            return EmployeeDAL.Insert(emp);
        }
        public static bool Update(Employee empToUpdate) 
        {
            /*bool status = false;
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            var result = from r in employees
                           where r.Id == empToUpdate.Id
                           select r;
            
            result.First().FirstName = empToUpdate.FirstName;
            result.First().LastName = empToUpdate.LastName;
            result.First().Email = empToUpdate.Email;
            result.First().ContactNumber = empToUpdate.ContactNumber;
            result.First().Department = empToUpdate.Department;
            result.First().Location = empToUpdate.Location;
            
            status = SavaData(path,employees);
            return status;*/
            return EmployeeDAL.Update(empToUpdate);
        }
        public static bool Delete(int id) 
        {
            /* bool status = false;
             List<Employee> employees = new List<Employee>();
             employees = LoadData(path);
             int no = employees.RemoveAll(emp => emp.Id == id);
             if (no > 0)
             {
                 SavaData(path, employees);
                 status = true;
             }
             return status;*/
            return EmployeeDAL.Delete(id);
        }
        public static Employee GetByID(int id) 
        {
            /*
            Employee emp = new Employee();
            List<Employee> employees = new List<Employee>();
            employees = LoadData(path);
            var employee = employees.Find(e => e.Id == id);
            return employee as Employee;*/
            return EmployeeDAL.GetByID(id);
        }
        /*public static List<Employee> LoadData(string path) 
        {
            
            //Deserialization
            List<Employee> employees = new List<Employee>();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            employees = bf.Deserialize(fs) as List<Employee>;
            fs.Close();
            return employees;
        }*/
        /*public static bool SavaData(string path,List<Employee>employees) 
        {
            
            //serialization
            bool status = false;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, employees);
            fs.Close();
            status = true;
            return status;
        }*/
    }
}