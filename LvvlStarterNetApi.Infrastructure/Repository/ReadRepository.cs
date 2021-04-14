using LvvlStarterNetApi.Infrastructure.Context;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Infrastructure.Repository
{
    public class ReadRepository<T> : IReadService<T> where T : class
    {
        private readonly CliDbExampleContext _context;
        public ReadRepository(CliDbExampleContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll(bool trackChanges = true) =>
            !trackChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();

        public T GetById(int id)
        {
            //_context.Set<T>().Find(new object[] { id });

            var record = _context.Set<T>().Find(new object[] { id });

            if (record != null)
            {
                var entities = GetEntityNames();

                // Eager load all the tables referenced by the generic type T
                foreach (var entity in entities.collections)
                    _context.Entry(record).Collection(entity).Load();

                foreach (var entity in entities.references)
                    _context.Entry(record).Reference(entity).Load();
            }

            return record;
        }

        private (IEnumerable<string> collections, IEnumerable<string> references) GetEntityNames()
        {
            var dbsets = typeof(CliDbExampleContext)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(z => z.PropertyType.Name.Contains("DbSet"))
                .Select(z => z.Name);

            // Get the names of all the properties (tables) in the generic
            // type T that is represented by a DbSet
            var properties = typeof(T)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var collections = properties
                .Where(l => dbsets.Contains(l.Name))
                .Select(s => s.Name);

            var classes = properties
                .Where(c => dbsets.Contains(c.Name + "s"))
                .Select(s => s.Name);

            return (collections: collections, references: classes);
        }


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
           !trackChanges ?
           _context.Set<T>().Where(expression).AsNoTracking() :
           _context.Set<T>().Where(expression);
    }
}
