using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models.DataModels;
using Test.ViewModels;
using Test.Service;

namespace Test.Service
{
    public class EmployeeCRUD_Service
    {
        private static Northwind db = new Northwind();

        public List<EmployeeViewmodel> GetAllEmployees()
        {
            return db.Employees.Select(x => new EmployeeViewmodel() { Id = x.EmployeeID, FName = x.FirstName, LName = x.LastName }).ToList();
        }
        public EmployeeViewmodel GetEmployee(int id)
        {
            var employee = db.Employees.Where(x => x.EmployeeID == id).Select(x => new EmployeeViewmodel()
            {
                Id = x.EmployeeID,
                FName = x.FirstName,
                LName = x.LastName
            }).FirstOrDefault();
            return employee;
        }


    }
}