using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RailTimesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RailApiController : ControllerBase
    {
        private readonly IHttpClientFactory _railClient;
        private readonly ILogger<RailApiController> _logger;

        public RailApiController(IHttpClientFactory clientFactory, ILogger<RailApiController> logger)
        {
            _railClient = clientFactory;
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            HttpClient railClient = _railClient.CreateClient();
            railClient.BaseAddress = 
            return "hey";
        }
    }
}
