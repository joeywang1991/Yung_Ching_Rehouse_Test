using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models.DataModels;
using Test.ViewModels;
using Test.Service;
using System.Data.Entity;

namespace Test.Service
{
    public class EmployeeCRUD_Service
    {
        private Northwind db = new Northwind();

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

        public string Create(CreateViewModel model) 
        {           
            var create = new Employees()
            //create.FirstName = model.FName;
            //create.LastName = model.LName;
            //create.State = true;
            {
                FirstName = model.FName,
                LastName = model.LName,
                State = true
            };

            db.Employees.Add(create);
            
            try
            {
                db.SaveChanges();
                return "新增成功";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string Edit(EmployeeViewmodel model)
        {
            var employee = db.Employees.Find(model.Id);
            employee.FirstName = model.FName;
            employee.LastName = model.LName;
            db.Entry(employee).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
                return "修改完成";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string Delete(int id)
        {
            var employee = db.Employees.Find(id);

            if (employee.State != true)
            {
                employee.State = true;
            }
            else
            {
                employee.State = false;
            }

            try
            {
                db.SaveChanges();
                return "修改完成";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}