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
        private IAuthService _authService;

        public ValuesController(IAuthService authService)
        {
            _authService = authService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<AuthRoles>> Get()
        {
            var a = 0;
            return _authService.GetAll(); ;
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
}
