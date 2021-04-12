using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface IRepositoryManager<T> 
    {
        IReadService<T> ReadService { get; }
        IWriteService<T> WriteService { get; }
        void Save();
        Task SaveAsync();
    }
}
