using DLL.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DLL.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> QueryAll(Expression<Func<T, bool>> expression = null);
        Task< List<T>> GetList(Expression<Func<T, bool>> expression = null);
        Task CreateAsnc(T entry);
        void Update(T entry);
        void Delete(T entry);
        Task<T> FindSingleAsyc(Expression<Func<T, bool>> expression);
        Task<bool> SaveCompleteAsync();
    }

    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplictionDbContext _context;

        public RepositoryBase(ApplictionDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsnc(T entry)
        {
            await _context.Set<T>().AddAsync(entry);   
        }

        public void Delete(T entry)
        {
            _context.Set<T>().Remove(entry);
        }

        public async Task<T> FindSingleAsyc(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task< List<T>>GetList(Expression<Func<T, bool>> expression = null)
        {
            return expression != null ? await _context.Set<T>().AsQueryable().Where(expression).AsNoTracking().ToListAsync()
                : await _context.Set<T>().AsQueryable().AsNoTracking().ToListAsync();
        }

        public IQueryable<T> QueryAll(Expression<Func<T, bool>> expression = null)
        {
            return expression != null ? _context.Set<T>().AsQueryable().Where(expression).AsNoTracking() 
                : _context.Set<T>().AsQueryable();
        }

        public async Task<bool> SaveCompleteAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(T entry)
        {
             _context.Set<T>().Update(entry);
        }
    }
}
