using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface IExampleService<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Get();
        T GetById(int id);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    }
}
