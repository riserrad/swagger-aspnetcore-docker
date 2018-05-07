using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using swagger_training.Model;

namespace swagger_training.Controllers
{
    /// <summary>
    /// The heroes controllers with some tricky methods for super hero names jokes.
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        /// <summary>
        /// Get someone's Super Hero name
        /// </summary>
        /// <param name="firstName">Someone's first name</param>
        /// <param name="lastName">Someone's last name</param>
        /// <returns>The person with a Super Hero name!</returns>
        [HttpGet("{firstName}/{lastName}")]
        public Person Get(string firstName, string lastName){
            var person = new Person() { FirstName = firstName, LastName = lastName};

            person.SetHeroName();

            return person;
        }
    }
}