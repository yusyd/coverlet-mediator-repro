using Repro.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/ping", async (Mediator.IMediator mediator, CancellationToken cancellationToken) =>
{
    return await mediator.Send(new PingQuery("pong"), cancellationToken);
});

app.Run();
