using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcommWebApi.controllers
{
    public class UsersController : ApiController
    {
        // GET: api/v1/Users
        public List<Users> Get()
        {
            return Users.GetAll();
        }

        // GET: api/Users/5
        public Users Get(int id)
        {
            return Users.GetById(id);
        }

        // POST: api/Users
        public void Post([FromBody]Users value)
        {
           


        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]Users value)
        {


        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
