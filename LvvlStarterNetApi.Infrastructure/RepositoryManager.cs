using LvvlStarterNetApi.Infrastructure.Context;
using LvvlStarterNetApi.Infrastructure.Repository;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Infrastructure
{
    public class RepositoryManager<T> : IRepositoryManager<T> where T : class
    {
        private readonly CliDbExampleContext _context;
        public IReadService<T> _readService;
        public IWriteService<T> _writeService;

        public RepositoryManager(CliDbExampleContext context)
        {
            _context = context;
        }

        public IReadService<T> ReadService
        {
            get
            {
                if (_readService == null)
                    _readService = new ReadRepository<T>(_context);
                return _readService;
            }
        }

        public IWriteService<T> WriteService
        {
            get
            {
                if (_writeService == null)
                    _writeService = new WriteRepository<T>(_context);
                return _writeService;
            }
        }

        public bool Save()
        {
            var affected = _context.SaveChanges();
            if (affected > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> SaveAsync()
        {
            var affected = await _context.SaveChangesAsync();
            if (affected > 0)
            {
                return true;
            }
            return false;
        }
    }
}