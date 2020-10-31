using ConectarDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MWebApi.Controllers
{
    public class CatProductoController : ApiController
    {
        private DigitalWareEntities dbContext = new DigitalWareEntities();
        [HttpGet]
        public IQueryable<CatProducto> GetProducto()
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            using (DigitalWareEntities digitalWareEntities = new DigitalWareEntities())
            {
                return dbContext.CatProducto;
            }
        }
        [HttpGet]
        public CatProducto GetProducto(int id)
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            using (DigitalWareEntities digitalWareEntities = new DigitalWareEntities())
            {
                return digitalWareEntities.CatProducto.FirstOrDefault(d => d.IdProducto == id);
            }
        }
        [HttpPost]
        public IHttpActionResult AddProducto([FromBody] CatProducto cli)
        {
            if (ModelState.IsValid)
            {
                dbContext.CatProducto.Add(cli);
                dbContext.SaveChanges();
                return Ok(cli);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IHttpActionResult ActualizarProducto(int id, [FromBody] CatProducto cli)
        {
            if (ModelState.IsValid)
            {
                var ClienteExiste = dbContext.CatProducto.Count(c => c.IdProducto == id) > 0;
                if (ClienteExiste)
                {
                    dbContext.Entry(cli).State = EntityState.Modified;
                    dbContext.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IHttpActionResult BorrarProducto(int id)
        {
            var cli = dbContext.CatProducto.Find(id);
            if (cli != null)
            {
                dbContext.CatProducto.Remove(cli);
                dbContext.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
