using System.Threading.Tasks;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface IRepositoryManager<T>
    {
        IReadService<T> ReadService { get; }
        IWriteService<T> WriteService { get; }

        bool Save();

        Task<bool> SaveAsync();
    }
}