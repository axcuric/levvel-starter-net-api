using LvvlStarterNetApi.Infrastructure.Context;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Infrastructure.Repository
{
    public class WriteRepository<T> : IWriteService<T> where T : class
    {
        private readonly CliDbExampleContext _context;

        public WriteRepository(CliDbExampleContext context)
        {
            _context = context;
        }

        public void Create(T entity) => _context.Set<T>().Add(entity);

        public async Task CreateAsync(T entity) => await _context.Set<T>().AddAsync(entity);

        public void Update(T entity) => _context.Set<T>().Update(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);
    }
}