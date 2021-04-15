using LvvlStarterNetApi.Core.Models;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Core.Services
{
    public class UserService : IUserService<User>
    {
        private readonly ILoggerService _logger;
        private readonly IRepositoryManager<User> _repositoryManager;
        public UserService(ILoggerService loggerService, IRepositoryManager<User> repositoryManager)
        {
            _logger = loggerService;
            _repositoryManager = repositoryManager;
        }
        public IQueryable<User> Get()
        {
            _logger.LogInfo("Get UserService");
            return _repositoryManager.ReadService.GetAll(true);
        }
        public User GetById(int id)
        {
            _logger.LogInfo("GetById UserService");
            return _repositoryManager.ReadService.GetById(id);
        }
        public IQueryable<User> GetByCondition(Expression<Func<User, bool>> expression, bool trackChanges)
        {
            _logger.LogInfo("GetByCondition UserService");
            return _repositoryManager.ReadService.FindByCondition(expression, trackChanges);
        }
        public bool Add(User user)
        {
            _logger.LogInfo("Add UserService");
            _repositoryManager.WriteService.Create(user);
            return _repositoryManager.Save();
        }
        public async Task<bool> AddAsync(User user)
        {
            _logger.LogInfo("AddAsync UserService");
            await _repositoryManager.WriteService.CreateAsync(user);
            return await _repositoryManager.SaveAsync();
        }
        public bool Update(User user)
        {
            _logger.LogInfo("Update UserService");
            _repositoryManager.WriteService.Update(user);
            return _repositoryManager.Save();
        }
        public bool Delete(User user)
        {
            _logger.LogInfo("Delete UserService");
            _repositoryManager.WriteService.Delete(user);
            return _repositoryManager.Save();
        }

    }
}
