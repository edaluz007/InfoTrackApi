using InfoTrack.Application.Wrappers;
using InfoTrack.Domain.Repositories.Base;
using InfoTrack.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.Infrastructure.Repositories.Base {
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class {
        private readonly ITDbContext _context;
        public RepositoryBase(ITDbContext dbContext) {
            _context = dbContext;
        }
        public async Task<Response<T>> CreateAsync(T entity) {
            var obj = _context.Set<T>().Add(entity);
            _context.Entry(obj).State = EntityState.Added;
            var isSave = await _context.SaveChangesAsync();
            var asasf = new Response<T>(entity);
            return asasf;
        }

        public Task DeleteAsync(T entity) {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll() {
            return _context.Set<T>().AsNoTracking();

        }

        public IQueryable<T> GetAll(int page, int pageSize) {
            throw new NotImplementedException();
        }

        public async Task<Response<ICollection<T>>> GetAllAsync() {
            var obj = await _context.Set<T>().AsNoTracking().ToListAsync();
            return new Response<ICollection<T>>(obj);
        }

        public Task<Response<T>> GetById(int id) {
            throw new NotImplementedException();
        }

        public Task<Response<T>> UpdateAsync(T entity) {
            throw new NotImplementedException();
        }
    }
}
