using PrimeiraWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PrimeiraWebAPI.Controllers
{
        [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ValuesController : ApiController
    {
        // GET api/values

        Model1 locacaoDB = new Model1();

        public List<Carro> Get()
        {
            return locacaoDB.Carros.ToList<Carro>();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return new string[] { "Café Capsula", "Café? Quero!" }[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
