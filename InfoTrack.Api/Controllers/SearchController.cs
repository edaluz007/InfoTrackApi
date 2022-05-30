using InfoTrack.Application.Const;
using InfoTrack.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InfoTrack.Api.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase {
        private readonly ISearchService _service;

        public SearchController(ISearchService service) { 
            _service = service;
        }
        [HttpGet(RoutesConst.GET_ALL)]
        public async Task<IActionResult> GetSearchByValue([FromQuery] string value) {
            return Ok(_service.GetSearchAsync(value));
        }
    }
}
