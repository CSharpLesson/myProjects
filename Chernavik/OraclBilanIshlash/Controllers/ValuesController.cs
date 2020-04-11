using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OraclBilanIshlash.Interfaces;
using OraclBilanIshlash.Model;

namespace OraclBilanIshlash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ICollection<Contact> Contacts { get; set; }
        private IAuthService _authService;

        public ValuesController(IAuthService authService)
        {
            _authService = authService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<AuthRoles>> Get()
        {

            this.Contacts = new List<Contact>
            {
            new Contact { Id = 7113, Name = "James Norris", BirthDate = new DateTime(1977, 5, 13), Phone = "488-555-1212", },
            new Contact { Id = 7114, Name = "Mary Lamb", BirthDate =  new DateTime(1974, 10, 21), Phone = "337-555-1212",  },
            new Contact { Id = 7115, Name = "Robert Shoemaker", BirthDate = new DateTime(1968, 2, 8), Phone ="643-555-1212", }

            };
            var studentDetails = from Contactes in Contacts where Contactes.Id == 1 select Contactes;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(studentDetails);
            if (!studentDetails.Any()) 
            {
                return NotFound();
            }
            return Ok("zo'r");

        }
        //private static List<AuthRoles> standart = new List<AuthRoles>
        //{
        //    new AuthRoles
        //    {
        //        Comment = "assa",
        //        CreatedBy = 0
        //    }
        //};

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class Contact
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }


        public Contact()
        {
            this.Id = 7113; this.Name = "James Norris"; this.BirthDate = new DateTime(1977, 5, 13); this.Phone = "488-555-1212";

        }
    }
}
