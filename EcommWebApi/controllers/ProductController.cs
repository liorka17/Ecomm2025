using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcommWebApi.controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return Product.GetAll();
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return Product.GetById(id);
        }

        // POST: api/Product
        public Product Post([FromBody]Product value)
        {
            value.Pid = -1;
            Product product = new Product
                {
                    Pid = value.Pid, 
                    Pname = value.Pname,
                    Pdesc = value.Pdesc,
                    Price = value.Price,
                    Cid = value.Cid,
                    Picname = value.Picname,
                    Status = value.Status
                };
                product.Save();
            return product;
        }

        // PUT: api/Product/5
        public Product Put(int id, [FromBody] Product value)
        {
            if (value != null)
            {
                Product product = new Product
                {
                    Pid = id,
                    Pname = value.Pname,
                    Pdesc = value.Pdesc,
                    Price = value.Price,
                    Cid = value.Cid,
                    Picname = value.Picname,
                    Status = value.Status
                };
                product.Save();
                return product;
            }
            return null;
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {

        }
    }
}
