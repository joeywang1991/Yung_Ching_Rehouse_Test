using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Models.DataModels;
using Newtonsoft.Json;
using Test.ViewModels;
using Test.Service;


namespace Test.WabApi
{
    [RoutePrefix("api/EmployeeCRUD/[Action]")]
    public class EmployeeCRUDController : ApiController
    {
        private EmployeeCRUD_Service _sevice = new EmployeeCRUD_Service();

        [AcceptVerbs("GET")]
        public List<EmployeeViewmodel> GetAll()
        {            
            return _sevice.GetAllEmployees();
        }

        [AcceptVerbs("GET")]
        public EmployeeViewmodel GetEmployee(int id)
        {            
            return _sevice.GetEmployee(id);
        }
        

        [AcceptVerbs("GET")]
        public 

    }
}
