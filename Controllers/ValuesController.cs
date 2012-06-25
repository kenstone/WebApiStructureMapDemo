using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiStructureMapDemo.Models;

namespace WebApiStructureMapDemo.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ISampleFish _sampleFish;

        public ValuesController(ISampleFish sampleFish)
        {
            _sampleFish = sampleFish;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post(string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}