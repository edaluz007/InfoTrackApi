using InfoTrack.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrack.Domain.Repositories.Base {
	public interface IRepositoryBase<T> where T : class {
		Task<Response<T>> CreateAsync(T entity);
		Task<Response<T>> UpdateAsync(T entity);
		Task DeleteAsync(T entity);
		Task<Response<ICollection<T>>> GetAllAsync();
		Task<Response<T>> GetById(int id);
	}
}
