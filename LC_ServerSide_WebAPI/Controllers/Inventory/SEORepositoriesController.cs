using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LiquorsCart.ServerSide.Service.Inventory;
using LiquorsCart.ServerSide.ViewModel.Inventory;

namespace  LC_ServerSide_WebAPI.Controllers.Inventory
{   
    [Produces("application/json")]
    [Route("api/SEORepositories")]
    public class SEORepositoriesController : Controller
    {
        private SEORepositoryService seoRepositoryService;

        public SEORepositoriesController()
        {
            seoRepositoryService = new SEORepositoryService();
        }
        
        // GET: api/SEORepositories
        [HttpGet]
        public IActionResult Get()
        {
            List<SeoRepository> listSEORepository = new List<SeoRepository>();
            listSEORepository = seoRepositoryService.Get();
            return new ObjectResult(listSEORepository);
        }

        // GET: api/SEORepositories/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int seoId)
        {
            SeoRepository seoRepository = new SeoRepository();
            seoRepository = seoRepositoryService.Get(seoId);
            return new ObjectResult(seoRepository);
        }
        
        // POST: api/SEORepositories
        [HttpPost]
        public IActionResult Post([FromBody]SeoRepository value)
        {
            try
            {
                if (value == null)
                {
                    return BadRequest();
                }
                seoRepositoryService.Add(value);
                return new NoContentResult();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        // PUT: api/SEORepositories/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]SeoRepository value)
        {
            try
            {
                if (value == null || value.SeoId != id)
                {
                    return BadRequest();
                }
                seoRepositoryService.Update(value);
                return new NoContentResult();
            }
            catch(Exception ex)
            {
                throw ex;
            } 
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody]SeoRepository value)
        {
            try
            {
                if (value == null || value.SeoId != id)
                {
                    return BadRequest();
                }
                seoRepositoryService.Remove(value);
                return new NoContentResult();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
