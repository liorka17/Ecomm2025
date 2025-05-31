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
        public Orders Post([FromBody] Orders value)
        {
            value.OrderId = -1; 
            Orders orders = new Orders
            {
                OrderId = value.OrderId, 
                Uid = value.Uid,
                TotalAmount = value.TotalAmount,
                TotalPrice = value.TotalPrice,
                Status = value.Status,
                OrderDate = value.OrderDate,
                OrderDesc = value.OrderDesc

            };
            orders.Save();
            return orders;
        }

        // PUT: api/Orders/5
        public Orders Put(int id, [FromBody] Orders value)
        {
            if (value != null)
            {
                Orders orders = new Orders
                {
                    OrderId = id,
                    Uid = value.Uid,
                    TotalAmount = value.TotalAmount,
                    TotalPrice = value.TotalPrice,
                    Status = value.Status,
                    OrderDate = value.OrderDate,
                    OrderDesc = value.OrderDesc
                };
                orders.Save();
                return orders;
            }
            return null;
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
