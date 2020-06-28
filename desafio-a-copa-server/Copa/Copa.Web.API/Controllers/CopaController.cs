using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Copa.Application.Contracts;
using Copa.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Copa.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CopaController : ControllerBase
    {
        private readonly ICopaApplication _copaApplication;

        public CopaController(ICopaApplication copaApplication) =>
            _copaApplication = copaApplication;

        [HttpPost]
        [Route("processar-copa")]
        public IActionResult Post([FromBody] IEnumerable<EquipeViewModel> equipes,
                                  [FromServices] IMemoryCache cache)
        {
            var resultado = _copaApplication.ProcesseCopa(equipes.ToList());
            var guid = Guid.NewGuid();           
            var cacheEntryOptions = new MemoryCacheEntryOptions()               
                .SetSlidingExpiration(TimeSpan.FromSeconds(10));

            cache.Set(guid, resultado, cacheEntryOptions); ;
            return Ok(guid);
        } 
        
        [HttpGet]
        [Route("resultado-copa/{resultado:guid}")]
        public IActionResult Get(Guid resultado,
                                 [FromServices] IMemoryCache cache)
        {
            List<EquipeViewModel> equipes = null;
            cache.TryGetValue(resultado, out equipes);
            if (equipes == null)
                return BadRequest(resultado);

            return Ok(equipes);
        }
    }
}
