using InfoTrack.Domain.Repositories.Base;
using InfoTrack.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrack.Infrastructure.Repositories.Base {
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class {
		private readonly ITDbContext _context;
	}
}
