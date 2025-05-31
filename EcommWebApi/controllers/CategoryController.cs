using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcommWebApi.controllers
{
    public class CategoryController : ApiController
    {
        // GET: api/Category
        public IEnumerable<Category> Get()
        {
            return Category.GetAll();
        }

        // GET: api/v1/Category/5
        public Category Get(int id)
        {
            return Category.GetById(id);
        }

        // POST: api/Category
        public Category Post([FromBody] Category value)
        {
            value.Cid = -1;
            Category category = new Category
            {
                Cid = value.Cid, 
                Cname = value.Cname,
                ParentCid = value.ParentCid,
                CatDesc = value.CatDesc,
                Status = value.Status
            };

            category.Save(); 
            return category; 
        }

        // PUT: api/Category/5
        public Category Put(int id, [FromBody]Category value)
        {
            if (value != null)
            {
                Category category = new Category
                {
                    Cid = id,
                    Cname = value.Cname,
                    ParentCid = value.ParentCid,
                    CatDesc = value.CatDesc,
                    Status = value.Status
                };
                category.Save();
                return category;
            }
            return null;
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
