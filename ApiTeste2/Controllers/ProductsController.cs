using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiTeste2.Models;

namespace ApiTeste2.Controllers
{
    public class ProductsController : ApiController
    {

        static List<Product> products = new List<Product>
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        public IHttpActionResult GetAllProducts()
        {
            return Ok(products);
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/Products
        public IHttpActionResult Post([FromBody] Product produto)
        {
            if (produto.Id == 0)
            {
                var ultimoIndice = products.OrderBy(x => x.Id).Last().Id;
                produto.Id = ultimoIndice + 1;
            }
            products.Add(produto);
            return Ok(products);
        }

        // PUT: api/Products/5
        public IHttpActionResult PutProduct(int id , Product product)
        {
            product.Id = id;
            if (!Update(product))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            
            return Ok("Produto atualizado com sucesso");
        }

        private Boolean Update(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            var index = products.FindIndex(p => p.Id == product.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(product);
            return true;
        }

        // DELETE: api/Products/5
        public IHttpActionResult Delete(int id)
        {
            var index = products.FindIndex(p => p.Id == id);
            if (index == -1)
            {
                return NotFound();
            }
            products.RemoveAt(index);
            return Ok("Produto Deletado");
        }
    }
}
