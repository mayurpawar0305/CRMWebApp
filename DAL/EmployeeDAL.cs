using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class EmployeeDAL
    {
		public static string conenctionString = @"server=localhost;user=root;database=crmwebapp;password='Mayur#0305'";
		public static List<Employee> GetAll()
		{
			List<Employee> employees = new List<Employee>();
			IDbConnection conn = new MySqlConnection(conenctionString);
			try
			{
				conn.Open();
				string query = "SELECT * From employee";
				IDbCommand cmd = new MySqlCommand(query, conn as MySqlConnection);
				cmd.CommandType = CommandType.Text;   // 
				IDataReader reader = cmd.ExecuteReader();  //ResultSet
				while (reader.Read())
				{
					Employee emp = new Employee();
					emp.Id = int.Parse(reader["Id"].ToString());  //int.Parse, float.Parse, double.Parse
					emp.FirstName = reader["FirstName"].ToString();
					emp.LastName = reader["LastName"].ToString();
					emp.Department = reader["Department"].ToString();
					emp.ContactNumber = reader["ContactNumber"].ToString();
					emp.Email = reader["Email"].ToString();
					emp.Location = reader["Location"].ToString();

					employees.Add(emp);
				}
				reader.Close();
			}
			catch (MySqlException excpetion)
			{
				string error = excpetion.Message;
			}
			finally
			{
				conn.Close();
			}
			return employees;
		}
		public static Employee GetByID(int id)
		{
			Employee emp = new Employee();
			List<Employee> employees = new List<Employee>();
			IDbConnection conn = new MySqlConnection(conenctionString);
			try
			{
				conn.Open();
				string query = "SELECT * From employee where Id=" + id;
				IDbCommand cmd = new MySqlCommand(query, conn as MySqlConnection);
				cmd.CommandType = CommandType.Text;   // 
				IDataReader reader = cmd.ExecuteReader();  //ResultSet

				if (reader.Read())
				{
					emp.Id = int.Parse(reader["Id"].ToString());  //int.Parse, float.Parse, double.Parse
					emp.FirstName = reader["FirstName"].ToString();
					emp.LastName = reader["LastName"].ToString();
					emp.Department = reader["Department"].ToString();
					emp.ContactNumber = reader["ContactNumber"].ToString();
					emp.Email = reader["Email"].ToString();
					emp.Location = reader["Location"].ToString();
				}
				reader.Close();
			}
			catch (MySqlException excpetion)
			{
				string error = excpetion.Message;
			}
			finally
			{
				conn.Close();
			}
			return emp;
		}
		public static bool Delete(int id)
		{
			bool status = false;
			IDbConnection conn = new MySqlConnection(conenctionString);
			try
			{
				conn.Open();
				string query = "DELETE From employee where Id=" + id;
				IDbCommand cmd = new MySqlCommand(query, conn as MySqlConnection);
				cmd.CommandType = CommandType.Text;   // 
				int rowsAffected = cmd.ExecuteNonQuery(); // for DML Operations
				if (rowsAffected > 0)
				{
					status = true;
				}
			}
			catch (MySqlException excpetion)
			{
				string error = excpetion.Message;
			}
			finally
			{
				conn.Close();
			}
			return status;
		}
		public static bool Insert(Employee emp)
		{
			bool status = false;
			IDbConnection con = new MySqlConnection(conenctionString);
			try
			{
				con.Open();
				MySqlCommand cmd = new MySqlCommand();
				cmd.CommandType = CommandType.Text;
				string query = "INSERT INTO employee(Id, FirstName, LastName, Department, ContactNumber, Email, Location) " +
					"values ("+emp.Id+", '"+emp.FirstName+"', '"+emp.LastName+"', '"+emp.Department+"', '"+emp.ContactNumber+"', '"+emp.Email+"', '"+emp.Location+"')";

				int rowsAffected = cmd.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					status = true;
				}
			}
			catch (Exception ex)
			{
				string exeMessage = ex.Message;
			}
			finally
			{
				con.Close();
			}
			return status;
		}
		
		public static bool Update(Employee emp)
		{
			bool status = false;
			MySqlConnection con = new MySqlConnection(conenctionString);
			try
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = con;
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE employee  SET FirstName='" + emp.FirstName + "',LastName='"
									+ emp.LastName + "', Department='" + emp.Department +" ',ContactNumber='"+emp.ContactNumber+"',Email='"+emp.Email+"',Location='"+emp.Location+"' WHERE ID=" + emp.Id;
				con.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					status = true;
				}
			}
			catch (Exception ex)
			{
				string message = ex.Message;
			}
			finally
			{
				con.Close();
			}
			return status;
		}
		
	}
}
