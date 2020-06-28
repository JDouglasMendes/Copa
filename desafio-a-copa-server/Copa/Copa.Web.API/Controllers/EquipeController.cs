using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Copa.Application.ViewModels;
using Copa.Web.API.HttpCliente;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Copa.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class EquipeController : ControllerBase
    {
        [HttpGet]      
        public async Task<IActionResult> Get() =>
            Ok(await new CopaHttpClient<IEnumerable<EquipeViewModel>>().Get("dougramalho/testesq/master/equipes.json"));        
    }
}
