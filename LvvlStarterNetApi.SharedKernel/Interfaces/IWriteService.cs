using System.Threading.Tasks;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface IWriteService<T>
    {
        void Create(T entity);

        Task CreateAsync(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}