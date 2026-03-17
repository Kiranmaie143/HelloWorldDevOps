
using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace HelloWorld.IntegrationTests;

public class HelloEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public HelloEndpointTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetHello_ReturnsOk()
    {
        var response = await _client.GetAsync("/api/hello");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
