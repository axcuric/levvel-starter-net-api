using LvvlStarterNetApi.Core.Models;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Api.Controllers
{
    [Route("api/ExampleItems")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILoggerService _logger;
        private readonly IUserService<User> _userService;
        public UserController(ILoggerService logger, IUserService<User> userService)
        {
            _logger = logger;
            _userService = userService;
        }

        /// <summary>
        /// Deletes an ExampleItem to the Db by a given Id.
        /// </summary>
        /// <param name="user">Id from ExampleItem to delete.</param>  
        /// <response code="204">Returned if the example item was deleted</response>  
        /// <response code="400">Returned if the model couldn&#8217;t be deleted</response> 
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(User user)
        {
            _logger.LogInfo("Enters Delete");
            _userService.Delete(user);
            return NoContent();
            //return NotFound();
        }

        /// <summary>
        /// Retrieves all ExampleItems from the Db.
        /// </summary>
        /// <response code="200">Returned if the example item was created</response>  
        /// <response code="404">Returned if the example items weren&#8217;t found</response>  
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            _logger.LogInfo("Enters Get");
            return Ok(_userService.Get());
            //return NotFound();
        }

        /// <summary>
        /// Retrieves a single ExampleItem by Id from the Db.
        /// </summary>
        /// <param name="id">Id from ExampleItem to delete.</param>  
        /// <response code="200">Returned if the example items was found and retrieved</response>  
        /// <response code="404">Returned if the example item wasn&#8217;t found on the Db</response> 
        [HttpGet("{id}", Name = "ExampleItemById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetExampleItemById(int id)
        {
            _logger.LogInfo("Enters GetExampleItemById");
            if (true)
            {
                return Ok(_userService.GetById(id));
            }
            //return NotFound();
        }

        /// <summary>
        /// Updates an ExampleItem from the Db.
        /// </summary>
        /// <param name="user">ExampleItem with updated values.</param>  
        /// <response code="200">Returned if the example item was updated</response>  
        /// <response code="404">Returned if the model wasn&#8217;t found on the DB</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(User user)
        {
            _logger.LogInfo("Enters Put");
            if (user != null)
            {
                _userService.Update(user);
                return Ok();
            } 
            return NotFound();
        }

        /// <summary>
        /// Adds an ExampleItem to the Db.
        /// </summary>
        /// <param name="user">Model to create a new example item</param>
        /// <response code="200">Returned if the example item was created</response>  
        /// <response code="400">Returned if the model couldn&#8217;t be saved or model is empty</response>  
        /// <response code="500">Returned when an error ocurred on Add ExampleItem action</response>   
        [HttpPost]
        public IActionResult Post(User user)
        {
            _logger.LogInfo("Enters Post");
            if (user == null)
            {
                return BadRequest("User object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }
            //await
            _userService.Add(user);
            //CreatedAtAction
            return Ok();
        }
    }
}
