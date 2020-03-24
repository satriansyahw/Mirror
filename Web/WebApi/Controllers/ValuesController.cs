using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenHelper.Compress;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.General;

namespace WebApi.Controllers
{
    
   
    public class ValuesController : BasicController
    {
        private readonly CompressObject compress = CompressObject.GetInstance;
        private byte[] jsonResult = null;

        // GET api/values
        [HttpGet]
        [AllowAnonymous]
        [Route("GetValue")]
        public IActionResult  GetValue()
        {

            string hasil = "Hi Hello World";
            jsonResult = compress.CompressedData(hasil);
            return Ok(jsonResult);
        }

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
