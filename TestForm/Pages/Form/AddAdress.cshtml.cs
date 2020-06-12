using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestForm.Models;

namespace TestForm.Pages.Form
{
    public class AddAdressModel : PageModel
    {
        [BindProperty]
        public AdressModel Adress { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        { 
        
        if (ModelState.IsValid == false)
            {

                return Page(); 
            }

        // Save Model to Database 

            return RedirectToPage("/Index", new { Adress.Vorname });
        
        }
    }
}