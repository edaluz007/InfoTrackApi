using InfoTrack.Application.Wrappers;
using InfoTrack.Domain.Entities;
using InfoTrack.Domain.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoTrack.Domain.Repositories {
    public interface ISearchService : IRepositoryBase<Search> {
        Task<Response<ICollection<Search>>> GetSearchAsync();
        Task<Response<ICollection<Search>>> GetSearchAsync(string pSearch);
    }
}
