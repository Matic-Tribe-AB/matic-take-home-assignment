using Microsoft.AspNetCore.Mvc.Testing;

namespace PostFeed.Tests;

// -------------------------------------------------------
// Example integration test using WebApplicationFactory.
// The factory boots the API in-process — no port needed.
// Add your own test classes and facts below.
// -------------------------------------------------------

public class HealthTests(WebApplicationFactory<Program> factory)
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task HealthEndpoint_ReturnsOk()
    {
        var response = await _client.GetAsync("/api/health");
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    }
}
