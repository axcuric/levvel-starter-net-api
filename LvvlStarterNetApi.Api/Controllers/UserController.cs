using AutoMapper;
using LvvlStarterNetApi.Core.Dtos;
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
        private readonly IMapper _mapper;
        public UserController(ILoggerService logger, IUserService<User> userService, IMapper mapper)
        {
            _logger = logger;
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Deletes an User to the Db by a given Id.
        /// </summary>
        /// <param name="id">Id from User to delete.</param>  
        /// <response code="204">Returned if the User was deleted</response>  
        /// <response code="404">Returned if User wasn&#8217;t found</response> 
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        //TODO: change from User model to string id
        public IActionResult Delete(User user)
        {
            _logger.LogInfo("Enters Delete");
            if (_userService.Delete(user))
            {
                return NoContent();
            }
            return NotFound();
        }

        /// <summary>
        /// Retrieves all Users from the Db.
        /// </summary>
        /// <response code="200">Returned if the User was created</response>  
        /// <response code="404">Returned if the User items weren&#8217;t found</response>  
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult Get()
        {
            _logger.LogInfo("Enters Get");
            var users = _userService.Get();
            if (users == null)
            {
                return NotFound();
            }
            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(userDtos);
        }

        /// <summary>
        /// Retrieves a single User by Id from the Db.
        /// </summary>
        /// <param name="id">Id from User to delete.</param>  
        /// <response code="200">Returned if the Users was found and retrieved</response>  
        /// <response code="404">Returned if the User wasn&#8217;t found on the Db</response> 
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetExampleItemById(int id)
        {
            _logger.LogInfo("Enters GetExampleItemById");
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = _mapper.Map<IEnumerable<UserDto>>(user);
            return Ok(userDto);
        }

        /// <summary>
        /// Updates an User from the Db.
        /// </summary>
        /// <param name="user">User with updated values.</param>  
        /// <response code="200">Returned if the User was updated</response>  
        /// <response code="400">Returned if User object sent is wrong</response>
        /// <response code="404">Returned if the model wasn&#8217;t found on the DB</response>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Put(User user)
        {
            _logger.LogInfo("Enters Put");
            if (user == null)
            {
                return BadRequest("User object is null");
            }
            if (_userService.Update(user))
            {
                return Ok();
            }
            return NotFound();
        }

        /// <summary>
        /// Adds an User to the Db.
        /// </summary>
        /// <param name="user">Model to create a new User</param>
        /// <response code="201">Returned if the User was created</response>  
        /// <response code="400">Returned if the model couldn&#8217;t be saved or model is empty</response>  
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Post(User user)
        {
            _logger.LogInfo("Enters Post");
            if (user == null)
            {
                return BadRequest("User object is null");
            }
            
            if (_userService.Add(user))
            {
                //CreatedAtAction
                return Ok();
            }
            return BadRequest();
        }
    }
}
