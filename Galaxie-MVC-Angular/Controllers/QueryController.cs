using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Galaxie_MVC_Angular.Models;
using Newtonsoft.Json;
using Galaxie_MVC_Angular.Dapper;

namespace Galaxie_MVC_Angular.Controllers
{
    public class QueryController : ApiController
    {
        // GET api/<controller>
        private IItemRepository _repository = new ItemRepository();

        public IEnumerable<tblItem> Get()
        {
            return _repository.GetAllItems("");   

        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}