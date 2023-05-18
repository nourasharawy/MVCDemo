using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int DepartmentId) 
        {
            EmployeeContext employeeContext = new EmployeeContext();
           List <Employee> employees = employeeContext.Employees.Where(emp=> emp.DepartmentId == DepartmentId).ToList();
            return View(employees); 
        }

        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee emp = employeeContext.Employees.Single(e => e.EmployeeId == id); 
            return View(emp);
        }
    }
}