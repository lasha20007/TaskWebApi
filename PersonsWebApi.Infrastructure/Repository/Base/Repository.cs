using PersonsWebApi.Domain.Paging;
using PersonsWebApi.Domain.Repository.Base;
using PersonsWebApi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Infrastructure.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly RepositoryContext _context;
        public Repository(RepositoryContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Set<T>().Remove(await _context.Set<T>().FindAsync(id));
            await _context.SaveChangesAsync();
        }

        public IList<T> GetAll(PagingParameters paging)
        {
            return _context.Set<T>().Skip((paging.PageNumber - 1) * paging.PageSize)
                .Take(paging.PageSize).ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
