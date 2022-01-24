using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.Helper;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {

        APIHelper _apiHelper = new APIHelper();



        public async Task<IActionResult> Index()
        {
            List<Person> people = new List<Person>();
            HttpClient client = _apiHelper.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Person/GetAllPersons");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                people = JsonConvert.DeserializeObject<List<Person>>(result);
            }

            return View(people);
        }


        public async Task<IActionResult> Details(int ID)
        {

            var person = new Person();
            HttpClient client = _apiHelper.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/Person/GetPerson?id={ID}");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                person = JsonConvert.DeserializeObject<Person>(result);
            }

            return View(person);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Person person)
        {

            HttpClient client = _apiHelper.Initial();
            var post =  client.PostAsJsonAsync<Person>("api/Person/InsertPerson", person);
            post.Wait();

            var result = post.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Delete(int ID)
        {

            var person = new Person();
            HttpClient client = _apiHelper.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/Person/DeletePerson?id={ID}");

            
            return RedirectToAction("Index"); 
        }




    }
}
