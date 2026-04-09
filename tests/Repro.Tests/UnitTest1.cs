using Microsoft.Extensions.DependencyInjection;
using Repro.Application;

namespace Repro.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var services = new ServiceCollection();
        services.AddApplication();

        var serviceProvider = services.BuildServiceProvider();
        var mediator = serviceProvider.GetRequiredService<Mediator.IMediator>();

        var result = await mediator.Send(new PingQuery("pong"));

        Assert.Equal("pong", result);
    }
}
