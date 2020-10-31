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
    public class FacturaController : ApiController
    {
        private DigitalWareEntities dbContext = new DigitalWareEntities();
        [HttpGet]
        public IQueryable<CatFactura> GetFacturas()
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            using (DigitalWareEntities digitalWareEntities = new DigitalWareEntities())
            {
                return dbContext.CatFactura;
            }
        }
        [HttpGet]
        public CatFactura GetFacturas(int id)
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            using (DigitalWareEntities digitalWareEntities = new DigitalWareEntities())
            {
                return digitalWareEntities.CatFactura.FirstOrDefault(d => d.IdProducto == id);
            }
        }
        [HttpPost]
        public IHttpActionResult AddFactura([FromBody] CatFactura cli)
        {
            if (ModelState.IsValid)
            {
                dbContext.CatFactura.Add(cli);
                dbContext.SaveChanges();
                return Ok(cli);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IHttpActionResult ActualizarFactura(int id, [FromBody] CatFactura cli)
        {
            if (ModelState.IsValid)
            {
                var ClienteExiste = dbContext.CatFactura.Count(c => c.IdFactura == id) > 0;
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
        public IHttpActionResult BorrarFactura(int id)
        {
            var cli = dbContext.CatCliente.Find(id);
            if (cli != null)
            {
                dbContext.CatCliente.Remove(cli);
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
