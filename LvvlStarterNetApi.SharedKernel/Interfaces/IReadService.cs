using System;
using System.Linq;
using System.Linq.Expressions;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface IReadService<T>
    {
        IQueryable<T> GetAll(bool trackChanges);

        T GetById(int id);

        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    }
}