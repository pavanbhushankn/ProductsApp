using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] { 
        new Product{Id=1,Name="Product1", Category="Electronics", Price=122},
        new Product{Id=2,Name="Product2", Category="Cloths ", Price=162},
        new Product{Id=3,Name="Product3", Category="Books", Price=122},
        
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProductByID(int id)
        {
            Product p = products.FirstOrDefault(a => a.Id == id);

            if (p==null)
            {
                return NotFound();
            }
            return Ok(p);
        }
    }
}
