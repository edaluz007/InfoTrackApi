using InfoTrack.Domain.Entities;
using InfoTrack.Domain.Repositories;
using InfoTrack.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrack.Infrastructure.Repositories {
	public class SearchService : RepositoryBase<Search>, ISearchService {
		public async Task<Search> GetSearchAsync() {
			try {
				return GetAllAsync();
			} catch (Exception) { 
			
			}
		}
	}
}
