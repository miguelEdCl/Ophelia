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
    public class CatInventarioController : ApiController
    {
        private DigitalWareEntities dbContext = new DigitalWareEntities();
        [HttpGet]
        public IQueryable<CatInventarioP> GetCatInventario()
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            using (DigitalWareEntities digitalWareEntities = new DigitalWareEntities())
            {
                return dbContext.CatInventarioP;
            }
        }
        [HttpGet]
        public CatInventarioP GetCatInventario(int id)
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            using (DigitalWareEntities digitalWareEntities = new DigitalWareEntities())
            {
                return digitalWareEntities.CatInventarioP.FirstOrDefault(d => d.IdInventario == id);
            }
        }
        [HttpPost]
        public IHttpActionResult AddInventario([FromBody] CatInventarioP cli)
        {
            if (ModelState.IsValid)
            {
                dbContext.CatInventarioP.Add(cli);
                dbContext.SaveChanges();
                return Ok(cli);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IHttpActionResult ActualizarCatInventario(int id, [FromBody] CatInventarioP cli)
        {
            if (ModelState.IsValid)
            {
                var InventarioExiste = dbContext.CatInventarioP.Count(c => c.IdInventario == id) > 0;
                if (InventarioExiste)
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
        public IHttpActionResult BorrarCatInventario(int id)
        {
            var cli = dbContext.CatInventarioP.Find(id);
            if (cli != null)
            {
                dbContext.CatInventarioP.Remove(cli);
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
