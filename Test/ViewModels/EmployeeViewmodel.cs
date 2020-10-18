using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.ViewModels
{
    public class EmployeeViewmodel
    {
        public int Id { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public bool? State { get; set; }
    }

    public class CreateViewModel
    { 
        public string LName { get; set; }
        public string FName { get; set; }
    }
}