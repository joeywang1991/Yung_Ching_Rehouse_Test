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

        [AcceptVerbs("POST")]
        public string Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                return _sevice.Create(model);
            }
            return "格式錯誤";
            
        }

        [AcceptVerbs("POST")]
        public string Edit(EmployeeViewmodel model) 
        {
            if (ModelState.IsValid)
            {
                return _sevice.Edit(model);
            }
            return "格式錯誤";
        }

        [AcceptVerbs("POST")]
        public string Delete(string id)
        {
            return _sevice.Delete(id);
        }
    }
}
