using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using NorthwindContextLib;

namespace NorthwindWeb.Pages
{
    public class FournisseursModel : PageModel
    {
        
        public IEnumerable<string> Fournisseurs { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Fournisseurs";

            Fournisseurs = new[]{
                "Alpha Co", "Beta Limited", "Gamma Group"
            };
        }
    }
}