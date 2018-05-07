using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using swagger_training.Model;

namespace swagger_training.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        [HttpGet("{firstName}/{lastName}")]
        public Person Get(string firstName, string lastName){
            var person = new Person() { FirstName = firstName, LastName = lastName};

            person.SetHeroName();

            return person;
        }
    }
}