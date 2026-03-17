
using HelloWorld.Api.Services;
using Xunit;

namespace HelloWorld.UnitTests;

public class GreetingServiceTests
{
    [Fact]
    public void GetMessage_ReturnsExpectedValue()
    {
        var service = new GreetingService();
        var result = service.GetMessage();
        Assert.Equal("Hello World from .NET 9", result);
    }
}
