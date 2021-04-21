using AutoMapper;
using LvvlStarterNetApi.Core.Dtos;
using LvvlStarterNetApi.Core.Models;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LvvlStarterNetApi.Api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILoggerService _logger;
        private readonly IRepositoryManager<User> _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ICommonServices<User> _userService;

        public UserController(ILoggerService logger, 
            IRepositoryManager<User> repositoryManager,
            ICommonServices<User> userService,
            IMapper mapper)
        {
            _logger = logger;
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userService = userService;
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
            var users = _repositoryManager.ReadService.GetAll(true);
            if (users == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<UserDto>>(users));
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
        public IActionResult GetById(int id)
        {
            _logger.LogInfo("Enters GetExampleItemById");
            var user = _repositoryManager.ReadService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = _mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        /// <summary>
        /// Count the Users 
        /// </summary>
        /// <returns>Integer</returns>
        [HttpGet("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetTotalUserCount()
        {
            IQueryable<User> users = _repositoryManager.ReadService.GetAll(true);
            if(users != default(User))
            {
                return Ok(_userService.Count(users));
            }
            return BadRequest("User object is null");
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

            _repositoryManager.WriteService.Update(user);

            if (_repositoryManager.Save())
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

            _repositoryManager.WriteService.Create(user);

            if (_repositoryManager.Save())
            {
                return Ok();
            }
            return BadRequest();
        }

        /// <summary>
        /// Deletes an User to the Db by a given Id.
        /// </summary>
        /// <param name="id">User ID to delete.</param>
        /// <response code="204">Returned if the User was deleted</response>
        /// <response code="404">Returned if User wasn&#8217;t found</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Delete(int id)
        {
            _logger.LogInfo("Enters Delete");

            var user = _repositoryManager.ReadService.GetById(id);
            if (user != null)
            {
                _repositoryManager.WriteService.Delete(user);

                if (_repositoryManager.Save())
                {
                    return NoContent();
                }                
            }
            return NotFound();
        }

        
    }
}