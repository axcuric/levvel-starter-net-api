using LvvlStarterNetApi.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly ILoggerService _logger;
        private readonly IExampleService _exampleService;
        public ExampleController(ILoggerService logger, IExampleService exampleService)
        {
            _logger = logger;
            _exampleService = exampleService;
        }

        [HttpPost]
        public ActionResult Post()
        {
            _logger.LogInfo();
            _exampleService.Add();
            return Ok();
        }

        [HttpGet]
        public ActionResult Get()
        {
            _logger.LogInfo();
            _exampleService.Get();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put()
        {
            _logger.LogInfo();
            _exampleService.Update();
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            _logger.LogInfo();
            _exampleService.Delete();
            return Ok();
        }
    }
}
