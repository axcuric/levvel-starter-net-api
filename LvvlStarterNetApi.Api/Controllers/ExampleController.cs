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
            _logger.LogInfo("Enters Post");
            _exampleService.Add();
            return Ok();
        }

        [HttpGet]
        public ActionResult Get()
        {
            _logger.LogInfo("Enters Get");
            _exampleService.Get();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put()
        {
            _logger.LogInfo("Enters Put");
            _exampleService.Update();
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            _logger.LogInfo("Enters Delete");
            _exampleService.Delete();
            return Ok();
        }
    }
}
