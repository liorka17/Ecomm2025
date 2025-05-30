using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcommWebApi.controllers
{
    public class OrdersController : ApiController
    {
        // GET: api/Orders
        public IEnumerable<Orders> Get()
        {
            return Orders.GetAll();
        }

        // GET: api/v1/Orders/5
        public Orders Get(int id)
        {
            return Orders.GetById(id);
        }

        // POST: api/Orders
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
