using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ConectarDatos;
namespace MWebApi.Controllers
{
    public class CatClienteController : ApiController
    {
        private DigitalWareEntities dbContext = new DigitalWareEntities();
        [HttpGet]
        public IQueryable<CatCliente> GetClientes()
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            using (DigitalWareEntities digitalWareEntities = new DigitalWareEntities())
            {
                return dbContext.CatCliente;
            }
        }
        [HttpGet]
        public CatCliente GetClientes(int id)
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            using (DigitalWareEntities digitalWareEntities = new DigitalWareEntities())
            {
                return digitalWareEntities.CatCliente.FirstOrDefault(d => d.IdCliente == id);
            }
        }
        [HttpPost]
        public IHttpActionResult AddCliente([FromBody]CatCliente cli)
        {
            if (ModelState.IsValid)
            {
                dbContext.CatCliente.Add(cli);
                dbContext.SaveChanges();
                return Ok(cli);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IHttpActionResult ActualizarCliente(int id, [FromBody] CatCliente cli)
        {
            if (ModelState.IsValid)
            {
                var ClienteExiste = dbContext.CatCliente.Count(c => c.IdCliente == id) > 0;
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
        public IHttpActionResult BorrarCliente(int id)
        {
            var cli = dbContext.CatCliente.Find(id);
            if(cli != null)
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
