using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        private readonly IPersonRepo _repo;

        public HomeController(IPersonRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetPersons()
        {
            var Persons = _repo.GetAll();


            return View(Persons);

        }


    }
}
