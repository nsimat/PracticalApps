using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NorthwindContextLib;
using NorthwindEntitiesLib.Entities;
using System.Linq;

namespace NorthwindWeb.Pages
{
    public class NewFournisseurModel : PageModel
    {
        private Northwind dbCtxt;

        [BindProperty]
        public Supplier Supplier { get; set; }

        public NewFournisseurModel(Northwind injectedContext)
        {
            dbCtxt = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Nouveau fournisseur";
            Supplier = new Supplier();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                dbCtxt.Suppliers.Add(Supplier);
                dbCtxt.SaveChanges();
                return RedirectToPage("/fournisseurs");
            }
            return Page();
        }
    }
}