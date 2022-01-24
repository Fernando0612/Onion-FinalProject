using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }



        [HttpGet(nameof(GetAllPersons))]
        public IActionResult GetAllPersons()
        {
            var result = _personService.GetAllPersons();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("No records found");

        }

        [HttpGet(nameof(GetPerson))]
        public IActionResult GetPerson(int id)
        {
            var result = _personService.GetPerson(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("No records found");

        }

        [HttpPost(nameof(InsertPerson))]
        public IActionResult InsertPerson(Person person)
        {
            _personService.InsertPerson(person);

            return Ok("Data inserted");

        }

        [HttpPut(nameof(UpdatePerson))]
        public IActionResult UpdatePerson(Person person)
        {
            _personService.UpdatePerson(person);

            return Ok("Data updated");

        }

        [HttpDelete(nameof(DeletePerson))]
        public IActionResult DeletePerson(int id)
        {
            _personService.DeletePerson(id);

            return Ok("Data deleted");

        }

    }
}
