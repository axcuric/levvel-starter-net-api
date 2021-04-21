using System.Linq;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface ICommonServices<T>
    {
        int Count(IQueryable<T> ListOfEntity);
    }
}
