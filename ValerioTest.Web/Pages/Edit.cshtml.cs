using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValerioTest.Data;
using ValerioTest.Models;

namespace ValerioTest.Web
{


    [Authorize]
    public class EditModel : PageModel
    {

        private readonly ImodelliRep _modelliRepository;

        [BindProperty]
        public Modelli Modell { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public EditModel(ImodelliRep modelliRepository)
        {
            _modelliRepository = modelliRepository;
        }

        public IActionResult OnGet(int id)
        {
            Modell = _modelliRepository.GetById(id);
            if (Modell == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost(int id)
        {
          

            if (ModelState.IsValid)
            {
                var modelli = _modelliRepository.GetById(id);
                modelli.Aula = Modell.Aula;
                return RedirectToPage("/Index");
            }

            return Page();
        }
/*
        public IActionResult OnPostDeleteProduct(int id)
        {
            try
            {
                _modelliRepository.Delete(id);
               //  return RedirectToPage("/Products/Index"); 
            }
            catch (Exception)
            {
                ErrorMessage = "Non è possibile cancellare il prodotto in quanto già utilizzato.";
                //return RedirectToPage("/Products/Edit", new { id });
            }  

        }*/

    }
}
