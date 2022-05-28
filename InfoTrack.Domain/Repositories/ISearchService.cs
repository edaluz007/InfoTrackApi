using InfoTrack.Domain.Entities;
using InfoTrack.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrack.Domain.Repositories {
	public interface ISearchService : IRepositoryBase<Search> {
		Task<Search> GetSearchAsync();
	}
}
