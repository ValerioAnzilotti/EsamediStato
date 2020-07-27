using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ValerioTest.Data;
using ValerioTest.Models;

namespace ValerioTest.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ImodelliRep _modelliRepository;

        public IEnumerable<Modelli> Modells { get; set; }

        public IndexModel(ImodelliRep modelliRepository)
        {
            _modelliRepository = modelliRepository;
        }

        public void OnGet()
        {
            Modells = _modelliRepository.GetAll();
        }
    }
}