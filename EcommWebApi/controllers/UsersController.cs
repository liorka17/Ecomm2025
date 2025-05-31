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
        public Users Post([FromBody]Users value)
        {         
            value.Uid = -1;
            Users user = new Users
            {
                Uid = value.Uid, 
                FullName = value.FullName,
                Pass = value.Pass,
                Email = value.Email,
                Phone = value.Phone,
                Adress = value.Adress,
                Status = value.Status
            };
            user.Save(); 
            return user;
        }

        // PUT: api/Users/5
        public Users Put(int id, [FromBody]Users value)
        {
            if (value != null)
            {
                Users user = new Users
                {
                    Uid = id,
                    FullName = value.FullName,
                    Pass = value.Pass,
                    Email = value.Email,
                    Phone = value.Phone,
                    Adress = value.Adress,
                    Status = value.Status
                };
                user.Save();
                return user;
            }
            return null;
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
