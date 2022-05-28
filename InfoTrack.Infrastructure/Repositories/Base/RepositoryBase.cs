using InfoTrack.Domain.Repositories.Base;
using InfoTrack.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrack.Infrastructure.Repositories.Base {
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class {
		private readonly ITDbContext _context;

		public async Task<T> CreateAsync(T entity) {
			var lalo = _context.Set<T>().Add(entity);
			_context.Entry(lalo).State = EntityState.Added;
			var isSave = await _context.SaveChangesAsync();
			return null;
		}

		public Task DeleteAsync(T entity) {
			throw new NotImplementedException();
		}

		public Task<ICollection<T>> GetAllAsync() {
			throw new NotImplementedException();
		}

		public Task<T> GetById(int id) {
			throw new NotImplementedException();
		}

		public Task<T> UpdateAsync(T entity) {
			throw new NotImplementedException();
		}
	}
}
