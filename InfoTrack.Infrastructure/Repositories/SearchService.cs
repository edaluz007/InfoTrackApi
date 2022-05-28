using InfoTrack.Application.Wrappers;
using InfoTrack.Domain.Entities;
using InfoTrack.Domain.Repositories;
using InfoTrack.Infrastructure.Data;
using InfoTrack.Infrastructure.Repositories.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.Infrastructure.Repositories {
    public class SearchService : RepositoryBase<Search>, ISearchService {
        public SearchService(ITDbContext dbContext) : base(dbContext) {
        }

        public async Task<Response<ICollection<Search>>> GetSearchAsync() {
            return await GetAllAsync();
        }
        public async Task<Response<ICollection<Search>>> GetSearchAsync(string pSearch) {
            var obj = GetAll().Where(x => x.Keywords == pSearch).ToList();
            return new Response<ICollection<Search>>(obj);
        }
    }
}
