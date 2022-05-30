using InfoTrack.Api.Controllers;
using InfoTrack.Application.Wrappers;
using InfoTrack.Domain.Entities;
using InfoTrack.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InfoTrack.Test {
	public class SearchControllerFake {
		SearchController _controller;
		internal Mock<ISearchService> _service = new();

		public async Task GetAllSearchOk() {
			var searches = new List<Search>();
			var search = new Search() {
				Id = 1,
				Keywords = "Infotrack",
				Url = "https://www.google.com/search?q=infotrack",
				Ranking = "9, 13",
				SearchDate = DateTime.Now.AddDays(-2),

			};
			searches.Add(search);
			var response = new Response<ICollection<Search>>(searches);
			var mockClient = new Mock<ISearchService>();
			mockClient.Setup(x => x.GetSearchAsync(It.IsAny<string>())).ReturnsAsync(response);
			var service = new SearchController(mockClient.Object);
			var result = await service.GetSearchByValue(It.IsAny<string>()) as ObjectResult;
			var actualResult = result.Value;

			Assert.IsType<OkObjectResult>(result);
			Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)result.StatusCode);
			mockClient.Verify(x => x.GetSearchAsync(It.IsAny<string>()), Times.Once);
		}
	}
}
