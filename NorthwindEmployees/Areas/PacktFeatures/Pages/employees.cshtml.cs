using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindEntities.Entities;

namespace NorthwindEmployees.PacktFeatures.Pages
{
    public class EmployeesPageModel : PageModel
    {
        private Northwind dbCtxt;

        public EmployeesPageModel(Northwind injectedContext)
        {
            dbCtxt = injectedContext;
        }

        public IEnumerable<Employee> Employees { get; set; }
        public void OnGet()
        {
          Employees = dbCtxt.Employees.ToArray();
        }
    }
}
