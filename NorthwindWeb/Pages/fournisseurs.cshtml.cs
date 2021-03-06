using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using NorthwindEntitiesLib.Entities;
using NorthwindContextLib;

namespace NorthwindWeb.Pages
{
    public class FournisseursModel : PageModel
    {
        private Northwind dbCtxt;
        [BindProperty]
        public Supplier Supplier { get; set; }

        public FournisseursModel(Northwind injectedContext)
        {
            dbCtxt = injectedContext;
        }
        public IEnumerable<Supplier> Fournisseurs { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Fournisseurs";

            Fournisseurs = dbCtxt.Suppliers.Where(s => s.Fax != null);
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                dbCtxt.Suppliers.Add(Supplier);
                dbCtxt.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            return Page();
        }
    }
}