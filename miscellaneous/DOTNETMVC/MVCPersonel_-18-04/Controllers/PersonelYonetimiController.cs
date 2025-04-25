using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCPersonel__18_04.Data;

namespace MVCPersonel__18_04.Controllers
{
    //[Route("[controller]")]
    public class PersonelYonetimiController : Controller
    {
        private readonly ILogger<PersonelYonetimiController> _logger;
        private readonly SanalVeriTapani _context;

        public PersonelYonetimiController(ILogger<PersonelYonetimiController> logger,SanalVeriTapani context) //constructor bölümü
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(model:_context.Personeller);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}